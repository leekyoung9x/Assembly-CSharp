// Decompiled with JetBrains decompiler
// Type: SkillTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class SkillTemplate
{
  public sbyte id;
  public int classId;
  public string name;
  public int maxPoint;
  public int manaUseType;
  public int type;
  public int iconId;
  public string[] description;
  public Skill[] skills;
  public string damInfo;

  public bool isBuffToPlayer() => this.type == 2;

  public bool isUseAlone() => this.type == 3;

  public bool isAttackSkill() => this.type == 1;

  public bool isSkillSpec() => this.type == 4;
}
