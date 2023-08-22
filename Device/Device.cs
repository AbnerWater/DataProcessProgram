using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DeviceControl
{
    public class RsDevice : RsConnection
    {
        public double Data { get { return _signal; } }
        private double _signal;
        private double _voletOffset = 0;
        private bool _isVirtual = false;
        private bool _enableLowPass = false;
        private double _lowPass = 0;
        private DeviceMode _mode = DeviceMode.Pack;
        public double LowPass { get { return _lowPass; } }
        public bool LowPassEnabled { get { return _enableLowPass; } }
        public DeviceMode Mode { get { return _mode; } }
        public event EventHandler DataPrinted;
        private Random _ran;
        public RsDevice(int time,bool virtualDev=false) : base(time)
        {
            _isVirtual = virtualDev;
        }
        protected override void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            base._timer_Elapsed(sender, e);
            if(_isVirtual)
            {
                _signal = _ran.NextDouble() * 10 + _voletOffset;
            }
        }
        public void SetVirtual(bool enable)
        {
            _isVirtual = enable;
            if (_isVirtual)
            {
                _timer.Start();
                _ran = new Random();
            }
            else
                _timer.Stop();
                
        }
        public void SetVoletOffset(double value)
        {
            _voletOffset = value;
        }
        protected override void processData(byte[] data)
        {
            switch (_mode)
            {
                case DeviceMode.Pack:
                    if (data.Length == 7)
                    {
                        if (data[0] == 0x5a && data[1] == 0x5b)
                        {
                            float f = BitConverter.ToSingle(data, 2) + (float)_voletOffset;
                            _signal = f;
                        }
                    }
                    break;
                case DeviceMode.Printf:
                    string str = Encoding.ASCII.GetString(data);
                    if(DataPrinted!=null)
                    {
                        DataPrinted(str, new EventArgs());
                    }
                    break;
                default:
                    break;
            }

        }
        #region device control
        public void SwitchPackMode()
        {
            string data = "pack";
            if (SendData(Encoding.ASCII.GetBytes(data)))
                _mode = DeviceMode.Pack;
        }
        public void SwitchPrintMode()
        {
            string data = "printf";
            if (SendData(Encoding.ASCII.GetBytes(data)))
                _mode = DeviceMode.Printf;
        }
        public void SetRawData()
        {
            string data = "raw";
            if (SendData(Encoding.ASCII.GetBytes(data)))
                _enableLowPass = false;
        }
        public void SetLowPass(double lowpass)
        {
            string data = string.Format("lowpass{0:f1}", lowpass);
            if (SendData(Encoding.ASCII.GetBytes(data)))
            {
                _enableLowPass = true;
                _lowPass=lowpass;
            }
        }
        #endregion
    }
    public enum DeviceMode
    {
        Pack=0,
        Printf=1,
    }
}
