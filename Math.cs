﻿// Decompiled with JetBrains decompiler
// Type: Math
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class Math
{
  public const double PI = 3.1415926535897931;

  public static int abs(int i) => i > 0 ? i : -i;

  public static int min(int x, int y) => x < y ? x : y;

  public static int max(int x, int y) => x > y ? x : y;

  public static int pow(int data, int x)
  {
    int num = 1;
    for (int index = 0; index < x; ++index)
      num *= data;
    return num;
  }
}
