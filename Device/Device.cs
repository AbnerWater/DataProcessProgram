using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceControl
{
    public class RsDevice : RsConnection
    {
        public RsDevice(int time) : base(time)
        {
        }
    }
    public class TcpDevice : TcpConnection
    {
        public TcpDevice(int time) : base(time)
        {
        }
    }
}
