
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg.Items
{
public sealed partial class ItemTemplate : Luban.BeanBase
{
    public ItemTemplate(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetString();
        Name = _buf.GetProperty("name").GetString();
        ItemType = (Items.ItemType)_buf.GetProperty("item_type").GetInt32();
        Value = _buf.GetProperty("value").GetSingle();
        Rarity = (Items.Rarity)_buf.GetProperty("rarity").GetInt32();
    }

    public static ItemTemplate DeserializeItemTemplate(JsonElement _buf)
    {
        return new Items.ItemTemplate(_buf);
    }

    /// <summary>
    /// id
    /// </summary>
    public readonly string Id;
    /// <summary>
    /// name
    /// </summary>
    public readonly string Name;
    /// <summary>
    /// itemType
    /// </summary>
    public readonly Items.ItemType ItemType;
    /// <summary>
    /// 伤害|防御
    /// </summary>
    public readonly float Value;
    /// <summary>
    /// 稀有度
    /// </summary>
    public readonly Items.Rarity Rarity;
   
    public const int __ID__ = 238212187;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "name:" + Name + ","
        + "itemType:" + ItemType + ","
        + "value:" + Value + ","
        + "rarity:" + Rarity + ","
        + "}";
    }
}

}
