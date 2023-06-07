// Decompiled with JetBrains decompiler
// Type: TaskOrder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class TaskOrder
{
  public const sbyte TASK_DAY = 0;
  public const sbyte TASK_BOSS = 1;
  public int taskId;
  public int count;
  public short maxCount;
  public string name;
  public string description;
  public int killId;
  public int mapId;

  public TaskOrder(
    sbyte taskId,
    short count,
    short maxCount,
    string name,
    string description,
    sbyte killId,
    sbyte mapId)
  {
    this.count = (int) count;
    this.maxCount = maxCount;
    this.taskId = (int) taskId;
    this.name = name;
    this.description = description;
    this.killId = (int) killId;
    this.mapId = (int) mapId;
  }
}
