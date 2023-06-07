// Decompiled with JetBrains decompiler
// Type: BallInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class BallInfo
{
  public int x;
  public int y;
  public int xTo = -999;
  public int yTo = -999;
  public int count;
  public int vy;
  public int vx;
  public int dir;
  public int idImg;
  public bool isPaint = true;
  public bool isDone;
  public bool isSetImg;
  public Char cFocus;

  public void SetChar()
  {
    this.cFocus = new Char();
    this.cFocus.charID = Res.random(-999, -800);
    this.cFocus.head = -1;
    this.cFocus.body = -1;
    this.cFocus.leg = -1;
    this.cFocus.bag = -1;
    this.cFocus.cName = string.Empty;
    this.cFocus.cHP = this.cFocus.cHPFull = 20;
  }

  public void UpdChar()
  {
    this.cFocus.cx = this.x;
    this.cFocus.cy = this.y;
  }
}
