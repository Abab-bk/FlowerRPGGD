using cfg.Items;

namespace RPGCore.Items;

public interface IItem
{
    public ItemTemplate Template { get; }
    public string Name { get; }
    public IItem Clone();
}