﻿// Decompiled with JetBrains decompiler
// Type: Assets.src.g.BigBoss
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

using System;

namespace Assets.src.g
{
  public class BigBoss : Mob, IMapObject
  {
    public static Image shadowBig = GameCanvas.loadImage("/mainImage/shadowBig.png");
    public static EffectData data;
    public int xTo;
    public int yTo;
    public bool haftBody;
    public bool change;
    public new int xSd;
    public new int ySd;
    private bool isOutMap;
    private int wCount;
    public new bool isShadown = true;
    private int tick;
    private int frame;
    private bool wy;
    private int wt;
    private int fy;
    private int ty;
    public new int typeSuperEff;
    private Char focus;
    private bool flyUp;
    private bool flyDown;
    private int dy;
    public bool changePos;
    private int tShock;
    public new bool isBusyAttackSomeOne = true;
    private int tA;
    private Char[] charAttack;
    private int[] dameHP;
    private sbyte type;
    public new int[] stand = new int[12]
    {
      0,
      0,
      0,
      0,
      0,
      0,
      0,
      0,
      1,
      1,
      1,
      1
    };
    public int[] stand_1 = new int[17]
    {
      37,
      37,
      37,
      38,
      38,
      38,
      39,
      39,
      40,
      40,
      40,
      39,
      39,
      39,
      38,
      38,
      38
    };
    public new int[] move = new int[15]
    {
      1,
      1,
      1,
      1,
      2,
      2,
      2,
      2,
      3,
      3,
      3,
      3,
      2,
      2,
      2
    };
    public new int[] moveFast = new int[7]
    {
      1,
      1,
      2,
      2,
      3,
      3,
      2
    };
    public new int[] attack1 = new int[12]
    {
      0,
      0,
      34,
      34,
      35,
      35,
      36,
      36,
      2,
      2,
      1,
      1
    };
    public new int[] attack2 = new int[23]
    {
      0,
      0,
      0,
      4,
      4,
      6,
      6,
      9,
      9,
      10,
      10,
      13,
      13,
      15,
      15,
      17,
      17,
      19,
      19,
      21,
      21,
      23,
      23
    };
    public int[] attack3 = new int[24]
    {
      0,
      0,
      1,
      1,
      4,
      4,
      6,
      6,
      8,
      8,
      25,
      25,
      26,
      26,
      28,
      28,
      30,
      30,
      32,
      32,
      2,
      2,
      1,
      1
    };
    public int[] attack2_1 = new int[20]
    {
      37,
      37,
      5,
      5,
      7,
      7,
      11,
      11,
      14,
      14,
      16,
      16,
      18,
      18,
      20,
      20,
      22,
      22,
      24,
      24
    };
    public int[] attack3_1 = new int[21]
    {
      37,
      37,
      37,
      38,
      38,
      5,
      5,
      7,
      7,
      11,
      11,
      27,
      27,
      29,
      29,
      31,
      31,
      33,
      33,
      38,
      38
    };
    public int[] fly = new int[8]
    {
      8,
      8,
      9,
      9,
      10,
      10,
      12,
      12
    };
    public int[] hitground = new int[24]
    {
      0,
      0,
      1,
      1,
      4,
      4,
      6,
      6,
      8,
      8,
      25,
      25,
      26,
      26,
      28,
      28,
      30,
      30,
      32,
      32,
      2,
      2,
      1,
      1
    };
    private bool shock;
    private sbyte[] cou = new sbyte[2]
    {
      (sbyte) -1,
      (sbyte) 1
    };
    public new Char injureBy;
    public new bool injureThenDie;
    public new Mob mobToAttack;
    public new int forceWait;
    public new bool blindEff;
    public new bool sleepEff;

    public BigBoss(int id, short px, short py, int templateID, int hp, int maxhp, int s)
    {
      this.xFirst = this.x = (int) px + 20;
      this.yFirst = this.y = (int) py;
      this.mobId = id;
      this.hp = hp;
      this.maxHp = maxhp;
      this.templateId = templateID;
      this.w_hp_bar = 100;
      this.h_hp_bar = (byte) 6;
      this.len = this.w_hp_bar;
      this.updateHp_bar();
      if (s == 0)
        this.getDataB();
      if (s == 1)
        this.getDataB2();
      if (s == 2)
      {
        this.getDataB2();
        this.haftBody = true;
      }
      this.status = 2;
    }

    public void getDataB2()
    {
      BigBoss.data = (EffectData) null;
      BigBoss.data = new EffectData();
      string patch = "/x" + (object) mGraphics.zoomLevel + "/effectdata/" + (object) 100 + "/data";
      try
      {
        BigBoss.data.readData2(patch);
        BigBoss.data.img = GameCanvas.loadImage("/effectdata/" + (object) 100 + "/img.png");
      }
      catch (Exception ex)
      {
        Service.gI().requestModTemplate(this.templateId);
      }
      this.status = 2;
      this.w = BigBoss.data.width;
      this.h = BigBoss.data.height;
    }

    public void getDataB()
    {
      BigBoss.data = (EffectData) null;
      BigBoss.data = new EffectData();
      string patch = "/x" + (object) mGraphics.zoomLevel + "/effectdata/" + (object) 101 + "/data";
      try
      {
        BigBoss.data.readData2(patch);
        BigBoss.data.img = GameCanvas.loadImage("/effectdata/" + (object) 101 + "/img.png");
        Res.outz("read xong data");
      }
      catch (Exception ex)
      {
        Service.gI().requestModTemplate(this.templateId);
      }
      this.w = BigBoss.data.width;
      this.h = BigBoss.data.height;
    }

    public override void setBody(short id)
    {
      this.changBody = true;
      this.smallBody = id;
    }

    public override void clearBody() => this.changBody = false;

    public new static bool isExistNewMob(string id)
    {
      for (int index = 0; index < Mob.newMob.size(); ++index)
      {
        if (((string) Mob.newMob.elementAt(index)).Equals(id))
          return true;
      }
      return false;
    }

    public new void checkFrameTick(int[] array)
    {
      ++this.tick;
      if (this.tick > array.Length - 1)
        this.tick = 0;
      this.frame = array[this.tick];
    }

    private void updateShadown()
    {
      int size = (int) TileMap.size;
      this.xSd = this.x;
      this.wCount = 0;
      if (this.ySd <= 0 || TileMap.tileTypeAt(this.xSd, this.ySd, 2))
        return;
      if (TileMap.tileTypeAt(this.xSd / size, this.ySd / size) == 0)
        this.isOutMap = true;
      else if (TileMap.tileTypeAt(this.xSd / size, this.ySd / size) != 0 && !TileMap.tileTypeAt(this.xSd, this.ySd, 2))
      {
        this.xSd = this.x;
        this.ySd = this.y;
        this.isOutMap = false;
      }
      while (this.isOutMap && this.wCount < 10)
      {
        ++this.wCount;
        this.ySd += 24;
        if (TileMap.tileTypeAt(this.xSd, this.ySd, 2))
        {
          if (this.ySd % 24 == 0)
            break;
          this.ySd -= this.ySd % 24;
          break;
        }
      }
    }

    private void paintShadow(mGraphics g)
    {
      g.drawImage(BigBoss.shadowBig, this.xSd, this.yFirst, 3);
      g.setClip(GameScr.cmx, GameScr.cmy - GameCanvas.transY, GameScr.gW, GameScr.gH + 2 * GameCanvas.transY);
    }

    public new void updateSuperEff()
    {
    }

    public override void update()
    {
      if (!this.isUpdate())
        return;
      this.updateShadown();
      switch (this.status)
      {
        case 0:
        case 1:
          this.updateDead();
          break;
        case 2:
          this.updateMobStandWait();
          break;
        case 3:
          this.updateMobAttack();
          break;
        case 4:
          this.timeStatus = 0;
          this.updateMobFly();
          break;
        case 5:
          this.timeStatus = 0;
          this.updateMobWalk();
          break;
        case 6:
          this.timeStatus = 0;
          ++this.p1;
          this.y += this.p1;
          if (this.y < this.yFirst)
            break;
          this.y = this.yFirst;
          this.p1 = 0;
          this.status = 5;
          break;
        case 7:
          this.updateInjure();
          break;
      }
    }

    private void updateDead()
    {
      this.checkFrameTick(!this.haftBody ? this.stand : this.stand_1);
      if (GameCanvas.gameTick % 5 == 0)
        ServerEffect.addServerEffect(167, Res.random(this.x - this.getW() / 2, this.x + this.getW() / 2), Res.random(this.getY() + this.getH() / 2, this.getY() + this.getH()), 1);
      if (this.x == this.xFirst && this.y == this.yFirst)
        return;
      this.x += (this.xFirst - this.x) / 4;
      this.y += (this.yFirst - this.y) / 4;
    }

    private void updateMobFly()
    {
      if (this.flyUp)
      {
        ++this.dy;
        this.y -= this.dy;
        this.checkFrameTick(this.fly);
        if (this.y <= -500)
        {
          this.flyUp = false;
          this.flyDown = true;
          this.dy = 0;
        }
      }
      if (!this.flyDown)
        return;
      this.x = this.xTo;
      this.dy += 2;
      this.y += this.dy;
      this.checkFrameTick(this.hitground);
      if (this.y <= this.yFirst)
        return;
      this.y = this.yFirst;
      this.flyDown = false;
      this.dy = 0;
      this.status = 2;
      GameScr.shock_scr = 10;
      this.shock = true;
    }

    public new void setInjure()
    {
    }

    public new void setAttack(Char cFocus)
    {
      this.isBusyAttackSomeOne = true;
      this.mobToAttack = (Mob) null;
      this.cFocus = cFocus;
      this.p1 = 0;
      this.p2 = 0;
      this.status = 3;
      this.tick = 0;
      this.dir = cFocus.cx <= this.x ? -1 : 1;
      int cx = cFocus.cx;
      int cy = cFocus.cy;
      if (Res.abs(cx - this.x) < this.w * 2 && Res.abs(cy - this.y) < this.h * 2)
      {
        if (this.x < cx)
          this.x = cx - this.w;
        else
          this.x = cx + this.w;
        this.p3 = 0;
      }
      else
        this.p3 = 1;
    }

    private bool isSpecial() => this.templateId >= 58 && this.templateId <= 65 || this.templateId == 67 || this.templateId == 68;

    private void updateInjure()
    {
    }

    private void updateMobStandWait()
    {
      this.checkFrameTick(!this.haftBody ? this.stand : this.stand_1);
      if (this.x == this.xFirst && this.y == this.yFirst)
        return;
      this.x += (this.xFirst - this.x) / 4;
      this.y += (this.yFirst - this.y) / 4;
    }

    public void setFly()
    {
      this.status = 4;
      this.flyUp = true;
    }

    public void setAttack(Char[] cAttack, int[] dame, sbyte type)
    {
      this.charAttack = cAttack;
      this.dameHP = dame;
      this.type = type;
      this.tick = 0;
      if (type < (sbyte) 3)
        this.status = 3;
      if (type == (sbyte) 3)
      {
        this.flyUp = true;
        this.status = 4;
      }
      if (type == (sbyte) 4)
      {
        for (int index = 0; index < this.charAttack.Length; ++index)
          this.charAttack[index].doInjure(this.dameHP[index], 0, false, false);
      }
      if (type != (sbyte) 7)
        return;
      this.status = 3;
    }

    public new void updateMobAttack()
    {
      if (this.type == (sbyte) 7)
      {
        if (this.tick > 8)
          this.tick = 8;
        this.checkFrameTick(this.attack1);
        if (GameCanvas.gameTick % 4 == 0)
          ServerEffect.addServerEffect(70, this.x + (this.dir != 1 ? -15 : 15), this.y - 40, 1);
      }
      if (this.type == (sbyte) 0)
      {
        if (this.tick == this.attack1.Length - 1)
          this.status = 2;
        this.dir = this.x >= this.charAttack[0].cx ? -1 : 1;
        this.checkFrameTick(this.attack1);
        if (this.tick == 8)
        {
          for (int index = 0; index < this.charAttack.Length; ++index)
            MonsterDart.addMonsterDart(this.x + (this.dir != 1 ? -45 : 45), this.y - 30, true, this.dameHP[index], 0, this.charAttack[index], 24);
        }
      }
      if (this.type == (sbyte) 1)
      {
        if (this.tick == (!this.haftBody ? this.attack2.Length - 1 : this.attack2_1.Length - 1))
          this.status = 2;
        this.dir = this.x >= this.charAttack[0].cx ? -1 : 1;
        this.checkFrameTick(!this.haftBody ? this.attack2 : this.attack2_1);
        this.x += (this.charAttack[0].cx - this.x) / 4;
        this.y += (this.charAttack[0].cy - this.y) / 4;
        if (this.tick == 18)
        {
          for (int index = 0; index < this.charAttack.Length; ++index)
          {
            this.charAttack[index].doInjure(this.dameHP[index], 0, false, false);
            ServerEffect.addServerEffect(102, this.charAttack[index].cx, this.charAttack[index].cy, 1);
          }
        }
      }
      if (this.type != (sbyte) 8)
        ;
      if (this.type != (sbyte) 2)
        return;
      if (this.tick == (!this.haftBody ? this.attack3.Length - 1 : this.attack3_1.Length - 1))
        this.status = 2;
      this.dir = this.x >= this.charAttack[0].cx ? -1 : 1;
      this.checkFrameTick(!this.haftBody ? this.attack3 : this.attack3_1);
      if (this.tick != 13)
        return;
      GameScr.shock_scr = 10;
      this.shock = true;
      for (int index = 0; index < this.charAttack.Length; ++index)
        this.charAttack[index].doInjure(this.dameHP[index], 0, false, false);
    }

    public new void updateMobWalk()
    {
    }

    public new bool isPaint() => this.x >= GameScr.cmx && this.x <= GameScr.cmx + GameScr.gW && this.y >= GameScr.cmy && this.y <= GameScr.cmy + GameScr.gH + 30 && this.status != 0;

    public new bool isUpdate() => this.status != 0;

    public new bool checkIsBoss() => this.isBoss || this.levelBoss > (sbyte) 0;

    public override void paint(mGraphics g)
    {
      if (BigBoss.data == null || this.isHide)
        return;
      if (this.isMafuba)
      {
        if (!this.changBody)
          BigBoss.data.paintFrame(g, this.frame, this.xMFB, this.yMFB, this.dir != 1 ? 1 : 0, 2);
        else
          SmallImage.drawSmallImage(g, (int) this.smallBody, this.xMFB, this.yMFB, this.dir != 1 ? 2 : 0, mGraphics.BOTTOM | mGraphics.HCENTER);
      }
      else
      {
        if (this.isShadown && this.status != 0)
          this.paintShadow(g);
        g.translate(0, GameCanvas.transY);
        if (!this.changBody)
          BigBoss.data.paintFrame(g, this.frame, this.x, this.y + this.fy, this.dir != 1 ? 1 : 0, 2);
        else
          SmallImage.drawSmallImage(g, (int) this.smallBody, this.x, this.y + this.fy - 9, this.dir != 1 ? 2 : 0, mGraphics.BOTTOM | mGraphics.HCENTER);
        g.translate(0, -GameCanvas.transY);
        int imageWidth = mGraphics.getImageWidth(this.imgHPtem);
        int imageHeight = mGraphics.getImageHeight(this.imgHPtem);
        int w0_1 = imageWidth;
        int x = this.x - imageWidth;
        int y = this.y - this.h - 5;
        int num = imageWidth * 2 * this.per / 100;
        int w0_2;
        if (num > w0_1)
        {
          w0_2 = num - w0_1;
          if (w0_2 <= 0)
            w0_2 = 0;
        }
        else
        {
          w0_1 = num;
          w0_2 = 0;
        }
        g.drawImage(GameScr.imgHP_tm_xam, x, y, mGraphics.TOP | mGraphics.LEFT);
        g.drawImage(GameScr.imgHP_tm_xam, x + imageWidth, y, mGraphics.TOP | mGraphics.LEFT);
        g.drawRegion(this.imgHPtem, 0, 0, w0_1, imageHeight, 0, x, y, mGraphics.TOP | mGraphics.LEFT);
        g.drawRegion(this.imgHPtem, 0, 0, w0_2, imageHeight, 0, x + imageWidth, y, mGraphics.TOP | mGraphics.LEFT);
        if (!this.shock)
          return;
        Res.outz("type= " + (object) this.type);
        ++this.tShock;
        EffecMn.addEff(new Effect(this.type != (sbyte) 2 ? 22 : 19, this.x + this.tShock * 50, this.y + 25, 2, 1, -1));
        EffecMn.addEff(new Effect(this.type != (sbyte) 2 ? 22 : 19, this.x - this.tShock * 50, this.y + 25, 2, 1, -1));
        if (this.tShock != 50)
          return;
        this.tShock = 0;
        this.shock = false;
      }
    }

    public new int getHPColor() => 16711680;

    public new void startDie()
    {
      this.hp = 0;
      this.injureThenDie = true;
      this.hp = 0;
      this.status = 1;
      this.p1 = -3;
      this.p2 = -this.dir;
      this.p3 = 0;
    }

    public new void attackOtherMob(Mob mobToAttack)
    {
      this.mobToAttack = mobToAttack;
      this.isBusyAttackSomeOne = true;
      this.cFocus = (Char) null;
      this.p1 = 0;
      this.p2 = 0;
      this.status = 3;
      this.tick = 0;
      this.dir = mobToAttack.x <= this.x ? -1 : 1;
      int x = mobToAttack.x;
      int y = mobToAttack.y;
      if (Res.abs(x - this.x) < this.w * 2 && Res.abs(y - this.y) < this.h * 2)
      {
        if (this.x < x)
          this.x = x - this.w;
        else
          this.x = x + this.w;
        this.p3 = 0;
      }
      else
        this.p3 = 1;
    }

    public new int getX() => this.x;

    public new int getY() => this.haftBody ? this.y - 20 : this.y - 60;

    public new int getH() => 40;

    public new int getW() => 60;

    public new void stopMoving()
    {
      if (this.status != 5)
        return;
      this.status = 2;
      this.p1 = this.p2 = this.p3 = 0;
      this.forceWait = 50;
    }

    public new bool isInvisible() => this.status == 0 || this.status == 1;

    public new void removeHoldEff()
    {
      if (this.holdEffID == 0)
        return;
      this.holdEffID = 0;
    }

    public new void removeBlindEff() => this.blindEff = false;

    public new void removeSleepEff() => this.sleepEff = false;
  }
}
