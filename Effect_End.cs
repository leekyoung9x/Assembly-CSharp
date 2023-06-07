// Decompiled with JetBrains decompiler
// Type: Effect_End
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

using System;

public class Effect_End
{
  public const sbyte Lvlpaint_All = -1;
  public const sbyte Lvlpaint_Front = 0;
  public const sbyte Lvlpaint_Mid = 1;
  public const sbyte Lvlpaint_Mid_2 = 2;
  public const sbyte Lvlpaint_Behind = 3;
  public const short End_String_Lose = 0;
  public const short End_String_Win = 1;
  public const short End_String_Draw = 2;
  public const short End_FireWork = 3;
  public const short End_line_in = 9;
  public const short End_e8_rock = 10;
  public const short End_e8_ice = 11;
  public const short End_SUB_MaFuBa = 16;
  public const short End_SUB_Destroy = 17;
  public const short End_POW_Kamex10 = 18;
  public const short End_POW_Destroy = 19;
  public const short End_POW_MaFuBa = 20;
  public const short End_GONG_Kamex10 = 21;
  public const short End_GONG_Destroy = 22;
  public const short End_GONG_MaFuBa = 23;
  public const short End_Skill_Kamex10 = 24;
  public const short End_Skill_Destroy = 25;
  public const short End_Skill_MaFuBa = 26;
  private MyVector VecEffEnd = new MyVector("EffectEnd VecEffEnd");
  public FrameImage fraImgEff;
  public byte[] nFrame = new byte[10];
  public byte[] nFrame_2 = new byte[10];
  public int typePaint;
  public int typeEffect;
  public int typeSub;
  public int range;
  public short idEndeff;
  public int fRemove;
  public int fMove;
  public int n_frame;
  public int x;
  public int y;
  public int w;
  public int h;
  public int dir;
  public int dir_nguoc;
  public int levelPaint;
  public int f;
  public int frame;
  public int fSpeed;
  public int vx;
  public int vy;
  public int x1000;
  public int y1000;
  public int vx1000;
  public int vy1000;
  public int dy_throw;
  public int vMax;
  public int toX;
  public int toY;
  public int stt;
  public int dx;
  public int dy;
  public short timeRemove;
  public long time;
  public bool isRemove;
  public bool isAddSub;
  public Char charUse;
  public Point[] listObj;
  public Point target;
  public static short[][] arrInfoEff = new short[29][]
  {
    new short[3]{ (short) 68, (short) 264, (short) 4 },
    new short[3]{ (short) 30, (short) 120, (short) 4 },
    new short[3]{ (short) 66, (short) 280, (short) 4 },
    new short[3]{ (short) 0, (short) 0, (short) 1 },
    new short[3]{ (short) 111, (short) 68, (short) 2 },
    new short[3]{ (short) 90, (short) 68, (short) 2 },
    new short[3]{ (short) 125, (short) 68, (short) 2 },
    new short[3]{ (short) 47, (short) 282, (short) 6 },
    new short[3]{ (short) 10, (short) 40, (short) 4 },
    new short[3]{ (short) 92, (short) 525, (short) 7 },
    new short[3]{ (short) 62, (short) 372, (short) 6 },
    new short[3]{ (short) 80, (short) 352, (short) 4 },
    new short[3]{ (short) 80, (short) 352, (short) 4 },
    new short[3]{ (short) 80, (short) 352, (short) 4 },
    new short[3]{ (short) 72, (short) 240, (short) 3 },
    new short[3]{ (short) 20, (short) 42, (short) 3 },
    new short[3]{ (short) 65, (short) 160, (short) 4 },
    new short[3]{ (short) 50, (short) 300, (short) 6 },
    new short[3]{ (short) 84, (short) 168, (short) 2 },
    new short[3]{ (short) 90, (short) 540, (short) 6 },
    new short[3]{ (short) 180, (short) 900, (short) 6 },
    new short[3]{ (short) 62, (short) 186, (short) 3 },
    new short[3]{ (short) 34, (short) 80, (short) 4 },
    new short[3]{ (short) 140, (short) 560, (short) 4 },
    new short[3]{ (short) 64, (short) 600, (short) 6 },
    new short[3]{ (short) 36, (short) 200, (short) 5 },
    new short[3]{ (short) 35, (short) 200, (short) 5 },
    new short[3]{ (short) 50, (short) 250, (short) 5 },
    new short[3]{ (short) 50, (short) 240, (short) 6 }
  };
  public int life;
  public int goc_Arc;
  public int va;
  public int gocT_Arc;
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
  private int rS;
  private int angleS;
  private int angleO;
  private int iAngleS;
  private int iDotS;
  private int[] xArgS;
  private int[] yArgS;
  private int[] xDotS;
  private int[] yDotS;
  public static int[][] colorStar = new int[3][]
  {
    new int[3]{ 16310304, 16298056, 16777215 },
    new int[3]{ 7045120, 12643960, 16777215 },
    new int[3]{ 2407423, 11987199, 16777215 }
  };
  private int[] colorpaint;
  private int indexColorStar;
  private int xline;
  private int yline;
  private FrameImage[] fra_skill;

  public Effect_End(
    int type,
    int typeSub,
    int x,
    int y,
    int levelPaint,
    int dir,
    short timeRemove,
    Point[] listObj)
  {
    this.f = 0;
    this.stt = 0;
    this.typeEffect = type;
    this.typeSub = typeSub;
    this.x = x;
    this.y = y;
    this.levelPaint = levelPaint;
    this.dir = dir;
    this.dir_nguoc = dir != -1 ? 0 : 2;
    this.time = mSystem.currentTimeMillis();
    this.timeRemove = timeRemove;
    this.isRemove = this.isAddSub = false;
    this.n_frame = 4;
    if (listObj != null)
    {
      this.listObj = new Point[listObj.Length];
      for (int index = 0; index < this.listObj.Length; ++index)
        this.listObj[index] = listObj[index];
    }
    this.get_Img_Skill();
    this.create_Effect();
  }

  public Effect_End(
    int type,
    int typeSub,
    int typePaint,
    Char charUse,
    Point target,
    int levelPaint,
    short timeRemove,
    short range)
  {
    this.f = 0;
    this.stt = 0;
    this.typeEffect = type;
    this.typeSub = typeSub;
    this.typePaint = typePaint;
    this.charUse = charUse;
    this.x = this.charUse.cx;
    this.y = this.charUse.cy;
    this.dir = this.charUse.cdir;
    this.dir_nguoc = this.dir != -1 ? 0 : 2;
    this.target = target;
    this.levelPaint = levelPaint;
    this.time = mSystem.currentTimeMillis();
    this.timeRemove = timeRemove;
    this.range = (int) range;
    this.isRemove = this.isAddSub = false;
    this.n_frame = 4;
    this.get_Img_Skill();
    this.create_Effect();
  }

  public Effect_End(
    int type,
    int typeSub,
    int typePaint,
    int x,
    int y,
    int levelPaint,
    int dir,
    short timeRemove,
    Point[] listObj)
  {
    this.f = 0;
    this.stt = 0;
    this.typeEffect = type;
    this.typeSub = typeSub;
    this.typePaint = typePaint;
    this.x = x;
    this.y = y;
    this.levelPaint = levelPaint;
    this.dir = dir;
    this.dir_nguoc = dir != -1 ? 0 : 2;
    this.time = mSystem.currentTimeMillis();
    this.timeRemove = timeRemove;
    this.isRemove = this.isAddSub = false;
    this.n_frame = 4;
    if (listObj != null)
    {
      this.listObj = new Point[listObj.Length];
      for (int index = 0; index < this.listObj.Length; ++index)
        this.listObj[index] = listObj[index];
    }
    this.get_Img_Skill();
    this.create_Effect();
  }

  public static Image getImage(int id)
  {
    if (id < 0)
      return (Image) null;
    string path = "/e/e_" + (object) id + ".png";
    Image image = (Image) null;
    try
    {
      image = mSystem.loadImage(path);
    }
    catch (Exception ex)
    {
    }
    return image;
  }

  public static void setSoundSkill_END(int x, int y, int typeEffect)
  {
    try
    {
      int x1 = x;
      int y1 = y;
      int id = -1;
      Res.random(3);
      if (id < 0)
        return;
      SoundMn.playSound(x1, y1, id, SoundMn.volume);
    }
    catch (Exception ex)
    {
      Res.err("ERR setSoundSkill_END: " + ex.ToString());
    }
  }

  public void create_Effect()
  {
    try
    {
      Effect_End.setSoundSkill_END(this.x, this.y, this.typeEffect);
      switch (this.typeEffect)
      {
        case 0:
        case 1:
        case 2:
          this.set_End_String(this.typeEffect);
          break;
        case 3:
          this.set_FireWork();
          break;
        case 9:
          this.set_LINE_IN();
          break;
        case 10:
        case 11:
          this.set_End_Rock();
          break;
        case 16:
        case 17:
          this.set_Sub();
          break;
        case 18:
        case 19:
        case 20:
          this.set_Pow();
          break;
        case 21:
        case 22:
        case 23:
          this.set_Gong();
          break;
        case 24:
          this.set_Skill_Kamex10();
          break;
        case 25:
          this.set_Skill_Destroy();
          break;
        case 26:
          this.set_Skill_MaFuba();
          break;
      }
    }
    catch (Exception ex)
    {
      Res.err("ERR create_Effect: " + ex.ToString());
      this.removeEff();
    }
  }

  public void update()
  {
    try
    {
      ++this.f;
      switch (this.typeEffect)
      {
        case 0:
        case 1:
        case 2:
          this.upd_End_String();
          break;
        case 3:
          this.upd_FireWork();
          break;
        case 9:
          this.upd_LINE_IN();
          break;
        case 10:
        case 11:
          this.upd_End_Rock();
          break;
        case 16:
        case 17:
          this.upd_Sub();
          break;
        case 18:
        case 19:
        case 20:
          this.upd_Pow();
          break;
        case 21:
        case 22:
        case 23:
          this.upd_Gong();
          break;
        case 24:
          this.upd_Skill_Kamex10();
          break;
        case 25:
          this.upd_Skill_Destroy();
          break;
        case 26:
          this.upd_Skill_MaFuba();
          break;
      }
    }
    catch (Exception ex)
    {
      Res.err("ERR update: " + ex.ToString());
      this.removeEff();
    }
  }

  public void paint(mGraphics g)
  {
    try
    {
      if (this.isRemove || this.f < 0)
        return;
      switch (this.typeEffect)
      {
        case 0:
        case 1:
        case 2:
          this.pnt_End_String(g);
          break;
        case 3:
          this.pnt_FireWork(g);
          break;
        case 9:
          this.pnt_LINE_IN(g);
          break;
        case 10:
        case 11:
          this.pnt_End_Rock(g);
          break;
        case 16:
          if (this.typeSub == 0)
          {
            this.pnt_Sub(g, mGraphics.BOTTOM | mGraphics.HCENTER);
            break;
          }
          this.pnt_Sub(g, mGraphics.VCENTER | mGraphics.HCENTER);
          break;
        case 17:
          this.pnt_Sub(g, mGraphics.VCENTER);
          break;
        case 18:
        case 19:
        case 20:
          this.pnt_Pow(g, mGraphics.BOTTOM | mGraphics.HCENTER);
          break;
        case 21:
        case 22:
        case 23:
          this.pnt_Gong(g, mGraphics.VCENTER | mGraphics.HCENTER);
          break;
        case 24:
          this.pnt_Skill_Kamex10(g);
          break;
        case 25:
          this.pnt_Skill_Destroy(g);
          break;
        case 26:
          this.pnt_Skill_MaFuba(g);
          break;
      }
    }
    catch (Exception ex)
    {
      Res.err(ex.ToString());
      this.removeEff();
    }
  }

  public void removeEff() => this.isRemove = true;

  public void createDanFocus(bool isRandom, Char obj)
  {
    if (isRandom)
    {
      switch (Res.random(4))
      {
        case 0:
          this.gocT_Arc = 90;
          break;
        case 1:
          this.gocT_Arc = 270;
          break;
        case 2:
          this.gocT_Arc = 180;
          break;
        case 3:
          this.gocT_Arc = 0;
          break;
      }
    }
    else
      this.gocT_Arc = obj.cdir != 1 ? 180 : 0;
    this.va = (int) (short) (256 * this.vMax);
    this.vx = 0;
    this.vy = 0;
    this.life = 0;
    this.vx1000 = this.va * Res.cos(this.gocT_Arc) >> 10;
    this.vy1000 = this.va * Res.sin(this.gocT_Arc) >> 10;
  }

  public void updateAngleXP(int fmove)
  {
    if (this.f < fmove)
      return;
    if (this.charUse == null || this.target == null || this.f >= this.fRemove)
    {
      this.f = this.fRemove;
    }
    else
    {
      int num1 = this.target.x - this.charUse.cx;
      int num2 = this.target.y - this.charUse.cy;
      ++this.life;
      if (Res.abs(num1) < 10 && Res.abs(num2) < 10 || this.life > this.fRemove)
      {
        this.f = this.fRemove;
      }
      else
      {
        int num3 = Res.angle(num1, num2);
        if (Res.abs(num3 - this.gocT_Arc) < 90 || num1 * num1 + num2 * num2 > 4096)
          this.gocT_Arc = Res.abs(num3 - this.gocT_Arc) >= 15 ? (num3 - this.gocT_Arc >= 0 && num3 - this.gocT_Arc < 180 || num3 - this.gocT_Arc < -180 ? Res.fixangle(this.gocT_Arc + 15) : Res.fixangle(this.gocT_Arc - 15)) : num3;
        if (this.f > this.fRemove * 2 / 3 && this.va < 8192)
          this.va += 3096;
        this.vx1000 = this.va * Res.cos(this.gocT_Arc) >> 10;
        this.vy1000 = this.va * Res.sin(this.gocT_Arc) >> 10;
        int num4 = num1 + this.vx1000;
        this.x += num4 >> 10;
        int num5 = num4 & 1023;
        int num6 = num2 + this.vy1000;
        this.y += num6 >> 10;
        int num7 = num6 & 1023;
      }
    }
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

  public void create_Arrow(int vMax, Point targetPoint)
  {
    this.vMax = vMax;
    int dx;
    int dy;
    if (targetPoint != null)
    {
      dx = targetPoint.x - this.x;
      dy = targetPoint.y - this.y;
      this.toX = targetPoint.x;
      this.toY = targetPoint.y;
    }
    else
    {
      dx = this.toX - this.x;
      dy = this.toY - this.y;
    }
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
    this.frame = this.setFrameAngle(Res.angle(dx, dy));
    this.fSpeed = this.frame;
    this.create_Speed(dx, dy);
  }

  public void create_Speed(int dx, int dy)
  {
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

  public void moveTo_xy(int toX, int toY, int fMove, int typeEff_End, int rangeEnd)
  {
    if (this.f < fMove)
    {
      this.frame = this.setFrameAngle(this.dir != -1 ? 0 : 180);
    }
    else
    {
      this.frame = this.fSpeed;
      if (Res.abs(this.x - toX) < Res.abs(this.vx))
      {
        this.x = toX;
        this.vx = 0;
      }
      else
        this.x += this.vx;
      if (Res.abs(this.y - toY) < Res.abs(this.vy))
      {
        this.y = toY;
        this.vy = 0;
      }
      else
        this.y += this.vy;
      if (Res.abs(this.x - toX) >= Res.abs(this.vMax) || Res.abs(this.y - toY) >= Res.abs(this.vMax) || typeEff_End < 0)
        return;
      if (this.target != null)
      {
        int x = this.target.x;
        int y = this.target.y;
        if (rangeEnd > 0)
        {
          x += Res.random_Am(0, rangeEnd);
          y += Res.random_Am(0, rangeEnd);
        }
        GameScr.addEffectEnd(typeEff_End, 0, 0, x, y, 1, 0, (short) -1, (Point[]) null);
        this.removeEff();
      }
      else
      {
        if (!this.isAddSub)
          return;
        this.isAddSub = false;
        int x = this.x;
        int y = this.y;
        if (rangeEnd > 1)
        {
          x += Res.random_Am_0(rangeEnd);
          y += Res.random_Am_0(rangeEnd);
        }
        GameScr.addEffectEnd(typeEff_End, 0, 0, x, y, 1, 0, (short) -1, (Point[]) null);
      }
    }
  }

  public void paint_Arrow(
    mGraphics g,
    FrameImage frm,
    int index,
    int x,
    int y,
    int anchor,
    bool isCountFr)
  {
    if (frm == null)
      return;
    int num1 = frm.nFrame / 3;
    if (num1 < 1)
      num1 = 1;
    int num2 = 3;
    int num3;
    if (frm.nFrame > 6)
    {
      num1 = 1;
      num3 = this.f / num2 - this.fMove <= 8 ? (this.f / num2 - this.fMove <= 4 ? 0 : 3) : 6;
    }
    else
      num3 = frm.nFrame <= 3 ? this.f % num1 : (this.f / num2 % 2 != 0 ? 3 : 0);
    int idx = num1 * (int) this.mImageArrow[index] + num3;
    if (frm.nFrame < 3)
      idx = this.f / num2 % frm.nFrame;
    if (isCountFr)
      idx = this.f / num2 % frm.nFrame;
    frm.drawFrame(idx, x, y, (int) this.mXoayArrow[index], anchor, g);
  }

  private void set_End_String(int typeEffect)
  {
    switch (typeEffect)
    {
      case 0:
        this.fraImgEff = new FrameImage(4);
        break;
      case 1:
        this.fraImgEff = new FrameImage(5);
        break;
      case 2:
        this.fraImgEff = new FrameImage(6);
        break;
    }
    this.fRemove = 100;
    this.dy_throw = GameCanvas.h / 3 + 10;
    this.vy = 10;
    this.y1000 = 0;
    this.isAddSub = false;
  }

  private void upd_End_String()
  {
    this.x = GameCanvas.hw;
    this.y = this.y1000;
    if (this.f > this.fRemove)
      this.removeEff();
    ++this.vy;
    if (this.vy > 15)
      this.vy = 15;
    if (this.y1000 + this.vy < this.dy_throw)
    {
      this.y1000 += this.vy;
    }
    else
    {
      this.y1000 = this.dy_throw;
      if (this.isAddSub)
        return;
      this.isAddSub = true;
      if (this.typeSub == -1)
        return;
      GameScr.addEffectEnd(this.typeSub, 0, 0, this.x, this.y, this.levelPaint, 0, (short) -1, (Point[]) null);
    }
  }

  private void pnt_End_String(mGraphics g)
  {
    if (this.fraImgEff == null)
      return;
    this.fraImgEff.drawFrame(this.f / 5 % this.fraImgEff.nFrame, this.x, this.y, 0, 33, g);
  }

  private void set_FireWork()
  {
    int num1 = Res.random(3, 5);
    this.fRemove = 90;
    for (int index = 0; index < num1; ++index)
    {
      Point o = new Point();
      o.x = this.x + Res.random_Am_0(4);
      o.y = this.y + Res.random_Am_0(5);
      if (this.typeSub == 0)
      {
        o.fRe = Res.random(10);
        int num2 = 1;
        if (index % 2 == 0)
          num2 = -1;
        o.x = this.x + Res.random((int) Effect_End.arrInfoEff[5][0] / 2) * num2;
        o.y = this.y - Res.random((int) Effect_End.arrInfoEff[5][1] / 2);
        o.fraImgEff = new FrameImage(7);
      }
      this.VecEffEnd.addElement((object) o);
    }
  }

  private void upd_FireWork()
  {
    for (int index = 0; index < this.VecEffEnd.size(); ++index)
    {
      Point point = (Point) this.VecEffEnd.elementAt(index);
      point.update();
      if (point.f == point.fRe)
        SoundMn.playSound(point.x, point.y, SoundMn.FIREWORK, SoundMn.volume);
      if (point.f - point.fRe > point.fraImgEff.nFrame * 3 - 1)
      {
        point.f = 0;
        if (this.typeSub == 0)
        {
          point.fRe = Res.random(10);
          int num = 1;
          if (index % 2 == 0)
            num = -1;
          point.x = this.x + Res.random((int) Effect_End.arrInfoEff[5][0] / 2) * num;
          point.y = this.y - Res.random((int) Effect_End.arrInfoEff[5][1] / 2);
        }
      }
    }
    if (this.f < this.fRemove)
      return;
    this.removeEff();
  }

  private void pnt_FireWork(mGraphics g)
  {
    for (int index = 0; index < this.VecEffEnd.size(); ++index)
    {
      Point point = (Point) this.VecEffEnd.elementAt(index);
      if (point.f - point.fRe > -1 && point.fraImgEff != null)
        point.fraImgEff.drawFrame((point.f - point.fRe) / 3 % point.fraImgEff.nFrame, point.x, point.y, 0, 3, g);
    }
  }

  private void set_Skill_Kamex10()
  {
    this.w = this.fra_skill[0].frameWidth;
    this.h = this.fra_skill[0].frameHeight;
    this.vMax = Res.abs(this.x - this.target.x);
    this.nFrame = new byte[6]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 1,
      (byte) 1
    };
    this.isAddSub = false;
    SoundMn.playSound(this.x, this.y, SoundMn.KAMEX10_1, SoundMn.volume);
  }

  private void upd_Skill_Kamex10()
  {
    ++this.fSpeed;
    this.w += 20;
    if (this.w > this.vMax)
      this.w = this.vMax;
    this.x = this.charUse.cx + 10;
    this.y = this.charUse.cy - 3;
    if (this.dir == -1)
      this.x = this.charUse.cx - this.w - 10;
    if (!this.isAddSub && GameCanvas.timeNow - this.time >= (long) this.timeRemove)
    {
      this.f = 0;
      this.nFrame = new byte[6]
      {
        (byte) 2,
        (byte) 2,
        (byte) 2,
        (byte) 3,
        (byte) 3,
        (byte) 3
      };
      this.isAddSub = true;
    }
    if (this.f <= this.nFrame.Length - 1)
      return;
    if (this.isAddSub)
      this.removeEff();
    else
      this.f = 0;
  }

  private void pnt_Skill_Kamex10(mGraphics g)
  {
    if (this.fra_skill == null)
      return;
    g.setClip(this.x, this.y - this.h / 2, this.w, this.h);
    this.Fill_Rect_Img(g, this.fra_skill[0], this.fra_skill[1], this.fra_skill[2], (int) this.nFrame[this.f], this.x, this.y, this.vMax);
    if (this.dir == -1)
    {
      if (this.fra_skill[2] != null)
        this.fra_skill[2].drawFrame((int) this.nFrame[this.f], this.x, this.y - this.fra_skill[2].frameHeight / 2, 2, 0, g);
    }
    else if (this.fra_skill[2] != null)
      this.fra_skill[2].drawFrame((int) this.nFrame[this.f], this.x + this.w - this.fra_skill[2].frameWidth, this.y - this.fra_skill[2].frameHeight / 2, 0, 0, g);
    GameCanvas.resetTransGameScr(g);
    if (this.dir == -1)
    {
      if (this.fra_skill[0] == null)
        return;
      this.fra_skill[0].drawFrame((int) this.nFrame[this.f], this.charUse.cx - this.fra_skill[0].frameWidth - 10, this.y - this.fra_skill[0].frameHeight / 2, 2, 0, g);
    }
    else
    {
      if (this.fra_skill[0] == null)
        return;
      this.fra_skill[0].drawFrame((int) this.nFrame[this.f], this.x, this.y - this.fra_skill[0].frameHeight / 2, 0, 0, g);
    }
  }

  private void set_Skill_Destroy()
  {
    this.x = this.charUse.cx + 20 * this.charUse.cdir;
    int num = 15;
    this.fMove = (int) this.timeRemove / num;
    if (this.target != null)
    {
      for (int index = 0; index < num; ++index)
      {
        Point o = new Point();
        o.fraImgEff = this.fra_skill[0];
        o.fraImgEff_2 = this.fra_skill[2];
        o.x = this.x;
        o.y = this.y;
        if (this.target != null)
        {
          o.toX = this.target.x;
          o.toY = this.target.y;
          if (this.range > 0)
          {
            o.toX += Res.random_Am(0, this.range);
            o.toY += Res.random_Am(0, this.range);
          }
        }
        this.vMax = Res.random(9, 12);
        if (index == num - 1)
        {
          o.fraImgEff = this.fra_skill[1];
          o.fraImgEff_2 = this.fra_skill[3];
          o.toX = this.target.x;
          o.toY = this.target.y;
          this.vMax = 9;
        }
        o.isPaint = false;
        o.isChange = false;
        o.isRemove = false;
        o.create_Arrow(this.vMax);
        this.VecEffEnd.addElement((object) o);
      }
    }
    else
      this.removeEff();
  }

  private void upd_Skill_Destroy()
  {
    int num = 0;
    for (int index = 0; index < this.VecEffEnd.size(); ++index)
    {
      Point point = (Point) this.VecEffEnd.elementAt(index);
      if (!point.isPaint && GameCanvas.timeNow - this.time >= (long) (index * this.fMove))
      {
        point.isPaint = true;
        GameScr.addEffectEnd(17, 0, this.typePaint, this.charUse.cx, this.charUse.cy - 3, 2, this.dir_nguoc, (short) -1, (Point[]) null);
        if (index == this.VecEffEnd.size() - 1)
          SoundMn.playSound(point.x, point.y, SoundMn.DESTROY_1, SoundMn.volume);
        else
          SoundMn.playSound(point.x, point.y, SoundMn.DESTROY_0, SoundMn.volume);
      }
      if (point.isPaint && !point.isRemove)
      {
        ++point.f;
        if (!point.isChange)
        {
          if (point.f < 10 && index == this.VecEffEnd.size() - 1 && this.charUse != null && !TileMap.tileTypeAt(this.charUse.cx - (this.charUse.chw + 1) * this.charUse.cdir, this.charUse.cy, this.charUse.cdir != 1 ? 4 : 8))
            this.charUse.cx -= this.charUse.cdir;
          point.moveTo_xy(point.toX, point.toY);
          if (point.x == point.toX)
          {
            point.isChange = true;
            point.f = 0;
          }
        }
        if (point.isChange && point.f >= this.n_frame * point.fraImgEff_2.nFrame)
          point.isRemove = true;
      }
      if (point.isRemove)
        ++num;
    }
    if (num != this.VecEffEnd.size())
      return;
    this.removeEff();
  }

  private void pnt_Skill_Destroy(mGraphics g)
  {
    for (int index = 0; index < this.VecEffEnd.size(); ++index)
    {
      Point point = (Point) this.VecEffEnd.elementAt(index);
      if (point.isPaint && !point.isRemove)
      {
        if (!point.isChange)
          point.paint_Arrow(g, point.fraImgEff, mGraphics.VCENTER | mGraphics.HCENTER, false);
        if (point.isChange)
          point.fraImgEff_2.drawFrame(point.f / this.n_frame % point.fraImgEff_2.nFrame, point.x, point.y, this.dir_nguoc, mGraphics.VCENTER | mGraphics.HCENTER, g);
      }
    }
  }

  private void set_Skill_MaFuba()
  {
    this.nFrame = new byte[9]
    {
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 1,
      (byte) 1,
      (byte) 2,
      (byte) 2,
      (byte) 2
    };
    this.isAddSub = false;
    this.fMove = 10;
    this.x1000 = this.x;
    this.y1000 = this.y + 12;
    this.dy = 25;
    this.dy_throw = 19;
    if (this.typeSub == 1)
      this.dy_throw = 21;
    else if (this.typeSub == 2)
      this.dy_throw = 31;
    this.h = this.fra_skill[1].frameHeight + 50 - this.dy_throw;
    this.vy = 1;
    this.vy1000 = 1;
    this.y = this.y1000 - this.h;
    this.rS = 90;
    this.vMax = 1;
    this.angleS = this.angleO = 25;
    this.iDotS = 1;
    if (this.listObj != null && this.listObj.Length > 0)
      this.iDotS = this.listObj.Length;
    this.iAngleS = 360 / this.iDotS;
    this.xArgS = new int[this.iDotS];
    this.yArgS = new int[this.iDotS];
    this.xDotS = new int[this.iDotS];
    this.yDotS = new int[this.iDotS];
    GameScr.addEffectEnd(16, 0, this.typePaint, this.x1000, this.y1000, 1, 0, (short) -1, (Point[]) null);
    SoundMn.playSound(this.x, this.y, SoundMn.MAFUBA_0, SoundMn.volume);
  }

  private void changeAngleStar()
  {
    if (this.vMax < 40)
      this.vMax += 2;
    this.angleS = this.angleO;
    this.angleS -= this.vMax;
    if (this.angleS >= 360)
      this.angleS -= 360;
    if (this.angleS < 0)
      this.angleS = 360 + this.angleS;
    this.angleO = this.angleS;
  }

  private void setDotStar()
  {
    for (int index = 0; index < this.yArgS.Length; ++index)
    {
      if (this.angleS >= 360)
        this.angleS -= 360;
      if (this.angleS < 0)
        this.angleS = 360 + this.angleS;
      this.yArgS[index] = Res.abs(this.rS * Res.sin(this.angleS) / 1024);
      this.xArgS[index] = Res.abs(this.rS * Res.cos(this.angleS) / 1024);
      if (this.angleS < 90)
      {
        this.xDotS[index] = this.x + this.xArgS[index];
        this.yDotS[index] = this.y - this.yArgS[index];
      }
      else if (this.angleS >= 90 && this.angleS < 180)
      {
        this.xDotS[index] = this.x - this.xArgS[index];
        this.yDotS[index] = this.y - this.yArgS[index];
      }
      else if (this.angleS >= 180 && this.angleS < 270)
      {
        this.xDotS[index] = this.x - this.xArgS[index];
        this.yDotS[index] = this.y + this.yArgS[index];
      }
      else
      {
        this.xDotS[index] = this.x + this.xArgS[index];
        this.yDotS[index] = this.y + this.yArgS[index];
      }
      this.angleS -= this.iAngleS;
    }
  }

  private void upd_Skill_MaFuba()
  {
    if (this.stt == 0)
    {
      if (this.f == 3)
        SoundMn.playSound(this.x, this.y, SoundMn.MAFUBA_1, SoundMn.volume);
      ++this.frame;
      if (this.frame > this.nFrame.Length - 1)
        this.frame = this.nFrame.Length - 1;
      if (this.f == this.fMove + 4)
        GameScr.addEffectEnd(16, 1, this.typePaint, this.x, this.y, 3, 0, (short) 2945, (Point[]) null);
      if (this.f <= this.fMove + 4)
        return;
      --this.rS;
      if (this.rS < 0)
      {
        this.rS = 0;
        this.f = 0;
        this.fSpeed = 0;
        this.nFrame_2 = new byte[22]
        {
          (byte) 1,
          (byte) 1,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 0,
          (byte) 0,
          (byte) 0,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 0,
          (byte) 0,
          (byte) 1,
          (byte) 1,
          (byte) 1,
          (byte) 2
        };
        this.hideListObj_Mafuba(true);
        this.stt = 1;
      }
      else
      {
        this.changeAngleStar();
        this.setDotStar();
        this.updListObj_Mafuba(true);
      }
    }
    else if (this.stt == 1)
    {
      ++this.fSpeed;
      if (this.fSpeed <= this.nFrame_2.Length - 1)
        return;
      this.fSpeed = this.nFrame_2.Length - 1;
      if (GameCanvas.gameTick % 2 == 0)
        ++this.vy1000;
      this.vy += this.vy1000;
      if (this.vy < this.h - this.fra_skill[0].frameHeight - this.dy + this.dy_throw)
        return;
      this.vy = this.h - this.fra_skill[0].frameHeight - this.dy + this.dy_throw;
      this.f = 0;
      this.fSpeed = 0;
      this.stt = 2;
      this.nFrame_2 = new byte[11]
      {
        (byte) 3,
        (byte) 3,
        (byte) 3,
        (byte) 3,
        (byte) 3,
        (byte) 4,
        (byte) 4,
        (byte) 4,
        (byte) 5,
        (byte) 5,
        (byte) 5
      };
    }
    else if (this.stt == 2)
    {
      ++this.fSpeed;
      if (this.fSpeed <= this.nFrame_2.Length - 1)
        return;
      this.stt = 3;
      this.frame = 0;
      this.nFrame = new byte[17]
      {
        (byte) 2,
        (byte) 2,
        (byte) 1,
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 3,
        (byte) 3,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 4,
        (byte) 4,
        (byte) 0,
        (byte) 0
      };
    }
    else if (this.stt == 3)
    {
      ++this.frame;
      if (this.frame == 3)
        SoundMn.playSound(this.x, this.y, SoundMn.MAFUBA_1, SoundMn.volume);
      if (this.frame <= this.nFrame.Length - 1)
        return;
      this.frame = 0;
      this.stt = 4;
      this.nFrame = new byte[51]
      {
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 3,
        (byte) 3,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 4,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 3,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 4
      };
    }
    else
    {
      ++this.frame;
      if (this.frame > this.nFrame.Length - 1)
        this.frame = 0;
      if (GameCanvas.timeNow - this.time < (long) this.timeRemove)
        return;
      GameScr.addEffectEnd(16, 0, this.typePaint, this.x1000, this.y1000, 1, 0, (short) -1, (Point[]) null);
      this.updListObj_Mafuba(false);
      this.removeEff();
    }
  }

  private void pnt_Skill_MaFuba(mGraphics g)
  {
    if (this.fra_skill == null)
      return;
    if (this.nFrame != null)
      this.fra_skill[0].drawFrame((int) this.nFrame[this.frame], this.x1000, this.y1000, 0, mGraphics.BOTTOM | mGraphics.HCENTER, g);
    if (this.stt != 1 && this.stt != 2)
      return;
    int anchor = mGraphics.BOTTOM | mGraphics.HCENTER;
    int num = this.dy;
    if (this.nFrame_2[this.fSpeed] == (byte) 0 || this.nFrame_2[this.fSpeed] == (byte) 1)
    {
      anchor = mGraphics.VCENTER | mGraphics.HCENTER;
      num = 0;
    }
    this.fra_skill[1].drawFrame((int) this.nFrame_2[this.fSpeed], this.x, this.y + num + this.vy, 0, anchor, g);
  }

  private void Fill_Rect_Img(
    mGraphics g,
    FrameImage head,
    FrameImage body,
    FrameImage foot,
    int frame,
    int x,
    int y,
    int w)
  {
    int num1 = w;
    bool flag = false;
    if (head != null && foot != null)
    {
      flag = true;
      num1 = w - (head.frameWidth + foot.frameWidth);
    }
    if (num1 > 0)
    {
      int num2 = num1 / body.frameWidth;
      if (num1 % body.frameWidth > 0)
        ++num2;
      for (int index = 0; index < num2; ++index)
      {
        int x1 = index != num2 - 1 ? (!flag ? x + index * body.frameWidth : x + index * body.frameWidth + head.frameWidth) : (!flag ? x + w - body.frameWidth : x + w - body.frameWidth - foot.frameWidth);
        body.drawFrame(frame, x1, y - body.frameHeight / 2, 0, 0, g);
      }
    }
    head?.drawFrame(frame, x, y - head.frameHeight / 2, 0, 0, g);
    foot?.drawFrame(frame, x + w - foot.frameWidth, y - head.frameHeight / 2, 0, 0, g);
  }

  private void set_LINE_IN()
  {
    this.indexColorStar = this.typeSub;
    this.x1000 = this.x * 1000;
    this.y1000 = this.y * 1000;
    this.fRemove = Res.random(4, 6);
    this.vMax = 5;
    this.xline = 10;
    this.yline = 20;
    this.create_Star_Line_In(this.vMax, this.xline, this.yline, 0);
  }

  private void upd_LINE_IN()
  {
    for (int index = 0; index < this.VecEffEnd.size(); ++index)
    {
      Line o = (Line) this.VecEffEnd.elementAt(index);
      o.update();
      if (this.f >= this.fRemove)
      {
        this.VecEffEnd.removeElement((object) o);
        --index;
      }
    }
    if (this.f < this.fRemove)
      return;
    if (GameCanvas.timeNow - this.time >= (long) this.timeRemove)
    {
      this.VecEffEnd.removeAllElements();
      this.removeEff();
    }
    else
    {
      this.fRemove = Res.random(4, 6);
      this.f = 0;
      this.create_Star_Line_In(this.vMax, this.xline, this.yline, 0);
    }
  }

  private void create_Star_Line_In(int vline, int minline, int maxline, int numpoint)
  {
    if (this.f == -1)
      this.VecEffEnd.removeAllElements();
    int length = 4;
    this.colorpaint = new int[length];
    if (maxline <= minline)
      maxline = minline + 1;
    for (int index = 0; index < length; ++index)
      this.colorpaint[index] = Res.random(2) != 0 ? Effect_End.colorStar[this.indexColorStar][2] : Effect_End.colorStar[this.indexColorStar][Res.random(3)];
    for (int index = 0; index < length; ++index)
    {
      Line o1 = new Line();
      int a1 = 5 + 180 / length * index;
      int b = 180 / length + 180 / length * index - 5;
      if (b <= a1)
        b = a1 + 1;
      int num1 = Res.random(minline, maxline);
      int num2 = Res.random(vline, vline + 3);
      int num3 = Res.random(a1, b);
      int num4 = Res.random(13, 23);
      bool is2Line = Res.random(4) == 0;
      int a2 = Res.fixangle(num3 % 360);
      o1.setLine(this.x1000 - Res.sin(a2) * (num1 + num4), this.y1000 - Res.cos(a2) * (num1 + num4), this.x1000 - Res.sin(a2) * num4, this.y1000 - Res.cos(a2) * num4, Res.sin(a2) * num2, Res.cos(a2) * num2, is2Line);
      if (numpoint > 0)
        o1.type = Res.random(numpoint);
      this.VecEffEnd.addElement((object) o1);
      Line o2 = new Line();
      int a3 = Res.fixangle((a2 + (180 + Res.random_Am(2, 5))) % 360);
      o2.setLine(this.x1000 - Res.sin(a3) * (num1 + num4), this.y1000 - Res.cos(a3) * (num1 + num4), this.x1000 - Res.sin(a3) * num4, this.y1000 - Res.cos(a3) * num4, Res.sin(a3) * num2, Res.cos(a3) * num2, is2Line);
      if (numpoint > 0)
        o2.type = Res.random(numpoint);
      this.VecEffEnd.addElement((object) o2);
    }
  }

  private void pnt_LINE_IN(mGraphics g)
  {
    for (int index = 0; index < this.VecEffEnd.size(); ++index)
    {
      Line line = (Line) this.VecEffEnd.elementAt(index);
      if (line != null)
      {
        int rgb = 0;
        if (index / 2 < this.colorpaint.Length)
          rgb = this.colorpaint[index / 2];
        g.setColor(rgb);
        g.drawLine(line.x0 / 1000, line.y0 / 1000, line.x1 / 1000, line.y1 / 1000);
        if (line.is2Line)
          g.drawLine(line.x0 / 1000 + 1, line.y0 / 1000, line.x1 / 1000 + 1, line.y1 / 1000);
      }
    }
  }

  private void set_End_Rock()
  {
    this.fraImgEff = new FrameImage(8);
    this.fRemove = Res.random(23, 27);
    int num = Res.random(1, 3);
    this.toY = this.y - 40;
    for (int index = 0; index < num; ++index)
      this.VecEffEnd.addElement((object) new Point()
      {
        x = (this.x + Res.random_Am(0, 20)),
        y = (this.y + Res.random_Am_0(7)),
        frame = (this.typeEffect != 10 ? (this.typeEffect != 11 ? Res.random(0, this.fraImgEff.nFrame) : Res.random(2, this.fraImgEff.nFrame)) : Res.random(0, this.fraImgEff.nFrame - 2)),
        dis = Res.random(2),
        vy = -Res.random(1, 4)
      });
  }

  private void upd_End_Rock()
  {
    for (int index = 0; index < this.VecEffEnd.size(); ++index)
    {
      Point point = (Point) this.VecEffEnd.elementAt(index);
      point.update();
      if (point.y < this.toY)
      {
        this.VecEffEnd.removeElementAt(index);
        --index;
      }
    }
    if (this.f < this.fRemove)
      return;
    this.removeEff();
  }

  private void pnt_End_Rock(mGraphics g)
  {
    for (int index = 0; index < this.VecEffEnd.size(); ++index)
    {
      Point point = (Point) this.VecEffEnd.elementAt(index);
      if (this.fraImgEff != null)
        this.fraImgEff.drawFrame(point.frame, point.x, point.y, 0, mGraphics.VCENTER | mGraphics.HCENTER, g);
    }
  }

  private void updListObj_Mafuba(bool ismafuba)
  {
    if (this.listObj == null)
      return;
    for (int index = 0; index < this.listObj.Length; ++index)
    {
      if (this.listObj[index] != null)
      {
        if (this.listObj[index].type == (sbyte) 0)
        {
          Mob mobInMap = GameScr.findMobInMap(this.listObj[index].id);
          if (mobInMap != null)
          {
            mobInMap.isMafuba = ismafuba;
            mobInMap.isHide = false;
            mobInMap.xMFB = this.xDotS[index];
            mobInMap.yMFB = this.yDotS[index];
          }
        }
        else
        {
          Char @char = Char.myCharz().charID != this.listObj[index].id ? GameScr.findCharInMap(this.listObj[index].id) : Char.myCharz();
          if (@char != null)
          {
            @char.isMafuba = ismafuba;
            @char.isHide = false;
            @char.xMFB = this.xDotS[index];
            @char.yMFB = this.yDotS[index];
          }
        }
      }
    }
  }

  private void hideListObj_Mafuba(bool ishide)
  {
    if (this.listObj == null)
      return;
    for (int index = 0; index < this.listObj.Length; ++index)
    {
      if (this.listObj[index] != null)
      {
        if (this.listObj[index].type == (sbyte) 0)
        {
          Mob mobInMap = GameScr.findMobInMap(this.listObj[index].id);
          if (mobInMap != null)
            mobInMap.isHide = ishide;
        }
        else
        {
          Char @char = Char.myCharz().charID != this.listObj[index].id ? GameScr.findCharInMap(this.listObj[index].id) : Char.myCharz();
          if (@char != null)
            @char.isHide = ishide;
        }
      }
    }
  }

  private void get_Img_Skill()
  {
    int num1 = 0;
    int[] numArray1 = (int[]) null;
    int[] numArray2 = (int[]) null;
    switch (this.typeEffect)
    {
      case 16:
        num1 = 26;
        if (this.typeSub == 0)
        {
          numArray1 = new int[1]{ 7 };
          numArray2 = new int[1]{ 28 };
        }
        if (this.typeSub == 1)
        {
          numArray1 = new int[1]{ 2 };
          numArray2 = new int[1]{ 23 };
          break;
        }
        break;
      case 17:
        num1 = 25;
        numArray1 = new int[1]{ 2 };
        numArray2 = new int[1]{ 16 };
        break;
      case 18:
        num1 = 24;
        numArray1 = new int[1];
        numArray2 = new int[1]{ 9 };
        break;
      case 19:
        num1 = 25;
        numArray1 = new int[1];
        numArray2 = new int[1]{ 14 };
        break;
      case 20:
        num1 = 26;
        numArray1 = new int[1];
        numArray2 = new int[1]{ 21 };
        break;
      case 21:
        num1 = 24;
        numArray1 = new int[1]{ 1 };
        numArray2 = new int[1]{ 10 };
        break;
      case 22:
        num1 = 25;
        numArray1 = new int[1]{ 1 };
        numArray2 = new int[1]{ 15 };
        break;
      case 23:
        num1 = 26;
        numArray1 = new int[1]{ 1 };
        numArray2 = new int[1]{ 22 };
        break;
      case 24:
        num1 = 24;
        numArray1 = new int[3]{ 2, 3, 4 };
        numArray2 = new int[3]{ 11, 12, 13 };
        break;
      case 25:
        num1 = 25;
        numArray1 = new int[4]{ 3, 4, 5, 6 };
        numArray2 = new int[4]{ 17, 18, 19, 20 };
        break;
      case 26:
        num1 = 26;
        int num2 = 0;
        int num3 = 0;
        if (this.typeSub == 0)
        {
          num2 = 4;
          num3 = 25;
        }
        else if (this.typeSub == 1)
        {
          num2 = 5;
          num3 = 26;
        }
        else if (this.typeSub == 2)
        {
          num2 = 6;
          num3 = 27;
        }
        numArray1 = new int[2]{ num2, 3 };
        numArray2 = new int[2]{ num3, 24 };
        break;
    }
    if (numArray1 == null || numArray2 == null)
      return;
    this.fra_skill = new FrameImage[numArray1.Length];
    for (int index = 0; index < numArray1.Length; ++index)
    {
      FrameImage frameImage = mSystem.getFraImage("Skills_" + (object) num1 + "_" + (object) this.typePaint + "_" + (object) numArray1[index]) ?? new FrameImage(numArray2[index]);
      if (frameImage != null)
        this.fra_skill[index] = frameImage;
    }
  }

  private void set_Gong()
  {
    if (this.typeEffect == 21)
    {
      if (this.charUse != null)
      {
        this.x = this.charUse.cx - 3 * this.charUse.cdir;
        this.y = this.charUse.cy;
      }
      SoundMn.playSound(this.x, this.y, SoundMn.KAMEX10_0, SoundMn.volume);
    }
    else if (this.typeEffect == 22)
    {
      this.x = this.charUse.cx + 20 * this.charUse.cdir;
      this.y = this.charUse.cy - 4;
      SoundMn.playSound(this.x, this.y, SoundMn.DESTROY_2, SoundMn.volume);
    }
    else if (this.typeEffect == 23)
    {
      this.x = this.charUse.cx;
      this.y = this.charUse.cy - 50;
      SoundMn.playSound(this.x, this.y, SoundMn.MAFUBA_2, SoundMn.volume);
    }
    else
    {
      this.x = this.charUse.cx;
      this.y = this.charUse.cy;
    }
  }

  private void upd_Gong()
  {
    if (this.timeRemove > (short) 0)
    {
      if (GameCanvas.timeNow - this.time < (long) this.timeRemove)
        return;
      this.removeEff();
    }
    else
    {
      if (this.f < this.fra_skill[0].nFrame * this.n_frame)
        return;
      this.removeEff();
    }
  }

  private void pnt_Gong(mGraphics g, int anchor)
  {
    if (this.fra_skill[0] == null)
      return;
    this.fra_skill[0].drawFrame(this.f / this.n_frame % this.fra_skill[0].nFrame, this.x, this.y, this.dir_nguoc, anchor, g);
  }

  private void set_Pow()
  {
    this.nFrame = (byte[]) null;
    this.n_frame = 3;
    if (this.typeEffect != 18)
      return;
    if (this.typeSub == 0)
      this.nFrame = new byte[9]
      {
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 1,
        (byte) 1,
        (byte) 2,
        (byte) 2,
        (byte) 2
      };
    else
      this.nFrame = new byte[12]
      {
        (byte) 3,
        (byte) 3,
        (byte) 3,
        (byte) 4,
        (byte) 4,
        (byte) 4,
        (byte) 5,
        (byte) 5,
        (byte) 5,
        (byte) 6,
        (byte) 6,
        (byte) 6
      };
  }

  private void upd_Pow()
  {
    if (this.charUse != null)
    {
      this.x = this.charUse.cx;
      this.y = this.charUse.cy + 13;
    }
    if (this.timeRemove > (short) 0)
    {
      if (GameCanvas.timeNow - this.time < (long) this.timeRemove)
        return;
      this.removeEff();
    }
    else if (this.nFrame != null)
    {
      if (this.f <= this.nFrame.Length)
        return;
      this.removeEff();
    }
    else
    {
      if (this.f < this.fra_skill[0].nFrame * this.n_frame)
        return;
      this.removeEff();
    }
  }

  private void pnt_Pow(mGraphics g, int anchor)
  {
    if (this.fra_skill[0] == null)
      return;
    if (this.nFrame != null)
      this.fra_skill[0].drawFrame((int) this.nFrame[this.f % this.nFrame.Length], this.x, this.y, this.dir_nguoc, anchor, g);
    else
      this.fra_skill[0].drawFrame(this.f / this.n_frame % this.fra_skill[0].nFrame, this.x, this.y, this.dir_nguoc, anchor, g);
  }

  private void set_Sub()
  {
    if (this.typeEffect != 17)
      return;
    this.x += this.dir != 0 ? -this.fra_skill[0].frameWidth : 0;
  }

  private void upd_Sub()
  {
    if (this.timeRemove > (short) 0)
    {
      if (GameCanvas.timeNow - this.time < (long) this.timeRemove)
        return;
      this.removeEff();
    }
    else
    {
      if (this.f < this.fra_skill[0].nFrame * this.n_frame)
        return;
      this.removeEff();
    }
  }

  private void pnt_Sub(mGraphics g, int anchor) => this.fra_skill[0].drawFrame(this.f / this.n_frame % this.fra_skill[0].nFrame, this.x, this.y, this.dir, anchor, g);

  private void set_()
  {
  }

  private void upd_()
  {
  }

  private void pnt_(mGraphics g)
  {
  }
}
