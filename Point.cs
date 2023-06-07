// Decompiled with JetBrains decompiler
// Type: Point
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class Point
{
  public sbyte type;
  public int x;
  public int y;
  public int g;
  public int v;
  public int vMax;
  public int w;
  public int h;
  public int color;
  public int limitY;
  public int vx;
  public int vy;
  public int x2;
  public int y2;
  public int toX;
  public int toY;
  public int dis;
  public int f;
  public int ftam;
  public int fRe;
  public int frame;
  public int maxframe;
  public int fSmall;
  public int goc;
  public int gocT_Arc;
  public int idir;
  public int dirThrow;
  public int dir;
  public int dir_nguoc;
  public int idSkill;
  public int id;
  public int levelPaint;
  public int num_per_frame = 1;
  public int life;
  public int goc_Arc;
  public int vx1000;
  public int vy1000;
  public int va;
  public int x1000;
  public int y1000;
  public int vX1000;
  public int vY1000;
  public long time;
  public long timecount;
  public MyVector vecEffPoint;
  public string name;
  public string info;
  public bool isRemove;
  public bool isSmall;
  public bool isPaint;
  public bool isChange;
  public static FrameImage[] FraEffInMap;
  public FrameImage fraImgEff;
  public FrameImage fraImgEff_2;
  public byte[] mpaintone_Arrow = new byte[24]
  {
    (byte) 12,
    (byte) 11,
    (byte) 10,
    (byte) 9,
    (byte) 8,
    (byte) 7,
    (byte) 6,
    (byte) 5,
    (byte) 4,
    (byte) 3,
    (byte) 2,
    (byte) 1,
    (byte) 0,
    (byte) 23,
    (byte) 22,
    (byte) 21,
    (byte) 20,
    (byte) 19,
    (byte) 18,
    (byte) 17,
    (byte) 16,
    (byte) 15,
    (byte) 14,
    (byte) 13
  };
  public byte[] mImageArrow = new byte[24]
  {
    (byte) 0,
    (byte) 0,
    (byte) 2,
    (byte) 1,
    (byte) 1,
    (byte) 2,
    (byte) 0,
    (byte) 0,
    (byte) 2,
    (byte) 1,
    (byte) 1,
    (byte) 2,
    (byte) 0,
    (byte) 0,
    (byte) 2,
    (byte) 1,
    (byte) 1,
    (byte) 2,
    (byte) 0,
    (byte) 0,
    (byte) 2,
    (byte) 1,
    (byte) 1,
    (byte) 2
  };
  public byte[] mXoayArrow = new byte[24]
  {
    (byte) 2,
    (byte) 2,
    (byte) 3,
    (byte) 3,
    (byte) 3,
    (byte) 4,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 1,
    (byte) 0,
    (byte) 0,
    (byte) 0,
    (byte) 0,
    (byte) 0,
    (byte) 7,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 2
  };

  public Point()
  {
  }

  public Point(int x, int y)
  {
    this.x = x;
    this.y = y;
  }

  public Point(int x, int y, int goc)
  {
    this.x = x;
    this.y = y;
    this.goc = goc;
  }

  public void update()
  {
    ++this.f;
    this.x += this.vx;
    this.y += this.vy;
  }

  public void update_not_f()
  {
    this.x += this.vx;
    this.y += this.vy;
  }

  public void paint(mGraphics g)
  {
    if (this.isRemove)
      return;
    int num = 0;
    if (this.isSmall && this.f >= this.fSmall)
      num = 1;
    Point.FraEffInMap[this.color].drawFrame(this.frame / 2 + num, this.x, this.y, this.dis, 3, g);
  }

  public void updateInMap()
  {
    ++this.f;
    if (this.maxframe > 1)
    {
      ++this.frame;
      if (this.frame / 2 >= this.maxframe)
        this.frame = 0;
    }
    if (this.f < this.fRe)
      return;
    this.isRemove = true;
  }

  public int setFrameAngle(int goc)
  {
    int num;
    if (goc <= 15 || goc > 345)
    {
      num = 12;
    }
    else
    {
      int index = (goc - 15) / 15 + 1;
      if (index > 24)
        index = 24;
      num = (int) this.mpaintone_Arrow[index];
    }
    return num;
  }

  public void create_Arrow(int vMax)
  {
    this.vMax = vMax;
    int dx = this.toX - this.x;
    int dy = this.toY - this.y;
    if (this.x > this.toX)
    {
      this.dir = 2;
      this.dir_nguoc = 0;
    }
    else
    {
      this.dir = 0;
      this.dir_nguoc = 2;
    }
    this.create_Speed(dx, dy);
  }

  public void create_Speed(int dx, int dy)
  {
    this.frame = this.setFrameAngle(Res.angle(dx, dy));
    int num = Res.getDistance(dx, dy) / this.vMax;
    if (num == 0)
      num = 1;
    int i1 = dx / num;
    int i2 = dy / num;
    if (i1 == 0 && dx < num)
      i1 = dx >= 0 ? 1 : -1;
    if (i2 == 0 && dy < num)
      i2 = dy >= 0 ? 1 : -1;
    if (Res.abs(i1) > Res.abs(dx))
      i1 = dx;
    if (Res.abs(i2) > Res.abs(dy))
      i2 = dy;
    this.vx = i1;
    this.vy = i2;
  }

  public void moveTo_xy(int toX, int toY)
  {
    int dx = toX - this.x;
    int dy = toY - this.y;
    if (dx > 1)
      this.frame = this.setFrameAngle(Res.angle(dx, dy));
    if (Res.abs(this.vx) > 0)
    {
      if (Res.abs(this.x - toX) < Res.abs(this.vx))
      {
        this.x = toX;
        this.vx = 0;
      }
      else
        this.x += this.vx;
    }
    else
    {
      this.x = toX;
      this.vx = 0;
    }
    if (Res.abs(this.vy) > 0)
    {
      if (Res.abs(this.y - toY) < Res.abs(this.vy))
      {
        this.y = toY;
        this.vy = 0;
      }
      else
        this.y += this.vy;
    }
    else
    {
      this.y = toY;
      this.vy = 0;
    }
  }

  public void paint_Arrow(mGraphics g, FrameImage frm, int anchor, bool isCountFr)
  {
    if (frm == null)
      return;
    int num1 = frm.nFrame / 3;
    if (num1 < 1)
      num1 = 1;
    int num2 = 3;
    int num3 = frm.nFrame <= 3 ? this.f % num1 : (this.f / num2 % 2 != 0 ? 3 : 0);
    int idx = num1 * (int) this.mImageArrow[this.frame] + num3;
    if (frm.nFrame < 3)
      idx = this.f / num2 % frm.nFrame;
    if (isCountFr)
      idx = this.f / num2 % frm.nFrame;
    frm.drawFrame(idx, this.x, this.y, (int) this.mXoayArrow[this.frame], anchor, g);
  }
}
