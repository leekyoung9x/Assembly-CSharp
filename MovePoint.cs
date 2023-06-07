// Decompiled with JetBrains decompiler
// Type: MovePoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class MovePoint
{
  public int xEnd;
  public int yEnd;
  public int dir;
  public int cvx;
  public int cvy;
  public int status;

  public MovePoint(int xEnd, int yEnd, int act, int dir)
  {
    this.xEnd = xEnd;
    this.yEnd = yEnd;
    this.dir = dir;
    this.status = act;
  }

  public MovePoint(int xEnd, int yEnd)
  {
    this.xEnd = xEnd;
    this.yEnd = yEnd;
  }
}
