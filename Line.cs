// Decompiled with JetBrains decompiler
// Type: Line
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class Line
{
  public int x0;
  public int y0;
  public int x1;
  public int y1;
  public int vx;
  public int vy;
  public int f;
  public int fRe;
  public int idColor;
  public int type;
  public bool is2Line;
  public FrameImage fraImgEff;
  public int[] frame;

  public void setLine(int x0, int y0, int x1, int y1, int vx, int vy, bool is2Line)
  {
    this.x0 = x0;
    this.y0 = y0;
    this.x1 = x1;
    this.y1 = y1;
    this.vx = vx;
    this.vy = vy;
    this.is2Line = is2Line;
  }

  public void update()
  {
    this.x0 += this.vx;
    this.x1 += this.vx;
    this.y0 += this.vy;
    this.y1 += this.vy;
    ++this.f;
  }

  public void update_not_F()
  {
    this.x0 += this.vx;
    this.x1 += this.vx;
    this.y0 += this.vy;
    this.y1 += this.vy;
  }
}
