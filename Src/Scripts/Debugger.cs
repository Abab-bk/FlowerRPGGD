using System.Collections.Generic;
using DataBase;
using Game.Scripts.Items;
using Game.Scripts.Loots;
using Godot;
using ImGuiGodot;
using ImGuiNET;
using KaimiraGames;

namespace Game.Scripts;

public partial class Debugger : Node
{
#if IMGUI
    private LootTable _allItemsLootTable;
    
    public override void _Ready()
    {
        ImGuiGD.Connect(OnImGuiLayout);

        var allItems = new List<WeightedListItem<string>>();
        
        foreach (var itemTemplate in Data.Tables.TbItems.DataList)
        {
            allItems.Add(new WeightedListItem<string>(itemTemplate.Id, 1));
        }

        _allItemsLootTable = new LootTable(allItems);
    }
    
    private void OnImGuiLayout()
    {
        ImGui.Begin("Debugger");
        ImGui.Text($"Paused: {Global.IsPaused}");

        if (ImGui.Button("Drop Item"))
        {
            var item = ItemGenerator.GetItem(_allItemsLootTable, null);
            var entity = ItemDropEntity.Create(item);
            Global.World.AddChild(entity);
        }

        ImGui.End();
    }
#endif
}