using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DeviceMapper.Base
{
    public interface IDeviceConfiguration : ISerializable
    {
        T GetParameter<T>(string name, T def);

        //DeviceUri ToUri();
    }
}
