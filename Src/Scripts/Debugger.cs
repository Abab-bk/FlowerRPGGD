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
    private string _addItemId = "";
    
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

        ImGui.InputText("Add Item Id", ref _addItemId, 20);
        
        if (ImGui.Button("Add Item"))
        {
            Global.PlayerInventory.AddItem(new Item(Data.Tables.TbItems.Get(_addItemId)));
        }

        ImGui.End();
    }
#endif
}