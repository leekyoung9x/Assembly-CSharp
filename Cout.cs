// Decompiled with JetBrains decompiler
// Type: Cout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class Cout
{
  public static int count;

  public static void println(string s)
  {
    if (!mSystem.isTest)
      return;
    Debug.Log((object) ((Cout.count % 2 != 0 ? "***--- " : ">>>--- ") + s));
    ++Cout.count;
  }

  public static void Log(string str)
  {
    if (!mSystem.isTest)
      return;
    Debug.Log((object) str);
  }

  public static void LogError(string str)
  {
    if (!mSystem.isTest)
      return;
    Debug.LogError((object) str);
  }

  public static void LogError2(string str)
  {
    if (!mSystem.isTest)
      ;
  }

  public static void LogError3(string str)
  {
    if (!mSystem.isTest)
      return;
    Debug.LogError((object) str);
  }

  public static void LogWarning(string str)
  {
    if (!mSystem.isTest)
      return;
    Debug.LogWarning((object) str);
  }
}
