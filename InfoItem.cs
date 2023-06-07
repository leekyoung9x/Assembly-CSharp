// Decompiled with JetBrains decompiler
// Type: InfoItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class InfoItem
{
  public string s;
  private mFont f;
  public int speed = 70;
  public Char charInfo;
  public bool isChatServer;
  public bool isOnline;
  public int timeCount;
  public int maxTime;
  public long last;
  public long curr;

  public InfoItem(string s)
  {
    this.f = mFont.tahoma_7_green2;
    this.s = s;
    this.speed = 20;
  }

  public InfoItem(string s, mFont f, int speed)
  {
    this.f = f;
    this.s = s;
    this.speed = speed;
  }
}
