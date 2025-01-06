using System.Collections.Generic;
using DataBase;
using Game.Scripts.Items;
using Game.Scripts.Mobs;
using Godot;
using ImGuiGodot;
using ImGuiNET;
using KaimiraGames;
using RPGCore.Items;
using RPGCore.Loots;

namespace Game.Scripts;

public partial class Debugger : Node
{
#if IMGUI
    private LootTable _allItemsLootTable;
    private string _addItemId = "i_sword1";
    private string _mobId = "m_slime_green";
    
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
            Global.PlayerInventory.AddItem(new UniqueItem(Data.Tables.TbItems.Get(_addItemId)));
        }

        if (ImGui.Button("Equip Weapon"))
        {
            Global.Player.Equipments.Weapon.Store(
                new UniqueItem(Data.Tables.TbItems.Get(_addItemId))
                );
        }
        
        ImGui.InputText("Mob Id", ref _mobId, 20);
        
        if (ImGui.Button("Spawn Mob"))
        {
            var mob = Mob.Create(Data.Tables.TbMobs.Get(_mobId));
            Global.World.AddChild(mob);
        }
        
        ImGui.End();
    }
#endif
}