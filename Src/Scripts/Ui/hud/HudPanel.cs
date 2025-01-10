using DsUi;
using Game.Scripts.Ui.ItemTooltip;

namespace Game.Scripts.Ui.Hud;

public partial class HudPanel : Hud
{
    private ItemTooltipPanel ItemTooltipPanel { get; set; }
    
    private enum Page
    {
        Home,
        CharacterUi,
    }

    private void ChangePage(Page page)
    {
        if (S_Pages.Instance.CurrentTab == (int)page)
        {
            S_Pages.Instance.CurrentTab = (int)Page.Home;
            return;
        }
        S_Pages.Instance.CurrentTab = (int)page;
    }

    public override void OnCreateUi()
    {
        base.OnCreateUi();
        Global.Hud = this;

        ItemTooltipPanel = UiManager.Create_ItemTooltip();

        EventBus.ItemTooltipRequested += (item, vector2) =>
        {
            ItemTooltipPanel.UpdateTooltip(item);
            ItemTooltipPanel.GlobalPosition = vector2;
            ItemTooltipPanel.Show();
        };
        
        EventBus.ItemTooltipCanceled += () =>
        {
            ItemTooltipPanel.Hide();
            ItemTooltipPanel.Clean();
        };

        EventBus.PlayerReady += () =>
        {
            S_CharacterUi.Instance.Init(
                Global.Player.Stats,
                Global.PlayerInventory,
                Global.Player.Equipments
                );
            S_AbilityLoadoutUi.Instance.Init(Global.Player.AbilityLoadout);
        };

        InputManager.CharacterUi.OnPerformed += () =>
        {
            ChangePage(Page.CharacterUi);
        };

        InputManager.Pause.OnPerformed += () =>
        {
            if (Global.IsPaused)
            {
                UiManager.Destroy_PauseMenu();
            }
            else
            {
                UiManager.Open_PauseMenu();
            }
        };
    }
}
