using System;
using Godot;
using RPGCore.Items;

namespace Game.Scripts;

public static class EventBus
{
    public static Action
        PlayerReady = delegate { },
        RequestBackToStartMenu = delegate { },
        RequestSaveAppSaver = delegate { },
        RequestSaveGameSave = delegate { },
        RequestStartGame = delegate { },
        RequestQuitGame = delegate { };
    public static Action<int> PauseCountChanged = delegate { };
    public static Action<IItem, Vector2> ItemTooltipRequested = delegate { };
    public static Action ItemTooltipCanceled = delegate { };
}