// Decompiled with JetBrains decompiler
// Type: Net
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

internal class Net
{
  public static WWW www;
  public static Command h;

  public static void update()
  {
    if (Net.www == null || !Net.www.isDone)
      return;
    string str = string.Empty;
    if (Net.www.error == null || Net.www.error.Equals(string.Empty))
      str = Net.www.text;
    Net.www = (WWW) null;
    if (Net.h == null)
      return;
    Net.h.perform(str);
  }

  public static void connectHTTP(string link, Command h)
  {
    if (Net.www != null)
      Cout.LogError("GET HTTP BUSY");
    Net.www = new WWW(link);
    Net.h = h;
  }

  public static void connectHTTP2(string link, Command h)
  {
    Net.h = h;
    if (link == null)
      return;
    h.perform(link);
  }
}
