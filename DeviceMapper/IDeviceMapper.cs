using DeviceMapper.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceMapper
{
    public interface IDeviceMapper
    {
        void Initialize();

        IList<IDeviceConfiguration> FindDevices();

        IList<IDeviceConfiguration> FindDevicesFromConfig();

        //IDeviceConfiguration GetConfiguration(DeviceMapperProtocol protocol, string config, Type t);

        // TODO fcts
    }
}
