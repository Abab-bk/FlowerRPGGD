namespace DsUi;

// 该类为自动生成的, 请不要手动编辑, 以免造成代码丢失
public static partial class UiManager
{

    public static class UiName
    {
        public const string AbilityButton = "AbilityButton";
        public const string AbilityLoadoutUi = "AbilityLoadoutUi";
        public const string BootSplash = "BootSplash";
        public const string CharacterEquipmentsUi = "CharacterEquipmentsUi";
        public const string CharacterUi = "CharacterUi";
        public const string Credits = "Credits";
        public const string Hud = "Hud";
        public const string InteractTip = "InteractTip";
        public const string InventoryUi = "InventoryUi";
        public const string ItemCell = "ItemCell";
        public const string ItemSlotUi = "ItemSlotUi";
        public const string LoadingScreen = "LoadingScreen";
        public const string Modal = "Modal";
        public const string PauseMenu = "PauseMenu";
        public const string Settings = "Settings";
        public const string StartMenu = "StartMenu";
    }

    /// <summary>
    /// 创建 AbilityButton, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.AbilityButton.AbilityButtonPanel Create_AbilityButton()
    {
        return CreateUi<Game.Scripts.Ui.AbilityButton.AbilityButtonPanel>(UiName.AbilityButton);
    }

    /// <summary>
    /// 打开 AbilityButton, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.AbilityButton.AbilityButtonPanel Open_AbilityButton()
    {
        return OpenUi<Game.Scripts.Ui.AbilityButton.AbilityButtonPanel>(UiName.AbilityButton);
    }

    /// <summary>
    /// 隐藏 AbilityButton 的所有实例
    /// </summary>
    public static void Hide_AbilityButton()
    {
        var uiInstance = Get_AbilityButton_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 AbilityButton 的所有实例
    /// </summary>
    public static void Destroy_AbilityButton()
    {
        var uiInstance = Get_AbilityButton_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 AbilityButton 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.AbilityButton.AbilityButtonPanel[] Get_AbilityButton_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.AbilityButton.AbilityButtonPanel>(nameof(Game.Scripts.Ui.AbilityButton.AbilityButton));
    }

    /// <summary>
    /// 创建 AbilityLoadoutUi, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.AbilityLoadoutUi.AbilityLoadoutUiPanel Create_AbilityLoadoutUi()
    {
        return CreateUi<Game.Scripts.Ui.AbilityLoadoutUi.AbilityLoadoutUiPanel>(UiName.AbilityLoadoutUi);
    }

    /// <summary>
    /// 打开 AbilityLoadoutUi, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.AbilityLoadoutUi.AbilityLoadoutUiPanel Open_AbilityLoadoutUi()
    {
        return OpenUi<Game.Scripts.Ui.AbilityLoadoutUi.AbilityLoadoutUiPanel>(UiName.AbilityLoadoutUi);
    }

    /// <summary>
    /// 隐藏 AbilityLoadoutUi 的所有实例
    /// </summary>
    public static void Hide_AbilityLoadoutUi()
    {
        var uiInstance = Get_AbilityLoadoutUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 AbilityLoadoutUi 的所有实例
    /// </summary>
    public static void Destroy_AbilityLoadoutUi()
    {
        var uiInstance = Get_AbilityLoadoutUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 AbilityLoadoutUi 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.AbilityLoadoutUi.AbilityLoadoutUiPanel[] Get_AbilityLoadoutUi_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.AbilityLoadoutUi.AbilityLoadoutUiPanel>(nameof(Game.Scripts.Ui.AbilityLoadoutUi.AbilityLoadoutUi));
    }

    /// <summary>
    /// 创建 BootSplash, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.BootSplash.BootSplashPanel Create_BootSplash()
    {
        return CreateUi<Game.Scripts.Ui.BootSplash.BootSplashPanel>(UiName.BootSplash);
    }

    /// <summary>
    /// 打开 BootSplash, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.BootSplash.BootSplashPanel Open_BootSplash()
    {
        return OpenUi<Game.Scripts.Ui.BootSplash.BootSplashPanel>(UiName.BootSplash);
    }

    /// <summary>
    /// 隐藏 BootSplash 的所有实例
    /// </summary>
    public static void Hide_BootSplash()
    {
        var uiInstance = Get_BootSplash_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 BootSplash 的所有实例
    /// </summary>
    public static void Destroy_BootSplash()
    {
        var uiInstance = Get_BootSplash_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 BootSplash 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.BootSplash.BootSplashPanel[] Get_BootSplash_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.BootSplash.BootSplashPanel>(nameof(Game.Scripts.Ui.BootSplash.BootSplash));
    }

    /// <summary>
    /// 创建 CharacterEquipmentsUi, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.CharacterEquipmentsUi.CharacterEquipmentsUiPanel Create_CharacterEquipmentsUi()
    {
        return CreateUi<Game.Scripts.Ui.CharacterEquipmentsUi.CharacterEquipmentsUiPanel>(UiName.CharacterEquipmentsUi);
    }

    /// <summary>
    /// 打开 CharacterEquipmentsUi, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.CharacterEquipmentsUi.CharacterEquipmentsUiPanel Open_CharacterEquipmentsUi()
    {
        return OpenUi<Game.Scripts.Ui.CharacterEquipmentsUi.CharacterEquipmentsUiPanel>(UiName.CharacterEquipmentsUi);
    }

    /// <summary>
    /// 隐藏 CharacterEquipmentsUi 的所有实例
    /// </summary>
    public static void Hide_CharacterEquipmentsUi()
    {
        var uiInstance = Get_CharacterEquipmentsUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 CharacterEquipmentsUi 的所有实例
    /// </summary>
    public static void Destroy_CharacterEquipmentsUi()
    {
        var uiInstance = Get_CharacterEquipmentsUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 CharacterEquipmentsUi 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.CharacterEquipmentsUi.CharacterEquipmentsUiPanel[] Get_CharacterEquipmentsUi_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.CharacterEquipmentsUi.CharacterEquipmentsUiPanel>(nameof(Game.Scripts.Ui.CharacterEquipmentsUi.CharacterEquipmentsUi));
    }

    /// <summary>
    /// 创建 CharacterUi, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.CharacterUi.CharacterUiPanel Create_CharacterUi()
    {
        return CreateUi<Game.Scripts.Ui.CharacterUi.CharacterUiPanel>(UiName.CharacterUi);
    }

    /// <summary>
    /// 打开 CharacterUi, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.CharacterUi.CharacterUiPanel Open_CharacterUi()
    {
        return OpenUi<Game.Scripts.Ui.CharacterUi.CharacterUiPanel>(UiName.CharacterUi);
    }

    /// <summary>
    /// 隐藏 CharacterUi 的所有实例
    /// </summary>
    public static void Hide_CharacterUi()
    {
        var uiInstance = Get_CharacterUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 CharacterUi 的所有实例
    /// </summary>
    public static void Destroy_CharacterUi()
    {
        var uiInstance = Get_CharacterUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 CharacterUi 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.CharacterUi.CharacterUiPanel[] Get_CharacterUi_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.CharacterUi.CharacterUiPanel>(nameof(Game.Scripts.Ui.CharacterUi.CharacterUi));
    }

    /// <summary>
    /// 创建 Credits, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.Credits.CreditsPanel Create_Credits()
    {
        return CreateUi<Game.Scripts.Ui.Credits.CreditsPanel>(UiName.Credits);
    }

    /// <summary>
    /// 打开 Credits, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.Credits.CreditsPanel Open_Credits()
    {
        return OpenUi<Game.Scripts.Ui.Credits.CreditsPanel>(UiName.Credits);
    }

    /// <summary>
    /// 隐藏 Credits 的所有实例
    /// </summary>
    public static void Hide_Credits()
    {
        var uiInstance = Get_Credits_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 Credits 的所有实例
    /// </summary>
    public static void Destroy_Credits()
    {
        var uiInstance = Get_Credits_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 Credits 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.Credits.CreditsPanel[] Get_Credits_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.Credits.CreditsPanel>(nameof(Game.Scripts.Ui.Credits.Credits));
    }

    /// <summary>
    /// 创建 Hud, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.Hud.HudPanel Create_Hud()
    {
        return CreateUi<Game.Scripts.Ui.Hud.HudPanel>(UiName.Hud);
    }

    /// <summary>
    /// 打开 Hud, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.Hud.HudPanel Open_Hud()
    {
        return OpenUi<Game.Scripts.Ui.Hud.HudPanel>(UiName.Hud);
    }

    /// <summary>
    /// 隐藏 Hud 的所有实例
    /// </summary>
    public static void Hide_Hud()
    {
        var uiInstance = Get_Hud_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 Hud 的所有实例
    /// </summary>
    public static void Destroy_Hud()
    {
        var uiInstance = Get_Hud_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 Hud 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.Hud.HudPanel[] Get_Hud_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.Hud.HudPanel>(nameof(Game.Scripts.Ui.Hud.Hud));
    }

    /// <summary>
    /// 创建 InteractTip, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.InteractTip.InteractTipPanel Create_InteractTip()
    {
        return CreateUi<Game.Scripts.Ui.InteractTip.InteractTipPanel>(UiName.InteractTip);
    }

    /// <summary>
    /// 打开 InteractTip, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.InteractTip.InteractTipPanel Open_InteractTip()
    {
        return OpenUi<Game.Scripts.Ui.InteractTip.InteractTipPanel>(UiName.InteractTip);
    }

    /// <summary>
    /// 隐藏 InteractTip 的所有实例
    /// </summary>
    public static void Hide_InteractTip()
    {
        var uiInstance = Get_InteractTip_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 InteractTip 的所有实例
    /// </summary>
    public static void Destroy_InteractTip()
    {
        var uiInstance = Get_InteractTip_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 InteractTip 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.InteractTip.InteractTipPanel[] Get_InteractTip_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.InteractTip.InteractTipPanel>(nameof(Game.Scripts.Ui.InteractTip.InteractTip));
    }

    /// <summary>
    /// 创建 InventoryUi, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.InventoryUi.InventoryUiPanel Create_InventoryUi()
    {
        return CreateUi<Game.Scripts.Ui.InventoryUi.InventoryUiPanel>(UiName.InventoryUi);
    }

    /// <summary>
    /// 打开 InventoryUi, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.InventoryUi.InventoryUiPanel Open_InventoryUi()
    {
        return OpenUi<Game.Scripts.Ui.InventoryUi.InventoryUiPanel>(UiName.InventoryUi);
    }

    /// <summary>
    /// 隐藏 InventoryUi 的所有实例
    /// </summary>
    public static void Hide_InventoryUi()
    {
        var uiInstance = Get_InventoryUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 InventoryUi 的所有实例
    /// </summary>
    public static void Destroy_InventoryUi()
    {
        var uiInstance = Get_InventoryUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 InventoryUi 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.InventoryUi.InventoryUiPanel[] Get_InventoryUi_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.InventoryUi.InventoryUiPanel>(nameof(Game.Scripts.Ui.InventoryUi.InventoryUi));
    }

    /// <summary>
    /// 创建 ItemCell, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.ItemCell.ItemCellPanel Create_ItemCell()
    {
        return CreateUi<Game.Scripts.Ui.ItemCell.ItemCellPanel>(UiName.ItemCell);
    }

    /// <summary>
    /// 打开 ItemCell, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.ItemCell.ItemCellPanel Open_ItemCell()
    {
        return OpenUi<Game.Scripts.Ui.ItemCell.ItemCellPanel>(UiName.ItemCell);
    }

    /// <summary>
    /// 隐藏 ItemCell 的所有实例
    /// </summary>
    public static void Hide_ItemCell()
    {
        var uiInstance = Get_ItemCell_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 ItemCell 的所有实例
    /// </summary>
    public static void Destroy_ItemCell()
    {
        var uiInstance = Get_ItemCell_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 ItemCell 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.ItemCell.ItemCellPanel[] Get_ItemCell_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.ItemCell.ItemCellPanel>(nameof(Game.Scripts.Ui.ItemCell.ItemCell));
    }

    /// <summary>
    /// 创建 ItemSlotUi, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel Create_ItemSlotUi()
    {
        return CreateUi<Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel>(UiName.ItemSlotUi);
    }

    /// <summary>
    /// 打开 ItemSlotUi, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel Open_ItemSlotUi()
    {
        return OpenUi<Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel>(UiName.ItemSlotUi);
    }

    /// <summary>
    /// 隐藏 ItemSlotUi 的所有实例
    /// </summary>
    public static void Hide_ItemSlotUi()
    {
        var uiInstance = Get_ItemSlotUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 ItemSlotUi 的所有实例
    /// </summary>
    public static void Destroy_ItemSlotUi()
    {
        var uiInstance = Get_ItemSlotUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 ItemSlotUi 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel[] Get_ItemSlotUi_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel>(nameof(Game.Scripts.Ui.ItemSlotUi.ItemSlotUi));
    }

    /// <summary>
    /// 创建 LoadingScreen, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.LoadingScreen.LoadingScreenPanel Create_LoadingScreen()
    {
        return CreateUi<Game.Scripts.Ui.LoadingScreen.LoadingScreenPanel>(UiName.LoadingScreen);
    }

    /// <summary>
    /// 打开 LoadingScreen, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.LoadingScreen.LoadingScreenPanel Open_LoadingScreen()
    {
        return OpenUi<Game.Scripts.Ui.LoadingScreen.LoadingScreenPanel>(UiName.LoadingScreen);
    }

    /// <summary>
    /// 隐藏 LoadingScreen 的所有实例
    /// </summary>
    public static void Hide_LoadingScreen()
    {
        var uiInstance = Get_LoadingScreen_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 LoadingScreen 的所有实例
    /// </summary>
    public static void Destroy_LoadingScreen()
    {
        var uiInstance = Get_LoadingScreen_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 LoadingScreen 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.LoadingScreen.LoadingScreenPanel[] Get_LoadingScreen_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.LoadingScreen.LoadingScreenPanel>(nameof(Game.Scripts.Ui.LoadingScreen.LoadingScreen));
    }

    /// <summary>
    /// 创建 Modal, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.Modal.ModalPanel Create_Modal()
    {
        return CreateUi<Game.Scripts.Ui.Modal.ModalPanel>(UiName.Modal);
    }

    /// <summary>
    /// 打开 Modal, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.Modal.ModalPanel Open_Modal()
    {
        return OpenUi<Game.Scripts.Ui.Modal.ModalPanel>(UiName.Modal);
    }

    /// <summary>
    /// 隐藏 Modal 的所有实例
    /// </summary>
    public static void Hide_Modal()
    {
        var uiInstance = Get_Modal_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 Modal 的所有实例
    /// </summary>
    public static void Destroy_Modal()
    {
        var uiInstance = Get_Modal_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 Modal 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.Modal.ModalPanel[] Get_Modal_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.Modal.ModalPanel>(nameof(Game.Scripts.Ui.Modal.Modal));
    }

    /// <summary>
    /// 创建 PauseMenu, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.PauseMenu.PauseMenuPanel Create_PauseMenu()
    {
        return CreateUi<Game.Scripts.Ui.PauseMenu.PauseMenuPanel>(UiName.PauseMenu);
    }

    /// <summary>
    /// 打开 PauseMenu, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.PauseMenu.PauseMenuPanel Open_PauseMenu()
    {
        return OpenUi<Game.Scripts.Ui.PauseMenu.PauseMenuPanel>(UiName.PauseMenu);
    }

    /// <summary>
    /// 隐藏 PauseMenu 的所有实例
    /// </summary>
    public static void Hide_PauseMenu()
    {
        var uiInstance = Get_PauseMenu_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 PauseMenu 的所有实例
    /// </summary>
    public static void Destroy_PauseMenu()
    {
        var uiInstance = Get_PauseMenu_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 PauseMenu 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.PauseMenu.PauseMenuPanel[] Get_PauseMenu_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.PauseMenu.PauseMenuPanel>(nameof(Game.Scripts.Ui.PauseMenu.PauseMenu));
    }

    /// <summary>
    /// 创建 Settings, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.Settings.SettingsPanel Create_Settings()
    {
        return CreateUi<Game.Scripts.Ui.Settings.SettingsPanel>(UiName.Settings);
    }

    /// <summary>
    /// 打开 Settings, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.Settings.SettingsPanel Open_Settings()
    {
        return OpenUi<Game.Scripts.Ui.Settings.SettingsPanel>(UiName.Settings);
    }

    /// <summary>
    /// 隐藏 Settings 的所有实例
    /// </summary>
    public static void Hide_Settings()
    {
        var uiInstance = Get_Settings_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 Settings 的所有实例
    /// </summary>
    public static void Destroy_Settings()
    {
        var uiInstance = Get_Settings_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 Settings 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.Settings.SettingsPanel[] Get_Settings_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.Settings.SettingsPanel>(nameof(Game.Scripts.Ui.Settings.Settings));
    }

    /// <summary>
    /// 创建 StartMenu, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static Game.Scripts.Ui.StartMenu.StartMenuPanel Create_StartMenu()
    {
        return CreateUi<Game.Scripts.Ui.StartMenu.StartMenuPanel>(UiName.StartMenu);
    }

    /// <summary>
    /// 打开 StartMenu, 并返回UI实例
    /// </summary>
    public static Game.Scripts.Ui.StartMenu.StartMenuPanel Open_StartMenu()
    {
        return OpenUi<Game.Scripts.Ui.StartMenu.StartMenuPanel>(UiName.StartMenu);
    }

    /// <summary>
    /// 隐藏 StartMenu 的所有实例
    /// </summary>
    public static void Hide_StartMenu()
    {
        var uiInstance = Get_StartMenu_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 StartMenu 的所有实例
    /// </summary>
    public static void Destroy_StartMenu()
    {
        var uiInstance = Get_StartMenu_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 StartMenu 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static Game.Scripts.Ui.StartMenu.StartMenuPanel[] Get_StartMenu_Instance()
    {
        return GetUiInstance<Game.Scripts.Ui.StartMenu.StartMenuPanel>(nameof(Game.Scripts.Ui.StartMenu.StartMenu));
    }

}
