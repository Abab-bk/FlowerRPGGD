using DataBase;
using RPGCore.Loots;
using RPGCore.Stats;

namespace RPGCore.Items;

public static class ItemGenerator
{
    public static IItem GetItem(
        LootTable lootTable,
        CharacterStats stats
    )
    {
        var itemId = lootTable.GetItem();
        var item = new UniqueItem(Data.Tables.TbItems.Get(itemId));
        return item;
    }
}