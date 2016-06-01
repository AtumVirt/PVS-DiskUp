using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ByteSizeLib;
namespace PVS_DiskUP
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public struct VDISK_HEADER
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] cSignature;
        public byte nVersionHigh;
        public byte nVersionLow;
        public ushort nReserved;
        public uint nCylinders;
        public uint nHeads;
        public uint nSectorsPerTrack;
        public uint nTotalSectorsLowPart;
        public uint nTotalSectorsHighPart;
        public ushort nSectorSize;
        public ushort nNicVendorID;
        public ushort nNicDeviceID;
        public ushort nNicBusDevFunction;
        public ushort nNicBaseIo;
        public ushort nNicIrq;
        public uint nVhdBlockSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 204)]
        public byte[] publicPad;
        public uint version;
        public uint writeCacheType;
        public uint writeCacheSize;
        public uint enableMulticast;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] multicastAddress;
        public byte multicastTimeToLive;
        public byte multicastInviteType;
        public uint multicastInvitePeriod;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string diskClass;
        public byte autoUpdateEnabled;
        public byte activeDay;
        public byte activeMonth;
        public ushort activeYear;
        public byte activationDateEnabled;
        public byte adPasswordEnabled;
        public uint licenseMask;
        public uint deviceMask;
        public byte printerManagementEnabled;
        public uint sizeOfEndObjectNames;
        public uint objectNamesUpdateTime;
        public byte enableIpSec;
        public byte osType;
        public byte portBlockerEnabled;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string type;
        public long propertiesUpdateTime;
        public byte licenseMode;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 34)]
        public byte[] pad;
    }

    public class VDISK_HEADER_WRAPPER
    {
        private VDISK_HEADER header;
        public VDISK_HEADER_WRAPPER(VDISK_HEADER header)
        {
            this.header = header;
        }
        [CategoryAttribute("PVS Specific")]
        public string cSignature
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var b in header.cSignature)
                {
                    sb.Append(b + ":");
                }
                return sb.ToString().TrimEnd(':');
            }
        }

        public byte nVersionHigh { get { return header.nVersionHigh; } }
        public byte nVersionLow { get { return header.nVersionLow; } }
        public ushort nReserved { get { return header.nReserved; } }
        [CategoryAttribute("Disk Structure")]
        public uint nCylinders { get { return header.nCylinders; } }
        [CategoryAttribute("Disk Structure")]
        public uint nHeads { get { return header.nHeads; } }
        [CategoryAttribute("Disk Structure")]
        public uint nSectorsPerTrack { get { return header.nSectorsPerTrack; } }
        [CategoryAttribute("Disk Structure")]
        public uint nTotalSectorsLowPart { get { return header.nTotalSectorsLowPart; } }
        [CategoryAttribute("Disk Structure")]
        public uint nTotalSectorsHighPart { get { return header.nTotalSectorsHighPart; } }
        [CategoryAttribute("Disk Structure")]
        public ushort nSectorSize { get { return header.nSectorSize; } }
        public ushort nNicVendorID { get { return header.nNicVendorID; } }
        public ushort nNicDeviceID { get { return header.nNicDeviceID; } }
        public ushort nNicBusDevFunction { get { return header.nNicBusDevFunction; } }
        public ushort nNicBaseIo { get { return header.nNicBaseIo; } }
        public ushort nNicIrq { get { return header.nNicIrq; } }
        [CategoryAttribute("Disk Structure")]
        public string nVhdBlockSize { get { return ByteSize.FromBytes(header.nVhdBlockSize).ToString(); } }
        [BrowsableAttribute(false)]
        public byte[] publicPad { get { return header.publicPad; } }
        [CategoryAttribute("PVS Specific")]
        public uint version { get { return header.version; } }
        [CategoryAttribute("PVS Specific")]
        public string writeCacheType { get {                

                return Enum.GetName(typeof(Constants.WriteCacheType), header.writeCacheType);
            } }
        [CategoryAttribute("PVS Specific")]
        public string writeCacheSize
        {
            get
            {
                if (header.writeCacheSize > 1024)
                {
                    return ByteSize.FromMegaBytes(header.writeCacheSize).ToString();
                }
                return header.writeCacheSize.ToString() + "MB";
            }
        }
        [CategoryAttribute("Network Settings")]
        public uint enableMulticast { get { return header.enableMulticast; } }
        [CategoryAttribute("Network Settings")]
        public byte[] multicastAddress { get { return header.multicastAddress; } }
        [CategoryAttribute("Network Settings")]
        public byte multicastTimeToLive { get { return header.multicastTimeToLive; } }
        [CategoryAttribute("Network Settings")]
        public byte multicastInviteType { get { return header.multicastInviteType; } }
        [CategoryAttribute("Network Settings")]
        public uint multicastInvitePeriod { get { return header.multicastInvitePeriod; } }
        [CategoryAttribute("PVS Specific")]
        public string diskClass { get { return header.diskClass; } }
        [CategoryAttribute("PVS Specific")]
        public byte autoUpdateEnabled { get { return header.autoUpdateEnabled; } }
        //[CategoryAttribute("Disk Promotion Schedule")]
        public byte activeDay { get { return header.activeDay; } }
        //[CategoryAttribute("Disk Promotion Schedule")]
        public byte activeMonth { get { return header.activeMonth; } }
        //[CategoryAttribute("Disk Promotion Schedule")]
        public ushort activeYear { get { return header.activeYear; } }
        //[CategoryAttribute("Disk Promotion Schedule")]
        public byte activationDateEnabled { get { return header.activationDateEnabled; } }
        [CategoryAttribute("PVS Specific")]
        public byte adPasswordEnabled { get { return header.adPasswordEnabled; } }
        [CategoryAttribute("PVS Specific")]
        public uint licenseMask { get { return header.licenseMask; } }
        [CategoryAttribute("PVS Specific")]
        public uint deviceMask { get { return header.deviceMask; } }
        [CategoryAttribute("PVS Specific")]
        public byte printerManagementEnabled { get { return header.printerManagementEnabled; } }
        public uint sizeOfEndObjectNames { get { return header.sizeOfEndObjectNames; } }
        public uint objectNamesUpdateTime { get { return header.objectNamesUpdateTime; } }
        public byte enableIpSec { get { return header.enableIpSec; } }
        [CategoryAttribute("PVS Specific")]
        public byte osType { get { return header.osType; } }
        public byte portBlockerEnabled { get { return header.portBlockerEnabled; } }
        public string type { get { return header.type; } }
        [CategoryAttribute("PVS Specific")]
        public long propertiesUpdateTime { get { return header.propertiesUpdateTime; } }
        [CategoryAttribute("PVS Specific")]
        public byte licenseMode { get { return header.licenseMode; } }
        [BrowsableAttribute(false)]
        public byte[] pad { get { return header.pad; } }
    }


    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public struct VDISK_FOOTER
    {
        public uint FooterVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 400)]
        public string LongDescription;
        public uint MajorRelease;
        public uint MinorRelease;
        public uint Build;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 37)]
        public string SerialNumber;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Date;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Author;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Title;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Company;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
        public string publicName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string OriginalFile;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string HardwareTarget;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2238)]
        public byte[] pad;
    }

    public class VDISK_FOOTER_WRAPPER
    {
        private VDISK_FOOTER footer;
        public VDISK_FOOTER_WRAPPER(VDISK_FOOTER footer)
        {
            this.footer = footer;
        }
        [BrowsableAttribute(false), CategoryAttribute("VHD Info")]
        public uint FooterVersion { get { return footer.FooterVersion; } }
        [CategoryAttribute("PVS Specific")]
        public string LongDescription { get { return footer.LongDescription; } }
        [CategoryAttribute("PVS Specific")]
        public uint MajorRelease { get { return footer.MajorRelease; } }
        [CategoryAttribute("PVS Specific")]
        public uint MinorRelease { get { return footer.MinorRelease; } }
        [CategoryAttribute("PVS Specific")]
        public uint Build { get { return footer.Build; } }
        [CategoryAttribute("PVS Specific")]
        public string SerialNumber { get { return footer.SerialNumber; } }
        [CategoryAttribute("PVS Specific")]
        public string Date { get { return footer.Date; } }
        [CategoryAttribute("PVS Specific")]
        public string Author { get { return footer.Author; } }
        [CategoryAttribute("PVS Specific")]
        public string Title { get { return footer.Title; } }
        [CategoryAttribute("PVS Specific")]
        public string Company { get { return footer.Company; } }
        [CategoryAttribute("PVS Specific")]
        public string publicName { get { return footer.publicName; } }
        [CategoryAttribute("PVS Specific")]
        public string OriginalFile { get { return footer.OriginalFile; } }
        [CategoryAttribute("PVS Specific")]
        public string HardwareTarget { get { return footer.HardwareTarget; } }
        [BrowsableAttribute(false)]
        public byte[] pad { get { return footer.pad; } }
    }

}
