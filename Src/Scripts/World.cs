using AcidUtilities;
using DataBase;
using DsUi;
using Game.Scripts.Players;
using Godot;
using Server;
using SuperSimpleTcp;

namespace Game.Scripts;

public partial class World : Node2D
{
    public override void _Ready()
    {
        Global.World = this;
        UiManager.Open_Hud();

        AddChild(new TickSystem());
        
        var saveData = Global.AppSaver.GameSave;
        
        // spawn player
        var player = Player.Create(Data.Tables.TbCharacters.Get("c_player"));
        AddChild(player);
        player.RSetGlobalPosition(new Vector2(100f, 100f));
        
        // TODO: test, need to be removed
        RunServer();
        
        Logger.Log("[World] Ready");
    }

    private void RunServer()
    {
        Global.ServerApp = new ServerApp("127.0.0.1", 9000, Logger.GetLogger());
        Global.ServerApp.Run();
        
        Global.Client = new SimpleTcpClient("127.0.0.1:9000");
        Global.Client.Connect();
    }

    public void Destroy()
    {
        Global.World = null;
        UiManager.Destroy_Hud();
        
        Global.AppSaver.UnloadGameSave();
        
        Logger.Log("[World] Destroy");
        QueueFree();
    }
}