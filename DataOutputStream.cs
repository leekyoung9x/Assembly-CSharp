﻿// Decompiled with JetBrains decompiler
// Type: DataOutputStream
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class DataOutputStream
{
  private myWriter w = new myWriter();

  public DataOutputStream()
  {
  }

  public DataOutputStream(int len) => this.w = new myWriter(len);

  public void writeShort(short i) => this.w.writeShort(i);

  public void writeInt(int i) => this.w.writeInt(i);

  public void write(sbyte[] data) => this.w.writeSByte(data);

  public sbyte[] toByteArray() => this.w.getData();

  public void close() => this.w.Close();

  public void writeByte(sbyte b) => this.w.writeByte(b);

  public void writeUTF(string name) => this.w.writeUTF(name);

  public void writeBoolean(bool b) => this.w.writeBoolean(b);
}
