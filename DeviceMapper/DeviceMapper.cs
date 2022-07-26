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
