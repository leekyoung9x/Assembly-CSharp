﻿// Decompiled with JetBrains decompiler
// Type: PlayerInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class PlayerInfo
{
  public string name;
  public string showName;
  public string status;
  public int IDDB;
  private int exp;
  public bool isReady;
  public int xu;
  public int gold;
  public string strMoney = string.Empty;
  public sbyte finishPosition;
  public bool isMaster;
  public static Image[] imgStart;
  public sbyte[] indexLv;
  public int onlineTime;

  public string getName() => this.name;

  public void setMoney(int m)
  {
    this.xu = m;
    this.strMoney = GameCanvas.getMoneys(this.xu);
  }

  public void setName(string name)
  {
    this.name = name;
    if (name.Length > 9)
      this.showName = name.Substring(0, 8);
    else
      this.showName = name;
  }

  public void paint(mGraphics g, int x, int y)
  {
  }

  public int getExp() => this.exp;
}
