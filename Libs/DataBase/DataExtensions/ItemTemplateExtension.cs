using cfg.Items;

namespace DataBase.DataExtensions;

public static class ItemTemplateExtension
{
    public static bool IsWeapon(this ItemTemplate itemTemplate) =>
        itemTemplate.ItemType == ItemType.Sword;
    
    public static string GetIconPath(this ItemTemplate itemTemplate) =>
        $"res://Assets/ItemIcons/{itemTemplate.IconName}.png";
}