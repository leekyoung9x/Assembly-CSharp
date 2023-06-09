﻿// Decompiled with JetBrains decompiler
// Type: myWriter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

using System.Text;

public class myWriter
{
  public sbyte[] buffer = new sbyte[2048];
  private int posWrite;
  private int lenght = 2048;

  public myWriter()
  {
  }

  public myWriter(int len)
  {
    this.buffer = new sbyte[len];
    this.lenght = len;
  }

  public void writeSByte(sbyte value)
  {
    this.checkLenght(0);
    this.buffer[this.posWrite++] = value;
  }

  public void writeSByteUncheck(sbyte value) => this.buffer[this.posWrite++] = value;

  public void writeByte(sbyte value) => this.writeSByte(value);

  public void writeByte(int value) => this.writeSByte((sbyte) value);

  public void writeChar(char value)
  {
    this.writeSByte((sbyte) 0);
    this.writeSByte((sbyte) value);
  }

  public void writeUnsignedByte(byte value) => this.writeSByte((sbyte) value);

  public void writeUnsignedByte(byte[] value)
  {
    this.checkLenght(value.Length);
    for (int index = 0; index < value.Length; ++index)
      this.writeSByteUncheck((sbyte) value[index]);
  }

  public void writeSByte(sbyte[] value)
  {
    this.checkLenght(value.Length);
    for (int index = 0; index < value.Length; ++index)
      this.writeSByteUncheck(value[index]);
  }

  public void writeShort(short value)
  {
    this.checkLenght(2);
    for (int index = 1; index >= 0; --index)
      this.writeSByteUncheck((sbyte) ((int) value >> index * 8));
  }

  public void writeShort(int value)
  {
    this.checkLenght(2);
    short num = (short) value;
    for (int index = 1; index >= 0; --index)
      this.writeSByteUncheck((sbyte) ((int) num >> index * 8));
  }

  public void writeUnsignedShort(ushort value)
  {
    this.checkLenght(2);
    for (int index = 1; index >= 0; --index)
      this.writeSByteUncheck((sbyte) ((int) value >> index * 8));
  }

  public void writeInt(int value)
  {
    this.checkLenght(4);
    for (int index = 3; index >= 0; --index)
      this.writeSByteUncheck((sbyte) (value >> index * 8));
  }

  public void writeLong(long value)
  {
    this.checkLenght(8);
    for (int index = 7; index >= 0; --index)
      this.writeSByteUncheck((sbyte) (value >> index * 8));
  }

  public void writeBoolean(bool value) => this.writeSByte(!value ? (sbyte) 0 : (sbyte) 1);

  public void writeBool(bool value) => this.writeSByte(!value ? (sbyte) 0 : (sbyte) 1);

  public void writeString(string value)
  {
    char[] charArray = value.ToCharArray();
    this.writeShort((short) charArray.Length);
    this.checkLenght(charArray.Length);
    for (int index = 0; index < charArray.Length; ++index)
      this.writeSByteUncheck((sbyte) charArray[index]);
  }

  public void writeUTF(string value)
  {
    Encoding unicode = Encoding.Unicode;
    Encoding encoding = Encoding.GetEncoding(65001);
    byte[] bytes = unicode.GetBytes(value);
    byte[] numArray = Encoding.Convert(unicode, encoding, bytes);
    this.writeShort((short) numArray.Length);
    this.checkLenght(numArray.Length);
    for (int index = 0; index < numArray.Length; ++index)
      this.writeSByteUncheck((sbyte) numArray[index]);
  }

  public void write(ref sbyte[] data, int arg1, int arg2)
  {
    if (data == null)
      return;
    for (int index = 0; index < arg2; ++index)
    {
      this.writeSByte(data[index + arg1]);
      if (this.posWrite > this.buffer.Length)
        break;
    }
  }

  public void write(sbyte[] value) => this.writeSByte(value);

  public sbyte[] getData()
  {
    if (this.posWrite <= 0)
      return (sbyte[]) null;
    sbyte[] data = new sbyte[this.posWrite];
    for (int index = 0; index < this.posWrite; ++index)
      data[index] = this.buffer[index];
    return data;
  }

  public void checkLenght(int ltemp)
  {
    if (this.posWrite + ltemp <= this.lenght)
      return;
    sbyte[] numArray = new sbyte[this.lenght + 1024 + ltemp];
    for (int index = 0; index < this.lenght; ++index)
      numArray[index] = this.buffer[index];
    this.buffer = (sbyte[]) null;
    this.buffer = numArray;
    this.lenght += 1024 + ltemp;
  }

  public void Close() => this.buffer = (sbyte[]) null;

  public void close() => this.buffer = (sbyte[]) null;
}
