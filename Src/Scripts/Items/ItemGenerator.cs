using DataBase;
using Game.Scripts.Loots;
using Game.Scripts.Stats;

namespace Game.Scripts.Items;

public static class ItemGenerator
{
    public static Item GetItem(
        LootTable lootTable,
        CharacterStats stats
        )
    {
        var itemId = lootTable.GetItem();
        var item = new Item(Data.Tables.TbItems.Get(itemId));
        return item;
    }
}