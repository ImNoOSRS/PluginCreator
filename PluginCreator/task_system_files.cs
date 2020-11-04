using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginCreator
{
	class task_system_files
	{
		public static string Task = @"package net.runelite.client.plugins.@@NAME@@;

import java.awt.Dimension;
import java.awt.event.MouseEvent;
import javax.inject.Inject;
import net.runelite.api.Client;
import net.runelite.api.MenuEntry;
import net.runelite.api.Point;
import net.runelite.api.events.GameTick;
import net.runelite.api.events.MenuOptionClicked;

public abstract class Task {
  @Inject
  public @@NAME@@Plugin plugin;
  
  @Inject
  public Client client;
  
  @Inject
  public @@NAME@@Config config;
  
  public MenuEntry entry;
  
  public abstract boolean validate();
  
  public String getTaskDescription() {
	return getClass().getSimpleName();
  }
  
  public void onGameTick(GameTick event) {}
  
  public void onMenuOptionClicked(MenuOptionClicked event) {
	if (entry != null)
	  event.setMenuEntry(entry); 
	entry = null;
  }
  
  public void click() {
	Point pos = client.getMouseCanvasPosition();
	if (client.isStretchedEnabled()) {
	  Dimension stretched = client.getStretchedDimensions();
	  Dimension real = client.getRealDimensions();
	  double width = stretched.width / real.getWidth();
	  double height = stretched.height / real.getHeight();
	  Point point = new Point((int)(pos.getX() * width), (int)(pos.getY() * height));
	  client.getCanvas().dispatchEvent(new MouseEvent(client.getCanvas(), 501, System.currentTimeMillis(), 0, point.getX(), point.getY(), 1, false, 1));
	  client.getCanvas().dispatchEvent(new MouseEvent(client.getCanvas(), 502, System.currentTimeMillis(), 0, point.getX(), point.getY(), 1, false, 1));
	  client.getCanvas().dispatchEvent(new MouseEvent(client.getCanvas(), 500, System.currentTimeMillis(), 0, point.getX(), point.getY(), 1, false, 1));
	  return;
	} 
	client.getCanvas().dispatchEvent(new MouseEvent(client.getCanvas(), 501, System.currentTimeMillis(), 0, pos.getX(), pos.getY(), 1, false, 1));
	client.getCanvas().dispatchEvent(new MouseEvent(client.getCanvas(), 502, System.currentTimeMillis(), 0, pos.getX(), pos.getY(), 1, false, 1));
	client.getCanvas().dispatchEvent(new MouseEvent(client.getCanvas(), 500, System.currentTimeMillis(), 0, pos.getX(), pos.getY(), 1, false, 1));
  }
}
";

		public static string task_set = @"package net.runelite.client.plugins.@@NAME@@;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import net.runelite.api.Client;

public class TaskSet {
  public List<Task> taskList = new ArrayList<>();
  
  public TaskSet(Task... tasks) {
	taskList.addAll(Arrays.asList(tasks));
  }
  
  public void addAll(Task... tasks) {
	taskList.addAll(Arrays.asList(tasks));
  }
  
  public TaskSet(@@NAME@@Plugin plugin, Client client, @@NAME@@Config config, Task... tasks) {
	taskList.addAll(Arrays.asList(tasks));
	verifyPlugin(plugin);
	verifyClient(client);
	verifyConfig(config);
  }
  
  public void addAll(@@NAME@@Plugin plugin, Client client, @@NAME@@Config config, Task... tasks) {
	taskList.addAll(Arrays.asList(tasks));
	verifyPlugin(plugin);
	verifyClient(client);
	verifyConfig(config);
  }
  
  public void clear() {
	taskList.clear();
  }
  
  public void verifyPlugin(@@NAME@@Plugin plugin) {
	if (plugin == null)
	  return; 
	for (Task task : taskList) {
	  if (task.plugin == null)
		task.plugin = plugin; 
	} 
  }
  
  public void verifyClient(Client client) {
	if (client == null)
	  return; 
	for (Task task : taskList) {
	  if (task.client == null)
		task.client = client; 
	} 
  }
  
  public void verifyConfig(@@NAME@@Config config) {
	if (config == null)
	  return; 
	for (Task task : taskList) {
	  if (task.config == null)
		task.config = config; 
	} 
  }
  
  public Task getValidTask() {
	for (Task task : taskList) {
	  if (task.validate())
		return task; 
	} 
	return null;
  }
}
";

		public static string Utils = @"package net.runelite.client.plugins.@@NAME@@;

import java.util.Arrays;
import net.runelite.api.Client;
import net.runelite.api.InventoryID;
import net.runelite.api.MenuEntry;
import net.runelite.api.MenuOpcode;
import net.runelite.api.widgets.WidgetInfo;

public class ImNoUtils {
  public static boolean isInRegion(Client client, Integer region) {
	if (client.getLocalPlayer() == null)
	  return false; 
	return (client.getLocalPlayer().getWorldLocation().getPlane() < 1 && Arrays.equals(client.getMapRegions(), region));
  }
  
  public static MenuEntry getConsumableEntry(String itemName, int itemId, int itemIndex) {
	return new MenuEntry(@Drink@, @<col=ff9040>@ + itemName, itemId, MenuOpcode.ITEM_FIRST_OPTION.getId(), itemIndex, WidgetInfo.INVENTORY.getId(), false);
  }
  
  public static boolean isBankOpen(Client client) {
	return (client.getItemContainer(InventoryID.BANK) != null);
  }
}
";
	}
}
