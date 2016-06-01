using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVS_DiskUP
{
    class Constants
    {
        //This class is values from MapiConstants.dll (PVS server 7.9 referenced here) 
        public enum WriteCacheType
        {
        None = 0,
        Server = 1,
        ServerEncrypted = 2,
        RAM = 3,
        ClientHD = 4,
        ClientHDEncrypted = 5,
        RAMDisk = 6,
        ServerHDPersist = 7,
        ClientHDPersist = 8,
        ClientRAMwithOverflowOnHD = 9
    }
    }
}
