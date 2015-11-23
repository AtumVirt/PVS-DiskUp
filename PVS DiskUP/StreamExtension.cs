using System.IO;
using System.Runtime.InteropServices;

namespace PVS_DiskUP {
  public static class StreamExtension {
    public static T? ReadStructure<T>(this Stream stream) where T : struct {
      if (stream == null)
        return null;

      int size = Marshal.SizeOf(typeof(T));
      byte[] bytes = new byte[size];
      if (stream.Read(bytes, 0, size) != size)
        return null;

      GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
      try {
        return (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
      } finally {
        handle.Free();
      }
    }
  }
}
