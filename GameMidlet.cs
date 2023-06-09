﻿// Decompiled with JetBrains decompiler
// Type: GameMidlet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class GameMidlet
{
  public static string IP = "112.213.94.23";
  public static int PORT = 14445;
  public static string IP2;
  public static int PORT2;
  public static sbyte PROVIDER;
  public static string VERSION = "2.3.1";
  public static GameCanvas gameCanvas;
  public static GameMidlet instance;
  public static bool isConnect2;
  public static bool isBackWindowsPhone;

  public GameMidlet() => this.initGame();

  public void initGame()
  {
    GameMidlet.instance = this;
    MotherCanvas.instance = new MotherCanvas();
    Session_ME.gI().setHandler((IMessageHandler) Controller.gI());
    Session_ME2.gI().setHandler((IMessageHandler) Controller.gI());
    Session_ME2.isMainSession = false;
    GameMidlet.instance = this;
    GameMidlet.gameCanvas = new GameCanvas();
    GameMidlet.gameCanvas.start();
    SplashScr.loadImg();
    SplashScr.loadSplashScr();
    GameCanvas.currentScreen = (mScreen) new SplashScr();
  }

  public void exit()
  {
    if (Main.typeClient == 6)
    {
      mSystem.exitWP();
    }
    else
    {
      GameCanvas.bRun = false;
      mSystem.gcc();
      this.notifyDestroyed();
    }
  }

  public static void sendSMS(string data, string to, Command successAction, Command failAction) => Cout.println("SEND SMS");

  public static void flatForm(string url)
  {
    Cout.LogWarning("PLATFORM REQUEST: " + url);
    Application.OpenURL(url);
  }

  public void notifyDestroyed() => Main.exit();

  public void platformRequest(string url)
  {
    Cout.LogWarning("PLATFORM REQUEST: " + url);
    Application.OpenURL(url);
  }
}
