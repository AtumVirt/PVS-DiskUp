// Decompiled with JetBrains decompiler
// Type: ByteSizeLib.ByteSize
// Assembly: ByteSizeLib, Version=0.2.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EE1F0307-C3F3-4E6F-914E-7AF8E05EFDCF
// Assembly location: D:\git\PVS-DiskUp\PVS DiskUP\bin\Release\ByteSizeLib.dll

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

namespace ByteSizeLib
{
  [StructLayout(LayoutKind.Sequential, Size = 1)]
  public struct ByteSize : IComparable<ByteSize>, IEquatable<ByteSize>
  {
    public static readonly ByteSize MinValue = ByteSize.FromBits(long.MinValue);
    public static readonly ByteSize MaxValue = ByteSize.FromBits(long.MaxValue);
    public const long BitsInByte = 8;
    public const long BytesInKiloByte = 1024;
    public const long BytesInMegaByte = 1048576;
    public const long BytesInGigaByte = 1073741824;
    public const long BytesInTeraByte = 1099511627776;
    public const long BytesInPetaByte = 1125899906842624;
    public const string BitSymbol = "b";
    public const string ByteSymbol = "B";
    public const string KiloByteSymbol = "KB";
    public const string MegaByteSymbol = "MB";
    public const string GigaByteSymbol = "GB";
    public const string TeraByteSymbol = "TB";
    public const string PetaByteSymbol = "PB";

    public long Bits { get; private set; }

    public double Bytes { get; private set; }

    public double KiloBytes { get; private set; }

    public double MegaBytes { get; private set; }

    public double GigaBytes { get; private set; }

    public double TeraBytes { get; private set; }

    public double PetaBytes { get; private set; }

    public string LargestWholeNumberSymbol
    {
      get
      {
        if (Math.Abs(this.PetaBytes) >= 1.0)
          return "PB";
        if (Math.Abs(this.TeraBytes) >= 1.0)
          return "TB";
        if (Math.Abs(this.GigaBytes) >= 1.0)
          return "GB";
        if (Math.Abs(this.MegaBytes) >= 1.0)
          return "MB";
        if (Math.Abs(this.KiloBytes) >= 1.0)
          return "KB";
        return Math.Abs(this.Bytes) >= 1.0 ? "B" : "b";
      }
    }

    public double LargestWholeNumberValue
    {
      get
      {
        if (Math.Abs(this.PetaBytes) >= 1.0)
          return this.PetaBytes;
        if (Math.Abs(this.TeraBytes) >= 1.0)
          return this.TeraBytes;
        if (Math.Abs(this.GigaBytes) >= 1.0)
          return this.GigaBytes;
        if (Math.Abs(this.MegaBytes) >= 1.0)
          return this.MegaBytes;
        if (Math.Abs(this.KiloBytes) >= 1.0)
          return this.KiloBytes;
        if (Math.Abs(this.Bytes) >= 1.0)
          return this.Bytes;
        return (double)this.Bits;
      }
    }

    public ByteSize(double byteSize)
    {
      this = new ByteSize();
      this.Bits = (long)Math.Ceiling(byteSize * 8.0);
      this.Bytes = byteSize;
      this.KiloBytes = byteSize / 1024.0;
      this.MegaBytes = byteSize / 1048576.0;
      this.GigaBytes = byteSize / 1073741824.0;
      this.TeraBytes = byteSize / 1099511627776.0;
      this.PetaBytes = byteSize / 1.12589990684262E+15;
    }

    public static ByteSize operator +(ByteSize b1, ByteSize b2)
    {
      return new ByteSize(b1.Bytes + b2.Bytes);
    }

    public static ByteSize operator ++(ByteSize b)
    {
      return new ByteSize(b.Bytes + 1.0);
    }

    public static ByteSize operator -(ByteSize b)
    {
      return new ByteSize(-b.Bytes);
    }

    public static ByteSize operator --(ByteSize b)
    {
      return new ByteSize(b.Bytes - 1.0);
    }

    public static bool operator ==(ByteSize b1, ByteSize b2)
    {
      return b1.Bits == b2.Bits;
    }

    public static bool operator !=(ByteSize b1, ByteSize b2)
    {
      return b1.Bits != b2.Bits;
    }

    public static bool operator <(ByteSize b1, ByteSize b2)
    {
      return b1.Bits < b2.Bits;
    }

    public static bool operator <=(ByteSize b1, ByteSize b2)
    {
      return b1.Bits <= b2.Bits;
    }

    public static bool operator >(ByteSize b1, ByteSize b2)
    {
      return b1.Bits > b2.Bits;
    }

    public static bool operator >=(ByteSize b1, ByteSize b2)
    {
      return b1.Bits >= b2.Bits;
    }

    public static ByteSize FromBits(long value)
    {
      return new ByteSize((double)value / 8.0);
    }

    public static ByteSize FromBytes(double value)
    {
      return new ByteSize(value);
    }

    public static ByteSize FromKiloBytes(double value)
    {
      return new ByteSize(value * 1024.0);
    }

    public static ByteSize FromMegaBytes(double value)
    {
      return new ByteSize(value * 1048576.0);
    }

    public static ByteSize FromGigaBytes(double value)
    {
      return new ByteSize(value * 1073741824.0);
    }

    public static ByteSize FromTeraBytes(double value)
    {
      return new ByteSize(value * 1099511627776.0);
    }

    public static ByteSize FromPetaBytes(double value)
    {
      return new ByteSize(value * 1.12589990684262E+15);
    }

    public override string ToString()
    {
      return this.ToString("#.##", (IFormatProvider)CultureInfo.CurrentCulture);
    }

    public string ToString(string format)
    {
      return this.ToString(format, (IFormatProvider)CultureInfo.CurrentCulture);
    }

    public string ToString(string format, IFormatProvider provider)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ByteSize.\u003CToString\u003Ec__AnonStorey0 stringCAnonStorey0 = new ByteSize.\u003CToString\u003Ec__AnonStorey0();
      // ISSUE: reference to a compiler-generated field
      stringCAnonStorey0.format = format;
      // ISSUE: reference to a compiler-generated field
      stringCAnonStorey0.provider = provider;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      if (!stringCAnonStorey0.format.Contains("#") && !stringCAnonStorey0.format.Contains("0"))
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        stringCAnonStorey0.format = "#.## " + stringCAnonStorey0.format;
      }
      // ISSUE: reference to a compiler-generated field
      if (stringCAnonStorey0.provider == null)
      {
        // ISSUE: reference to a compiler-generated field
        stringCAnonStorey0.provider = (IFormatProvider)CultureInfo.CurrentCulture;
      }
      // ISSUE: reference to a compiler-generated method
      Func<string, bool> func1 = new Func<string, bool>(stringCAnonStorey0.\u003C\u003Em__0);
      // ISSUE: reference to a compiler-generated method
      Func<double, string> func2 = new Func<double, string>(stringCAnonStorey0.\u003C\u003Em__1);
      if (func1("PB"))
        return func2(this.PetaBytes);
      if (func1("TB"))
        return func2(this.TeraBytes);
      if (func1("GB"))
        return func2(this.GigaBytes);
      if (func1("MB"))
        return func2(this.MegaBytes);
      if (func1("KB"))
        return func2(this.KiloBytes);
      // ISSUE: reference to a compiler-generated field
      if (stringCAnonStorey0.format.IndexOf("B") != -1)
        return func2(this.Bytes);
      // ISSUE: reference to a compiler-generated field
      if (stringCAnonStorey0.format.IndexOf("b") != -1)
        return func2((double)this.Bits);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return string.Format("{0} {1}", new object[2]
      {
        (object) this.LargestWholeNumberValue.ToString(stringCAnonStorey0.format, stringCAnonStorey0.provider),
        (object) this.LargestWholeNumberSymbol
      });
    }

    public override bool Equals(object value)
    {
      if (value == null || !(value is ByteSize))
        return false;
      return this.Equals((ByteSize)value);
    }

    public bool Equals(ByteSize value)
    {
      return this.Bits == value.Bits;
    }

    public override int GetHashCode()
    {
      return this.Bits.GetHashCode();
    }

    public int CompareTo(ByteSize other)
    {
      return this.Bits.CompareTo(other.Bits);
    }

    public ByteSize Add(ByteSize bs)
    {
      return new ByteSize(this.Bytes + bs.Bytes);
    }

    public ByteSize AddBits(long value)
    {
      return this + ByteSize.FromBits(value);
    }

    public ByteSize AddBytes(double value)
    {
      return this + ByteSize.FromBytes(value);
    }

    public ByteSize AddKiloBytes(double value)
    {
      return this + ByteSize.FromKiloBytes(value);
    }

    public ByteSize AddMegaBytes(double value)
    {
      return this + ByteSize.FromMegaBytes(value);
    }

    public ByteSize AddGigaBytes(double value)
    {
      return this + ByteSize.FromGigaBytes(value);
    }

    public ByteSize AddTeraBytes(double value)
    {
      return this + ByteSize.FromTeraBytes(value);
    }

    public ByteSize AddPetaBytes(double value)
    {
      return this + ByteSize.FromPetaBytes(value);
    }

    public ByteSize Subtract(ByteSize bs)
    {
      return new ByteSize(this.Bytes - bs.Bytes);
    }

    public static bool TryParse(string s, out ByteSize result)
    {
      if (string.IsNullOrWhiteSpace(s))
        throw new ArgumentNullException("s", "String is null or whitespace");
      result = new ByteSize();
      s = s.TrimStart();
      bool flag = false;
      int index;
      for (index = 0; index < s.Length; ++index)
      {
        if (!char.IsDigit(s[index]) && (int)s[index] != 46)
        {
          flag = true;
          break;
        }
      }
      if (!flag)
        return false;
      int num1 = index;
      string s1 = s.Substring(0, num1).Trim();
      string key = s.Substring(num1, s.Length - num1).Trim();
      double result1;
      if (!double.TryParse(s1, NumberStyles.Float | NumberStyles.AllowThousands, (IFormatProvider)NumberFormatInfo.InvariantInfo, out result1))
        return false;
      if (key != null)
      {
        // ISSUE: reference to a compiler-generated field
        if (ByteSize.\u003C\u003Ef__switch\u0024map0 == null)
        {
          // ISSUE: reference to a compiler-generated field
          ByteSize.\u003C\u003Ef__switch\u0024map0 = new Dictionary<string, int>(17)
          {
            {
              "b",
              0
            },
            {
              "B",
              1
            },
            {
              "KB",
              2
            },
            {
              "kB",
              2
            },
            {
              "kb",
              2
            },
            {
              "MB",
              3
            },
            {
              "mB",
              3
            },
            {
              "mb",
              3
            },
            {
              "GB",
              4
            },
            {
              "gB",
              4
            },
            {
              "gb",
              4
            },
            {
              "TB",
              5
            },
            {
              "tB",
              5
            },
            {
              "tb",
              5
            },
            {
              "PB",
              6
            },
            {
              "pB",
              6
            },
            {
              "pb",
              6
            }
          };
        }
        int num2;
        // ISSUE: reference to a compiler-generated field
        if (ByteSize.\u003C\u003Ef__switch\u0024map0.TryGetValue(key, out num2))
        {
          switch (num2)
          {
            case 0:
              if (result1 % 1.0 != 0.0)
                return false;
              result = ByteSize.FromBits((long)result1);
              break;
            case 1:
              result = ByteSize.FromBytes(result1);
              break;
            case 2:
              result = ByteSize.FromKiloBytes(result1);
              break;
            case 3:
              result = ByteSize.FromMegaBytes(result1);
              break;
            case 4:
              result = ByteSize.FromGigaBytes(result1);
              break;
            case 5:
              result = ByteSize.FromTeraBytes(result1);
              break;
            case 6:
              result = ByteSize.FromPetaBytes(result1);
              break;
          }
        }
      }
      return true;
    }

    public static ByteSize Parse(string s)
    {
      ByteSize result;
      if (ByteSize.TryParse(s, out result))
        return result;
      throw new FormatException("Value is not in the correct format");
    }
  }
}
