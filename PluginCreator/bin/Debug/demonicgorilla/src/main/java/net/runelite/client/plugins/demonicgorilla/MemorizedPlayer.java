package net.runelite.client.plugins.demonicgorilla;

import java.util.ArrayList;
import java.util.List;
import net.runelite.api.Hitsplat;
import net.runelite.api.Player;
import net.runelite.api.coords.WorldArea;

public class MemorizedPlayer {
  private Player player;
  
  private WorldArea lastWorldArea;
  
  private List<Hitsplat> recentHitsplats;
  
  public Player getPlayer() {
    return this.player;
  }
  
  public WorldArea getLastWorldArea() {
    return this.lastWorldArea;
  }
  
  public void setLastWorldArea(WorldArea lastWorldArea) {
    this.lastWorldArea = lastWorldArea;
  }
  
  public List<Hitsplat> getRecentHitsplats() {
    return this.recentHitsplats;
  }
  
  public MemorizedPlayer(Player player) {
    this.player = player;
    this.recentHitsplats = new ArrayList<>();
  }
}
