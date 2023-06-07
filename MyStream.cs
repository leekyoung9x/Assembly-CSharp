// Decompiled with JetBrains decompiler
// Type: MyStream
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

using System;

public class MyStream
{
  public static DataInputStream readFile(string path)
  {
    path = Main.res + path;
    try
    {
      return DataInputStream.getResourceAsStream(path);
    }
    catch (Exception ex)
    {
      return (DataInputStream) null;
    }
  }
}
