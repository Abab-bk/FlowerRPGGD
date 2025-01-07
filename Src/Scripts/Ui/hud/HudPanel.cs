using DsUi;
using Godot;

namespace Game.Scripts.Ui.Hud;

public partial class HudPanel : Hud
{
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

        EventBus.PlayerReady += () =>
        {
            S_CharacterUi.Instance.Init(
                Global.PlayerInventory,
                Global.Player.Equipments
                );
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
