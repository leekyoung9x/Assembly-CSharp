// Decompiled with JetBrains decompiler
// Type: EffectChar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class EffectChar
{
  public static EffectTemplate[] effTemplates;
  public static sbyte EFF_ME;
  public static sbyte EFF_FRIEND = 1;
  public int timeStart;
  public int timeLenght;
  public short param;
  public EffectTemplate template;

  public EffectChar(sbyte templateId, int timeStart, int timeLenght, short param)
  {
    this.template = EffectChar.effTemplates[(int) templateId];
    this.timeStart = timeStart;
    this.timeLenght = timeLenght / 1000;
    this.param = param;
  }
}
