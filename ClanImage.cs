﻿// Decompiled with JetBrains decompiler
// Type: ClanImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class ClanImage
{
  public int ID;
  public string name;
  public short[] idImage;
  public int xu;
  public int luong;
  public static MyVector vClanImage = new MyVector();
  public static MyHashTable idImages = new MyHashTable();

  public static void addClanImage(ClanImage cm)
  {
    Service.gI().clanImage((sbyte) cm.ID);
    ClanImage.vClanImage.addElement((object) cm);
  }

  public static ClanImage getClanImage(short ID)
  {
    for (int index = 0; index < ClanImage.vClanImage.size(); ++index)
    {
      ClanImage clanImage = (ClanImage) ClanImage.vClanImage.elementAt(index);
      if (clanImage.ID == (int) ID)
        return clanImage;
    }
    return (ClanImage) null;
  }

  public static bool isExistClanImage(int ID)
  {
    for (int index = 0; index < ClanImage.vClanImage.size(); ++index)
    {
      if (((ClanImage) ClanImage.vClanImage.elementAt(index)).ID == ID)
        return true;
    }
    return false;
  }
}
