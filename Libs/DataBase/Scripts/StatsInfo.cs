
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg
{
public sealed partial class StatsInfo : Luban.BeanBase
{
    public StatsInfo(JsonElement _buf) 
    {
        Strength = _buf.GetProperty("Strength").GetSingle();
        Intelligence = _buf.GetProperty("Intelligence").GetSingle();
        Willpower = _buf.GetProperty("Willpower").GetSingle();
        Dexterity = _buf.GetProperty("Dexterity").GetSingle();
    }

    public static StatsInfo DeserializeStatsInfo(JsonElement _buf)
    {
        return new StatsInfo(_buf);
    }

    public readonly float Strength;
    public readonly float Intelligence;
    public readonly float Willpower;
    public readonly float Dexterity;
   
    public const int __ID__ = -69315123;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Strength:" + Strength + ","
        + "Intelligence:" + Intelligence + ","
        + "Willpower:" + Willpower + ","
        + "Dexterity:" + Dexterity + ","
        + "}";
    }
}

}

