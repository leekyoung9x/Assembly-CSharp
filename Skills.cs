// Decompiled with JetBrains decompiler
// Type: Skills
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class Skills
{
  public static MyHashTable skills = new MyHashTable();

  public static void add(Skill skill) => Skills.skills.put((object) skill.skillId, (object) skill);

  public static Skill get(short skillId) => (Skill) Skills.skills.get((object) skillId);
}
