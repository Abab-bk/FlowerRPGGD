using DsUi;
using Game.Scripts.Ui.ItemTooltip;
using Godot;

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
                Global.PlayerInventory,
                Global.Player.Equipments
                );
            S_AbilityLoadoutUi.Instance.Init(Global.Player.AbilityLoadout);
        };
    }

    public override void _ShortcutInput(InputEvent @event)
    {
        if (@event.IsActionPressed("CharacterUi"))
        {
            ChangePage(Page.CharacterUi);
        }
    }
    
    public override void _Input(InputEvent @event)
    {
        if (@event.IsActionPressed("Pause"))
        {
            if (Global.IsPaused)
            {
                UiManager.Destroy_PauseMenu();
            }
            else
            {
                UiManager.Open_PauseMenu();
            }
        }
    }
}
