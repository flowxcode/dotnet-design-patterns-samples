﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceMapper.Base
{
    public interface IADevice
    {
        ushort Transmit(byte[] a);
    }
}