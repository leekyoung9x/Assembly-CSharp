// Decompiled with JetBrains decompiler
// Type: ArrayCast
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class ArrayCast
{
  public static sbyte[] cast(byte[] data)
  {
    sbyte[] numArray = new sbyte[data.Length];
    for (int index = 0; index < numArray.Length; ++index)
      numArray[index] = (sbyte) data[index];
    return numArray;
  }

  public static byte[] cast(sbyte[] data)
  {
    byte[] numArray = new byte[data.Length];
    for (int index = 0; index < numArray.Length; ++index)
      numArray[index] = (byte) data[index];
    return numArray;
  }

  public static char[] ToCharArray(sbyte[] data)
  {
    char[] charArray = new char[data.Length];
    for (int index = 0; index < charArray.Length; ++index)
      charArray[index] = (char) data[index];
    return charArray;
  }
}
