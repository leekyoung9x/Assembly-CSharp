// Decompiled with JetBrains decompiler
// Type: ItemTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class ItemTime
{
  public short idIcon;
  public int second;
  public int minute;
  private long curr;
  private long last;
  private bool isText;
  private bool dontClear;
  private string text;
  private bool isPaint_coolDownBar;
  public int time;
  public int coutTime;
  private int per = 100;

  public ItemTime()
  {
  }

  public ItemTime(short idIcon, int s)
  {
    this.idIcon = idIcon;
    this.minute = s / 60;
    this.second = s % 60;
    this.time = s;
    this.coutTime = s;
    this.curr = this.last = mSystem.currentTimeMillis();
    this.isPaint_coolDownBar = idIcon == (short) 14;
  }

  public void initTimeText(sbyte id, string text, int time)
  {
    this.dontClear = time == -1;
    this.isText = true;
    this.minute = time / 60;
    this.second = time % 60;
    this.idIcon = (short) id;
    this.time = time;
    this.coutTime = time;
    this.text = text;
    this.curr = this.last = mSystem.currentTimeMillis();
    this.isPaint_coolDownBar = this.idIcon == (short) 14;
  }

  public void initTime(int time, bool isText)
  {
    this.minute = time / 60;
    this.second = time % 60;
    this.time = time;
    this.coutTime = time;
    this.isText = isText;
    this.curr = this.last = mSystem.currentTimeMillis();
  }

  public static bool isExistItem(int id)
  {
    for (int index = 0; index < Char.vItemTime.size(); ++index)
    {
      if ((int) ((ItemTime) Char.vItemTime.elementAt(index)).idIcon == id)
        return true;
    }
    return false;
  }

  public static ItemTime getMessageById(int id)
  {
    for (int index = 0; index < GameScr.textTime.size(); ++index)
    {
      ItemTime messageById = (ItemTime) GameScr.textTime.elementAt(index);
      if ((int) messageById.idIcon == id)
        return messageById;
    }
    return (ItemTime) null;
  }

  public static bool isExistMessage(int id)
  {
    for (int index = 0; index < GameScr.textTime.size(); ++index)
    {
      if ((int) ((ItemTime) GameScr.textTime.elementAt(index)).idIcon == id)
        return true;
    }
    return false;
  }

  public static ItemTime getItemById(int id)
  {
    for (int index = 0; index < Char.vItemTime.size(); ++index)
    {
      ItemTime itemById = (ItemTime) Char.vItemTime.elementAt(index);
      if ((int) itemById.idIcon == id)
        return itemById;
    }
    return (ItemTime) null;
  }

  public void initTime(int time)
  {
    this.minute = time / 60;
    this.second = time % 60;
    this.coutTime = time;
    this.curr = this.last = mSystem.currentTimeMillis();
  }

  public void paint(mGraphics g, int x, int y)
  {
    SmallImage.drawSmallImage(g, (int) this.idIcon, x, y, 0, 3);
    string empty = string.Empty;
    string st = this.minute.ToString() + "'";
    if (this.minute == 0)
      st = this.second.ToString() + "s";
    mFont.tahoma_7b_white.drawString(g, st, x, y + 15, 2, mFont.tahoma_7b_dark);
  }

  public void paintText(mGraphics g, int x, int y)
  {
    if (this.isPaint_coolDownBar)
    {
      if (Char.myCharz() == null)
        return;
      int w = 80;
      int x1 = GameCanvas.w / 2 - w / 2;
      int y1 = GameCanvas.h - 80;
      g.setColor(8421504);
      g.fillRect(x1, y1, w, 2);
      g.setColor(16777215);
      if (this.per <= 0)
        return;
      g.fillRect(x1, y1, w * this.per / 100, 2);
    }
    else
    {
      string empty = string.Empty;
      string str = this.minute.ToString() + "'";
      if (this.minute < 1)
        str = this.second.ToString() + "s";
      if (this.minute < 0)
        str = string.Empty;
      if (this.dontClear)
        str = string.Empty;
      mFont.tahoma_7b_white.drawString(g, this.text + " " + str, x, y, 0, mFont.tahoma_7b_dark);
    }
  }

  public void update()
  {
    this.curr = mSystem.currentTimeMillis();
    if (this.curr - this.last >= 1000L)
    {
      this.last = mSystem.currentTimeMillis();
      --this.second;
      --this.coutTime;
      if (this.second <= 0)
      {
        this.second = 60;
        --this.minute;
      }
      if (this.time > 0)
        this.per = this.coutTime * 100 / this.time;
    }
    if (this.minute < 0 && !this.isText)
      Char.vItemTime.removeElement((object) this);
    if (this.minute >= 0 || !this.isText || this.dontClear)
      return;
    GameScr.textTime.removeElement((object) this);
  }
}
