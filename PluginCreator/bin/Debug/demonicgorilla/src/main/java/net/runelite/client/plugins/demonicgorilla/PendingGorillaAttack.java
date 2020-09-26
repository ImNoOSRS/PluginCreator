package net.runelite.client.plugins.demonicgorilla;

import net.runelite.api.Player;

public class PendingGorillaAttack {
  private DemonicGorilla attacker;
  
  private DemonicGorilla.AttackStyle attackStyle;
  
  private Player target;
  
  private int finishesOnTick;
  
  public DemonicGorilla getAttacker() {
    return this.attacker;
  }
  
  public DemonicGorilla.AttackStyle getAttackStyle() {
    return this.attackStyle;
  }
  
  public Player getTarget() {
    return this.target;
  }
  
  public int getFinishesOnTick() {
    return this.finishesOnTick;
  }
  
  public PendingGorillaAttack(DemonicGorilla attacker, DemonicGorilla.AttackStyle attackStyle, Player target, int finishesOnTick) {
    this.attacker = attacker;
    this.attackStyle = attackStyle;
    this.target = target;
    this.finishesOnTick = finishesOnTick;
  }
}
