package net.runelite.client.plugins.demonicgorilla;

import java.util.Arrays;
import java.util.List;
import net.runelite.api.Actor;
import net.runelite.api.HeadIcon;
import net.runelite.api.NPC;
import net.runelite.api.NPCComposition;
import net.runelite.api.coords.WorldArea;

public class DemonicGorilla {
  static final int MAX_ATTACK_RANGE = 10;
  
  static final int ATTACK_RATE = 5;
  
  static final int ATTACKS_PER_SWITCH = 3;
  
  static final int PROJECTILE_MAGIC_SPEED = 8;
  
  static final int PROJECTILE_RANGED_SPEED = 6;
  
  static final int PROJECTILE_MAGIC_DELAY = 12;
  
  static final int PROJECTILE_RANGED_DELAY = 9;
  
  public static final AttackStyle[] ALL_REGULAR_ATTACK_STYLES = new AttackStyle[] { AttackStyle.MELEE, AttackStyle.RANGED, AttackStyle.MAGIC };
  
  private NPC npc;
  
  private List<AttackStyle> nextPosibleAttackStyles;
  
  private int attacksUntilSwitch;
  
  private int nextAttackTick;
  
  private int lastTickAnimation;
  
  private WorldArea lastWorldArea;
  
  private boolean initiatedCombat;
  
  private Actor lastTickInteracting;
  
  private boolean takenDamageRecently;
  
  private int recentProjectileId;
  
  private boolean changedPrayerThisTick;
  
  private boolean changedAttackStyleThisTick;
  
  private boolean changedAttackStyleLastTick;
  
  private HeadIcon lastTickOverheadIcon;
  
  private int disabledMeleeMovementForTicks;
  
  enum AttackStyle {
    MAGIC, RANGED, MELEE, BOULDER;
  }
  
  public NPC getNpc() {
    return this.npc;
  }
  
  public List<AttackStyle> getNextPosibleAttackStyles() {
    return this.nextPosibleAttackStyles;
  }
  
  public void setNextPosibleAttackStyles(List<AttackStyle> nextPosibleAttackStyles) {
    this.nextPosibleAttackStyles = nextPosibleAttackStyles;
  }
  
  public int getAttacksUntilSwitch() {
    return this.attacksUntilSwitch;
  }
  
  public void setAttacksUntilSwitch(int attacksUntilSwitch) {
    this.attacksUntilSwitch = attacksUntilSwitch;
  }
  
  public int getNextAttackTick() {
    return this.nextAttackTick;
  }
  
  public void setNextAttackTick(int nextAttackTick) {
    this.nextAttackTick = nextAttackTick;
  }
  
  public int getLastTickAnimation() {
    return this.lastTickAnimation;
  }
  
  public void setLastTickAnimation(int lastTickAnimation) {
    this.lastTickAnimation = lastTickAnimation;
  }
  
  public WorldArea getLastWorldArea() {
    return this.lastWorldArea;
  }
  
  public void setLastWorldArea(WorldArea lastWorldArea) {
    this.lastWorldArea = lastWorldArea;
  }
  
  public boolean isInitiatedCombat() {
    return this.initiatedCombat;
  }
  
  public void setInitiatedCombat(boolean initiatedCombat) {
    this.initiatedCombat = initiatedCombat;
  }
  
  public Actor getLastTickInteracting() {
    return this.lastTickInteracting;
  }
  
  public void setLastTickInteracting(Actor lastTickInteracting) {
    this.lastTickInteracting = lastTickInteracting;
  }
  
  public boolean isTakenDamageRecently() {
    return this.takenDamageRecently;
  }
  
  public void setTakenDamageRecently(boolean takenDamageRecently) {
    this.takenDamageRecently = takenDamageRecently;
  }
  
  public int getRecentProjectileId() {
    return this.recentProjectileId;
  }
  
  public void setRecentProjectileId(int recentProjectileId) {
    this.recentProjectileId = recentProjectileId;
  }
  
  public boolean isChangedPrayerThisTick() {
    return this.changedPrayerThisTick;
  }
  
  public void setChangedPrayerThisTick(boolean changedPrayerThisTick) {
    this.changedPrayerThisTick = changedPrayerThisTick;
  }
  
  public boolean isChangedAttackStyleThisTick() {
    return this.changedAttackStyleThisTick;
  }
  
  public void setChangedAttackStyleThisTick(boolean changedAttackStyleThisTick) {
    this.changedAttackStyleThisTick = changedAttackStyleThisTick;
  }
  
  public boolean isChangedAttackStyleLastTick() {
    return this.changedAttackStyleLastTick;
  }
  
  public void setChangedAttackStyleLastTick(boolean changedAttackStyleLastTick) {
    this.changedAttackStyleLastTick = changedAttackStyleLastTick;
  }
  
  public HeadIcon getLastTickOverheadIcon() {
    return this.lastTickOverheadIcon;
  }
  
  public void setLastTickOverheadIcon(HeadIcon lastTickOverheadIcon) {
    this.lastTickOverheadIcon = lastTickOverheadIcon;
  }
  
  public int getDisabledMeleeMovementForTicks() {
    return this.disabledMeleeMovementForTicks;
  }
  
  public void setDisabledMeleeMovementForTicks(int disabledMeleeMovementForTicks) {
    this.disabledMeleeMovementForTicks = disabledMeleeMovementForTicks;
  }
  
  public DemonicGorilla(NPC npc) {
    this.npc = npc;
    this.nextPosibleAttackStyles = Arrays.asList(ALL_REGULAR_ATTACK_STYLES);
    this.nextAttackTick = -100;
    this.attacksUntilSwitch = 3;
    this.recentProjectileId = -1;
  }
  
  public HeadIcon getOverheadIcon() {
    NPCComposition composition = this.npc.getComposition();
    if (composition != null)
      return composition.getOverheadIcon(); 
    return null;
  }
}
