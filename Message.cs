// Decompiled with JetBrains decompiler
// Type: Message
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class Message
{
  public sbyte command;
  private myReader dis;
  private myWriter dos;

  public Message(int command)
  {
    this.command = (sbyte) command;
    this.dos = new myWriter();
  }

  public Message() => this.dos = new myWriter();

  public Message(sbyte command)
  {
    this.command = command;
    this.dos = new myWriter();
  }

  public Message(sbyte command, sbyte[] data)
  {
    this.command = command;
    this.dis = new myReader(data);
  }

  public sbyte[] getData() => this.dos.getData();

  public myReader reader() => this.dis;

  public myWriter writer() => this.dos;

  public int readInt3Byte() => this.dis.readInt();

  public void cleanup()
  {
  }
}
