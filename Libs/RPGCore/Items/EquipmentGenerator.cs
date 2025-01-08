using DataBase;
using RPGCore.Items.Affixes;
using RPGCore.Stats;
using Shared;

namespace RPGCore.Items;

public static class EquipmentGenerator
{
    public static IItem GetItem(CharacterStats stats)
    {
        var equipmentTemplate = Data.Tables.TbEquipment.DataList.PickRandom();

        var affixes = new List<Affix>();
        
        foreach (var affixId in equipmentTemplate.Affixes)
        {
            if (affixId == null) continue;
            affixes.Add(new Affix(Data.Tables.TbAffixes.Get(affixId), stats));
        }
        
        var equipment = new Equipment(equipmentTemplate, affixes);
        
        return equipment;
    }
}