using cfg.Items;

namespace RPGCore.Items;

public class UniqueItem(ItemTemplate template) : IItem
{
    public string Name => Template.Name;
    public ItemTemplate Template { get; } = template;
    
    public IItem Clone() => new UniqueItem(Template);
}