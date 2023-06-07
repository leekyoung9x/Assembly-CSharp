// Decompiled with JetBrains decompiler
// Type: MyRandom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

using System;

public class MyRandom
{
  public Random r;

  public MyRandom() => this.r = new Random();

  public int nextInt() => this.r.Next();

  public int nextInt(int a) => this.r.Next(a);

  public int nextInt(int a, int b) => this.r.Next(a, b);
}
