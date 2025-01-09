using cfg.Items;

namespace RPGCore.Items;

public class UniqueItem : IItem
{
    protected string DisplayName;
    public string Name => DisplayName;
    public ItemTemplate Template { get; }
    
    public IItem Clone() => new UniqueItem(Template);

    public UniqueItem(ItemTemplate template)
    {
        Template = template;
        DisplayName = template.Name;
    }
}