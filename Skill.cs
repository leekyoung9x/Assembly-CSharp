﻿// Decompiled with JetBrains decompiler
// Type: Skill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class Skill
{
  public const sbyte ATT_STAND = 0;
  public const sbyte ATT_FLY = 1;
  public const sbyte SKILL_AUTO_USE = 0;
  public const sbyte SKILL_CLICK_USE_ATTACK = 1;
  public const sbyte SKILL_CLICK_USE_BUFF = 2;
  public const sbyte SKILL_CLICK_NPC = 3;
  public const sbyte SKILL_CLICK_LIVE = 4;
  public SkillTemplate template;
  public short skillId;
  public int point;
  public long powRequire;
  public int coolDown;
  public long lastTimeUseThisSkill;
  public int dx;
  public int dy;
  public int maxFight;
  public int manaUse;
  public SkillOption[] options;
  public bool paintCanNotUseSkill;
  public short damage;
  public string moreInfo;
  public short price;
  public short curExp;

  public string strCurExp()
  {
    if ((int) this.curExp / 10 >= 100)
      return "MAX";
    if ((int) this.curExp % 10 == 0)
      return ((int) this.curExp / 10).ToString() + "%";
    return ((int) this.curExp / 10).ToString() + "." + (object) ((int) this.curExp % 10 % 10) + "%";
  }

  public string strTimeReplay()
  {
    if (this.coolDown % 1000 == 0)
      return (this.coolDown / 1000).ToString() + string.Empty;
    int num = this.coolDown % 1000;
    return (this.coolDown / 1000).ToString() + "." + (object) (num % 100 != 0 ? num / 10 : num / 100);
  }

  public void paint(int x, int y, mGraphics g)
  {
    SmallImage.drawSmallImage(g, this.template.iconId, x, y, 0, StaticObj.VCENTER_HCENTER);
    long num1 = mSystem.currentTimeMillis() - this.lastTimeUseThisSkill;
    if (num1 < (long) this.coolDown)
    {
      g.setColor(2721889, 0.7f);
      if (this.paintCanNotUseSkill && GameCanvas.gameTick % 6 > 2)
        g.setColor(876862);
      int num2 = (int) (num1 * 20L / (long) this.coolDown);
      g.fillRect(x - 10, y - 10 + num2, 20, 20 - num2);
    }
    else
      this.paintCanNotUseSkill = false;
  }
}
