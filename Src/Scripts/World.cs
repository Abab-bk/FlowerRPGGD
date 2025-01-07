using DataBase;
using DsUi;
using Game.Scripts.Maps;
using Godot;
using RPGCore.Abilities;

namespace Game.Scripts;

public partial class World : Node2D
{
    public override void _Ready()
    {
        Global.World = this;
        UiManager.Open_Hud();

        AddChild(new TickSystem());
        
        var saveData = Global.AppSaver.GameSave;
        
        var level = Data.Tables.TbMaps.Get("map_test");
        var mapNode = GD.Load<PackedScene>
            ($"res://Scenes/Maps/{level.SceneName}.tscn").Instantiate<Map>();
        AddChild(mapNode);
        mapNode.Init();
        
        AbilityProcessor.Init(new GAbilityProcessor());
        
        Logger.Log("[World] Ready");
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