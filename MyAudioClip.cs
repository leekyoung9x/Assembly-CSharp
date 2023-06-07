// Decompiled with JetBrains decompiler
// Type: MyAudioClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class MyAudioClip
{
  public string name;
  public AudioClip clip;
  public long timeStart;

  public MyAudioClip(string filename)
  {
    this.clip = (AudioClip) Resources.Load(filename);
    this.name = filename;
  }

  public void Play()
  {
    Main.main.GetComponent<AudioSource>().PlayOneShot(this.clip);
    this.timeStart = mSystem.currentTimeMillis();
  }

  public bool isPlaying() => false;
}
