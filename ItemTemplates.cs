// Decompiled with JetBrains decompiler
// Type: ItemTemplates
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class ItemTemplates
{
  public static MyHashTable itemTemplates = new MyHashTable();

  public static void add(ItemTemplate it) => ItemTemplates.itemTemplates.put((object) it.id, (object) it);

  public static ItemTemplate get(short id) => (ItemTemplate) ItemTemplates.itemTemplates.get((object) id);

  public static short getPart(short itemTemplateID) => ItemTemplates.get(itemTemplateID).part;

  public static short getIcon(short itemTemplateID) => ItemTemplates.get(itemTemplateID).iconID;
}
