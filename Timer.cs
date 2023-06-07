// Decompiled with JetBrains decompiler
// Type: Timer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

using System;

public class Timer
{
  public static IActionListener timeListener;
  public static int idAction;
  public static long timeExecute;
  public static bool isON;

  public static void setTimer(IActionListener actionListener, int action, long timeEllapse)
  {
    Timer.timeListener = actionListener;
    Timer.idAction = action;
    Timer.timeExecute = mSystem.currentTimeMillis() + timeEllapse;
    Timer.isON = true;
  }

  public static void update()
  {
    long num = mSystem.currentTimeMillis();
    if (!Timer.isON || num <= Timer.timeExecute)
      return;
    Timer.isON = false;
    try
    {
      if (Timer.idAction <= 0)
        return;
      GameScr.gI().actionPerform(Timer.idAction, (object) null);
    }
    catch (Exception ex)
    {
    }
  }
}
