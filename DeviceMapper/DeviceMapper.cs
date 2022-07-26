using DeviceMapper.Base;
using DeviceMapper.Black;
using DeviceMapper.White;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceMapper
{
    public class DeviceMapper : IDeviceMapper // factory class
    {
        public DeviceMapper()
        {
            Debug.WriteLine("ctor");
        }

        public Device GetDevice(string name)
        {
            if (name == null)
            {
                return null;
            }
            if (string.Equals(name, "white", StringComparison.OrdinalIgnoreCase))
            {
                return new WhiteDevice();

            }
            else if (string.Equals(name, "black", StringComparison.OrdinalIgnoreCase))
            {
                return new BlackDevice();

            }

            return null;
        }

        public IList<IDeviceConfiguration> FindDevices()
        {
            throw new NotImplementedException();
        }

        public IList<IDeviceConfiguration> FindDevicesFromConfig()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
