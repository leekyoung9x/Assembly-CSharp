// Decompiled with JetBrains decompiler
// Type: Friend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class Friend
{
  public string friendName;
  public sbyte type;

  public Friend(string friendName, sbyte type)
  {
    this.friendName = friendName;
    this.type = type;
  }

  public Friend(string friendName)
  {
    this.friendName = friendName;
    this.type = (sbyte) 2;
  }
}
