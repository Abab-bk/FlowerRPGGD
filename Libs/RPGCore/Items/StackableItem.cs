using cfg.Items;

namespace RPGCore.Items;

public class StackableItem(ItemTemplate template, int quantity) : IItem
{
    public ItemTemplate Template { get; } = template;
    
    public int Quantity { get; set; } = quantity;
    public string Name => Template.Name;
    public void Add(int quantity) => Quantity += quantity;
    
    public StackableItem Take(int quantity)
    {
        if (quantity <= 0)
        {
            throw new InvalidOperationException(
                $"Can't take less than or equal to 0 items from a {nameof(StackableItem)} stack.");
        }

        if (quantity > Quantity)
        {
            throw new InvalidOperationException(
                $"Can't take more items from a {nameof(StackableItem)} than there are in the stack.");
        }

        if (quantity == Quantity)
        {
            throw new InvalidOperationException(
                $"Instead of taking the whole stack from a {nameof(StackableItem)}, move the whole {nameof(StackableItem)}.");
        }

        Quantity -= quantity;

        return new StackableItem(Template, quantity);
    }
    
    public IItem Clone()
    {
        return new StackableItem(Template, Quantity);
    }
}