using cfg.Items;

namespace Game.Scripts.Items;

public class Item(ItemTemplate itemTemplate)
{
    public string Name => itemTemplate.Name;
    public ItemTemplate Template => itemTemplate;
}