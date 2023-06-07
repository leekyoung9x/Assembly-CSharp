// Decompiled with JetBrains decompiler
// Type: Part
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class Part
{
  public int type;
  public PartImage[] pi;

  public Part(int type)
  {
    this.type = type;
    if (type == 0)
      this.pi = new PartImage[3];
    if (type == 1)
      this.pi = new PartImage[17];
    if (type == 2)
      this.pi = new PartImage[14];
    if (type != 3)
      return;
    this.pi = new PartImage[2];
  }
}
