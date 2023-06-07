// Decompiled with JetBrains decompiler
// Type: MainImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class MainImage
{
  public Image img;
  public long count = -1;
  public int timeImageNull;
  public int idImage;
  public long timerequest;
  public sbyte nFrame = 1;
  public long timeUse = mSystem.currentTimeMillis();

  public MainImage()
  {
  }

  public MainImage(Image im, sbyte nFrame)
  {
    this.img = im;
    this.count = 0L;
    this.nFrame = nFrame;
  }
}
