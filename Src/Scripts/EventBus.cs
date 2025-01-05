using System;

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
}