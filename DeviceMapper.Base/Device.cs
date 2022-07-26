using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceMapper.Base
{
    public class Device : IADevice
    {
        public string Name { get; set; }

        public int Port { get; set; }

        public ushort Transmit(byte[] a)
        {
            throw new NotImplementedException();
        }
    }
}
