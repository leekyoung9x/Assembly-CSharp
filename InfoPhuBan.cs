﻿// Decompiled with JetBrains decompiler
// Type: InfoPhuBan
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class InfoPhuBan
{
  public int type_PB;
  public int maxPoint;
  public int pointTeam1;
  public int pointTeam2;
  public int color_1;
  public int color_2;
  public int maxLife = 1;
  public int lifeTeam1;
  public int lifeTeam2;
  public string nameTeam1;
  public string nameTeam2;
  public short idmapPaint;
  public short timeSecond;
  public short timepaintSecond;
  public short maxtimeSecond = 1;
  public byte owner;
  public long timeStart;
  public MyVector vecInfo = new MyVector("vecInfo chientruong");

  public InfoPhuBan(
    int type_PB,
    short idmapPaint,
    string nameTeam1,
    string nameTeam2,
    int maxPoint,
    short timeSecond)
  {
    this.type_PB = type_PB;
    this.idmapPaint = idmapPaint;
    this.nameTeam1 = nameTeam1;
    this.nameTeam2 = nameTeam2;
    this.timeSecond = timeSecond;
    this.timeStart = GameCanvas.timeNow;
    this.maxPoint = maxPoint;
    if (this.maxPoint <= 0)
      this.maxPoint = 1;
    this.pointTeam1 = 0;
    this.pointTeam2 = 0;
    this.owner = (byte) 0;
    this.color_1 = 4;
    this.color_2 = 6;
  }

  public void updateTime(int type_PB, short timeSecond)
  {
    this.type_PB = type_PB;
    this.timeSecond = timeSecond;
    this.timeStart = GameCanvas.timeNow;
  }

  public void updatePoint(int type_PB, int pointTeam1, int pointTeam2)
  {
    this.type_PB = type_PB;
    this.pointTeam1 = pointTeam1;
    this.pointTeam2 = pointTeam2;
  }

  public void updateLife(int type_PB, int lifeTeam1, int lifeTeam2)
  {
    this.type_PB = type_PB;
    this.lifeTeam1 = lifeTeam1;
    this.lifeTeam2 = lifeTeam2;
  }
}
