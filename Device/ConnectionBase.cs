using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeviceControl
{
    public class RsConnection
    {
        #region variables
        public string PortName { get; set; }
        public int BaudRate { get; set; }
        private SerialPort _port;
        public bool Connection {
            get
            {
                if (_port == null)
                    return false;
                else
                    return _port.IsOpen;
            }
        }
        public event EventHandler ExceptionThrowed;
        protected System.Timers.Timer _timer;
        #endregion
        #region methods
        public RsConnection(int time)
        {
            _timer = new System.Timers.Timer(time);
            _timer.AutoReset = true;
            _timer.Elapsed += _timer_Elapsed;
        }
        protected virtual void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

        }
        public bool Disconnect()
        {
            if (_port.IsOpen)
            {
                _port.DataReceived -= _port_DataReceived;
                _port.Close();
                return true;
            }
            else
                return false;
        }
        public bool Reconnect()
        {
            if (_port.IsOpen)
            {
                _port.DataReceived -= _port_DataReceived;
                _port.Close();
            }
            try
            {
                _port = new SerialPort(PortName, BaudRate, Parity.None, 8, StopBits.One);
                _port.Open();
                if (_port.IsOpen)
                {
                    _port.DataReceived += _port_DataReceived;
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                ExceptionThrowed(ex.ToString(), new EventArgs());
                return false;
            }
        }
        protected void throwMessage(string message)
        {
            ExceptionThrowed(message, new EventArgs());
        }
        private void _port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(10);
            if (_port.IsOpen)
            {
                int count = _port.BytesToRead;
                if (count > 0)
                {
                    char[] readBuffer = new char[count];
                    _port.Read(readBuffer, 0, count);
                }
            }
        }
        protected virtual void processData(byte[] data) { }
        public virtual bool Connect(string port, int rate)
        {
            PortName = port;
            BaudRate = rate;
            try
            {
                _port = new SerialPort(PortName, BaudRate, Parity.None, 8, StopBits.One);
                _port.Open();
                if (_port.IsOpen)
                {
                    _port.DataReceived += _port_DataReceived;
                    _timer.Start();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                ExceptionThrowed(ex.ToString(), new EventArgs());
                return false;
            }
        }
        public bool SendData(byte[] data)
        {
            try
            {
                if (_port.IsOpen)
                {
                    _port.Write(data, 0, data.Length);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                ExceptionThrowed(ex.ToString(), new EventArgs());
                return false;
            }
        }
        public virtual void Dispose()
        {
            if (_port != null)
            {
                if (_port.IsOpen)
                {
                    _port.Close();
                }
                _port.Dispose();
                _port = null;
            }
            if (_timer != null)
            {
                _timer.Stop();
                _timer.Dispose();
                _timer = null;
            }
        }
        #endregion
    }
    public class TcpConnection
    {
        #region variables
        protected IPAddress remoteip;
        protected int port;
        protected Socket _tcp;
        protected Thread _thrRecv;
        protected IPEndPoint _local;
        protected IPEndPoint _remote;
        public string IpAdd { get { return _remote.ToString(); } }
        public bool Connection
        {
            get
            {
                if (_tcp == null)
                    return false;
                else
                    return _tcp.Connected;
            }
        }
        public event EventHandler ExceptionThrowed;
        protected System.Timers.Timer _timer;
        #endregion
        public TcpConnection(int time)
        {
            _timer = new System.Timers.Timer(time);
            _timer.AutoReset = true;
            _timer.Elapsed += _timer_Elapsed;
        }
        #region methods
        public bool Connect(string localIP, string localport, string target, string remoteport)
        {
            try
            {
                remoteip = IPAddress.Parse(target);
                port = int.Parse(remoteport);
                _local = new IPEndPoint(IPAddress.Parse(localIP), int.Parse(localport));
                _remote = new IPEndPoint(remoteip, port);
                _tcp = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _tcp.Connect(_remote);
                _thrRecv = new Thread(tcp_receive);
                _thrRecv.IsBackground = true;
                _thrRecv.Start();
                if (_tcp.Connected)
                {
                    _timer.Start();
                    return true;
                }
                else
                    return false;
            }
            catch (System.Exception ex)
            {
                ExceptionThrowed(ex.ToString(), new EventArgs());
                return false;
            }
        }
        protected virtual void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
        }
        public bool Reconnect()
        {
            try
            {
                if (_tcp == null)
                    return false;
                if (Connection)
                    return true;
                _tcp.Connect(_remote);
                return _tcp.Connected;
            }
            catch (System.Exception ex)
            {
                ExceptionThrowed(ex.ToString(), new EventArgs());
                return false;
            }
        }
        public void Disconnect()
        {
            if (_thrRecv != null)
            {
                _thrRecv.Abort();
                _thrRecv = null;
            }
            if (_tcp != null)
            {
                _tcp.Disconnect(true);
                _tcp.Close();
                _tcp.Dispose();
                _tcp = null;
            }
        }
        protected void throwMessage(string message)
        {
            ExceptionThrowed(message, new EventArgs());
        }
        private void tcp_receive()
        {
            while (_tcp.Connected)
            {
                try
                {
                    byte[] receiveBuffer = new byte[512];
                    if (_remote.Address != remoteip)
                        _remote = new IPEndPoint(remoteip, port);
                    int count = _tcp.Receive(receiveBuffer);
                    if (count > 0)
                    {
                        byte[] data = new byte[count];
                        Array.Copy(receiveBuffer, 0, data, 0, count);
                        processData(data);
                    }
                }
                catch (System.Exception ex)
                {
                    ExceptionThrowed(ex.ToString(), new EventArgs());
                    continue;
                }
            }
        }
        protected virtual void processData(byte[] data) { }
        public bool SendData(byte[] data)
        {
            if (!Connection)
                return false;
            if (_remote.Address != remoteip)
                _remote = new IPEndPoint(remoteip, port);
            try
            {
                _tcp.BeginSend(data, 0, data.Length, SocketFlags.None, null, null);
                return true;
            }
            catch (Exception ex)
            {
                ExceptionThrowed(ex.ToString(), new EventArgs());
                return false;
            }
        }
        public virtual void Dispose()
        {
            if (_thrRecv != null)
            {
                _thrRecv.Abort();
                _thrRecv = null;
            }
            if (_tcp != null)
            {
                if (_tcp.Connected)
                {
                    _tcp.Disconnect(true);
                    _tcp.Close();
                }
                _tcp.Dispose();
                _tcp = null;
            }
            if (_timer != null)
            {
                _timer.Stop();
                _timer.Dispose();
                _timer = null;
            }
        }
        #endregion
    }
}
