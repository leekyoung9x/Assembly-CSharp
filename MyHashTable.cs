// Decompiled with JetBrains decompiler
// Type: MyHashTable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

using System.Collections;

public class MyHashTable
{
  public Hashtable h = new Hashtable();

  public object get(object k) => this.h[k];

  public void clear() => this.h.Clear();

  public IDictionaryEnumerator GetEnumerator() => this.h.GetEnumerator();

  public int size() => this.h.Count;

  public void put(object k, object v)
  {
    if (this.h.ContainsKey(k))
      this.h.Remove(k);
    this.h.Add(k, v);
  }

  public void remove(object k) => this.h.Remove(k);

  public void Remove(string key) => this.h.Remove((object) key);

  public bool containsKey(object key) => this.h.ContainsKey(key);
}
