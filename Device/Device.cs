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
        public double[] Data { get { return _signal; } }
        private double[] _signal;
        private bool _isVirtual = false;
        private Random _ran;
        public RsDevice(int time,bool virtualDev=false) : base(time)
        {
            _signal = new double[2];
            _isVirtual = virtualDev;
        }
        protected override void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            base._timer_Elapsed(sender, e);
            if(_isVirtual)
            {
                _signal[0] = _ran.NextDouble() * 10 - 5;
                _signal[1] = _ran.NextDouble()-0.5 ;
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
                
        }
    }
    public class TcpDevice : TcpConnection
    {
        public TcpDevice(int time) : base(time)
        {
        }
    }
}
