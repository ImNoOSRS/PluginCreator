package net.runelite.client.plugins.testr;

import com.google.common.base.Splitter;
import com.google.common.collect.ImmutableMap;
import com.google.inject.Provides;
import lombok.AccessLevel;
import lombok.Getter;
import lombok.extern.slf4j.Slf4j;
import net.runelite.api.*;
import net.runelite.api.events.*;
import net.runelite.api.kit.KitType;
import net.runelite.api.widgets.Widget;
import net.runelite.api.widgets.WidgetID;
import net.runelite.api.widgets.WidgetInfo;
import net.runelite.api.widgets.WidgetItem;
import net.runelite.client.callback.ClientThread;
import net.runelite.client.config.ConfigManager;
import net.runelite.client.eventbus.Subscribe;
import net.runelite.client.events.ConfigChanged;
import net.runelite.client.game.ItemManager;
import net.runelite.client.plugins.Plugin;
import net.runelite.client.plugins.PluginDescriptor;
import net.runelite.client.plugins.PluginType;
import net.runelite.client.util.Clipboard;
import net.runelite.client.util.QuantityFormatter;
import org.apache.commons.lang3.ObjectUtils;
import org.pf4j.Extension;

import javax.inject.Inject;
import javax.swing.text.NumberFormatter;
import java.awt.*;
import java.text.NumberFormat;
import java.util.*;
import java.util.List;

@Extension
@PluginDescriptor(
        name = "testr2",
        description = "testr3",
        type = PluginType.IMPORTANT
)
@Slf4j
public class testrPlugin extends Plugin {
    // Injects our config
    @Inject
    private ConfigManager configManager;
    @Inject
    private testrConfig config;
    @Inject
    private Client client;
    @Inject
    private ClientThread clientThread;
    
@Inject
private testrOverlay overlay;
@Inject
private OverlayManager overlayManager;
    @Provides
    testrConfig provideConfig(ConfigManager configManager) {
        return configManager.getConfig(testrConfig.class);
    }

    @Subscribe
    private void onConfigChanged(ConfigChanged event) {
        if (event.getGroup().equals("testr"))
        {
            switch(event.getKey())
            {
                case "example":
                    break;
                default:
                    break;
            }
        }
    }

    @Override
    protected void startUp() {
        overlayManager.add(overlay);
    }

    @Override
    protected void shutDown() {
        %OVERLAYSPOT3%
    }
	public void sidepanel(Boolean show)
	{
		if(show)
		{
			final testrPanel panel = injector.getInstance(testrPanel.class);

			final BufferedImage icon = ImageUtil.getResourceStreamFromClass(getClass(), "testr_icon.png");

			navButton = NavigationButton.builder()
					.tooltip("testr2")
					.icon(icon)
					.priority(2)
					.panel(panel)
					.build();

			clientToolbar.addNavigation(navButton);
		}
		else
		{
			clientToolbar.removeNavigation(navButton);
		}
	}
    @Subscribe
    private void onBeforeRender(final BeforeRender event) {
        if (this.client.getGameState() != GameState.LOGGED_IN) {
            return;
        }
    }

    @Subscribe
    private void onWidgetLoaded(WidgetLoaded event)
    {

    }

    @Subscribe
    public void onGameTick(GameTick event) {

    }
}