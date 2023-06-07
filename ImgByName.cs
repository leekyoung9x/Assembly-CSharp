// Decompiled with JetBrains decompiler
// Type: ImgByName
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using UnityEngine;

public class ImgByName
{
  public static MyHashTable hashImagePath = new MyHashTable();

  public static void SetImage(string name, Image img, sbyte nFrame) => ImgByName.hashImagePath.put((object) (string.Empty + name), (object) new MainImage(img, nFrame));

  public static MainImage getImagePath(string nameImg, MyHashTable hash)
  {
    MainImage v = (MainImage) hash.get((object) (string.Empty + nameImg));
    if (v == null)
    {
      v = new MainImage();
      MainImage fromRms = ImgByName.getFromRms(nameImg);
      if (fromRms != null)
      {
        v.img = fromRms.img;
        v.nFrame = fromRms.nFrame;
      }
      hash.put((object) (string.Empty + nameImg), (object) v);
    }
    v.count = GameCanvas.timeNow / 1000L;
    if (v.img == null)
    {
      --v.timeImageNull;
      if (v.timeImageNull <= 0)
      {
        Service.gI().getImgByName(nameImg);
        v.timeImageNull = 200;
      }
    }
    return v;
  }

  public static MainImage getFromRms(string nameImg)
  {
    string filename = mGraphics.zoomLevel.ToString() + "ImgByName_" + nameImg;
    MainImage fromRms1 = (MainImage) null;
    sbyte[] imageData = Rms.loadRMS(filename);
    if (imageData == null)
      return fromRms1;
    MainImage fromRms2;
    try
    {
      fromRms2 = new MainImage();
      fromRms2.nFrame = imageData[0];
      fromRms2.img = Image.createImage(imageData, 1, imageData.Length - 1);
      if (fromRms2.img != null)
        ;
    }
    catch (Exception ex)
    {
      Debug.LogError((object) (filename + ">>>>>getFromRms: nulllllllllll 2222"));
      return (MainImage) null;
    }
    return fromRms2;
  }

  public static void saveRMS(string nameImg, sbyte nFrame, sbyte[] data)
  {
    string filename = mGraphics.zoomLevel.ToString() + "ImgByName_" + nameImg;
    DataOutputStream dataOutputStream = new DataOutputStream(data.Length + 1);
    int index = 0;
    try
    {
      dataOutputStream.writeByte(nFrame);
      for (index = 0; index < data.Length; ++index)
        dataOutputStream.writeByte(data[index]);
      Rms.saveRMS(filename, dataOutputStream.toByteArray());
      dataOutputStream.close();
    }
    catch (Exception ex)
    {
      Debug.LogError((object) (index.ToString() + ">>Errr save rms: " + filename + "  " + ex.ToString()));
    }
  }

  public static void checkDelHash(MyHashTable hash, int minute, bool isTrue)
  {
    MyVector myVector = new MyVector(nameof (checkDelHash));
    if (isTrue)
    {
      hash.clear();
    }
    else
    {
      IDictionaryEnumerator enumerator = hash.GetEnumerator();
      while (enumerator.MoveNext())
      {
        MainImage mainImage = (MainImage) enumerator.Value;
        if (GameCanvas.timeNow / 1000L - mainImage.count > (long) (minute * 60))
        {
          string key = (string) enumerator.Key;
          myVector.addElement((object) key);
        }
      }
      for (int index = 0; index < myVector.size(); ++index)
        hash.remove((object) (string) myVector.elementAt(index));
    }
  }
}
