// Decompiled with JetBrains decompiler
// Type: SkillOption
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class SkillOption
{
  public int param;
  public SkillOptionTemplate optionTemplate;
  public string optionString;

  public string getOptionString()
  {
    if (this.optionString == null)
      this.optionString = NinjaUtil.replace(this.optionTemplate.name, "#", string.Empty + (object) this.param);
    return this.optionString;
  }
}
