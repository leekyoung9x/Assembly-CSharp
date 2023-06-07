// Decompiled with JetBrains decompiler
// Type: EffectManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D25A375-7290-4DB0-A96A-9F9453CA43D1
// Assembly location: C:\Users\thtung\Downloads\Dragonboy_vn_v231\Dragonboy_vn_v231_Data\Managed\Assembly-CSharp.dll

public class EffectManager : MyVector
{
  public static EffectManager lowEffects = new EffectManager();
  public static EffectManager mid_2Effects = new EffectManager();
  public static EffectManager midEffects = new EffectManager();
  public static EffectManager hiEffects = new EffectManager();

  public void updateAll()
  {
    for (int index = this.size() - 1; index >= 0; --index)
    {
      Effect_End effectEnd = (Effect_End) this.elementAt(index);
      if (effectEnd != null)
      {
        effectEnd.update();
        if (effectEnd.isRemove)
          this.removeElementAt(index);
      }
    }
  }

  public static void update()
  {
    EffectManager.hiEffects.updateAll();
    EffectManager.mid_2Effects.updateAll();
    EffectManager.midEffects.updateAll();
    EffectManager.lowEffects.updateAll();
  }

  public void paintAll(mGraphics g)
  {
    for (int index = 0; index < this.size(); ++index)
    {
      Effect_End effectEnd = (Effect_End) this.elementAt(index);
      if (effectEnd != null && !effectEnd.isRemove)
        ((Effect_End) this.elementAt(index)).paint(g);
    }
  }

  public void removeAll()
  {
    for (int index = this.size() - 1; index >= 0; --index)
    {
      Effect_End effectEnd = (Effect_End) this.elementAt(index);
      if (effectEnd != null)
      {
        effectEnd.isRemove = true;
        this.removeElementAt(index);
      }
    }
  }

  public static void remove()
  {
    EffectManager.hiEffects.removeAll();
    EffectManager.lowEffects.removeAll();
    EffectManager.midEffects.removeAll();
    EffectManager.mid_2Effects.removeAll();
  }

  public static void addHiEffect(Effect_End eff) => EffectManager.hiEffects.addElement((object) eff);

  public static void addMidEffects(Effect_End eff) => EffectManager.midEffects.addElement((object) eff);

  public static void addMid_2Effects(Effect_End eff) => EffectManager.mid_2Effects.addElement((object) eff);

  public static void addLowEffect(Effect_End eff) => EffectManager.lowEffects.addElement((object) eff);
}
