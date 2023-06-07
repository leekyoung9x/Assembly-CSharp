// Decompiled with JetBrains decompiler
// Type: Key
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class Key
{
  public static int NUM0;
  public static int NUM1 = 1;
  public static int NUM2 = 2;
  public static int NUM3 = 3;
  public static int NUM4 = 4;
  public static int NUM5 = 5;
  public static int NUM6 = 6;
  public static int NUM7 = 7;
  public static int NUM8 = 8;
  public static int NUM9 = 9;
  public static int STAR = 10;
  public static int BOUND = 11;
  public static int UP = 12;
  public static int DOWN = 13;
  public static int LEFT = 14;
  public static int RIGHT = 15;
  public static int FIRE = 16;
  public static int LEFT_SOFTKEY = 17;
  public static int RIGHT_SOFTKEY = 18;
  public static int CLEAR = 19;
  public static int BACK = 20;

  public static void mapKeyPC()
  {
    if (!Main.isPC)
      return;
    Key.UP = 15;
    Key.DOWN = 16;
    Key.LEFT = 17;
    Key.RIGHT = 18;
  }
}
