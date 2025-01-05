using System.Collections.Generic;
using KaimiraGames;

namespace Game.Scripts.Loots;

public class LootTable(List<WeightedListItem<string>> items)
{
    private WeightedList<string> ItemIds { get; set; } = new (items);
    
    public string GetItem() => ItemIds.Next();
}