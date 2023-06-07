// Decompiled with JetBrains decompiler
// Type: EPosition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class EPosition
{
  public int x;
  public int y;
  public int anchor;
  public sbyte follow;
  public sbyte count;
  public sbyte dir = 1;
  public short index = -1;

  public EPosition(int x, int y)
  {
    this.x = x;
    this.y = y;
  }

  public EPosition(int x, int y, int fol)
  {
    this.x = x;
    this.y = y;
    this.follow = (sbyte) fol;
  }

  public EPosition()
  {
  }
}
