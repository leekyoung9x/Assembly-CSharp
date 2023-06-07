// Decompiled with JetBrains decompiler
// Type: EffectPaint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class EffectPaint
{
  public int index;
  public Mob eMob;
  public Char eChar;
  public EffectCharPaint effCharPaint;
  public bool isFly;

  public int getImgId() => this.effCharPaint.arrEfInfo[this.index].idImg;
}
