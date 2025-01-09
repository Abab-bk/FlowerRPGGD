
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
public partial class TbAmuletAffixes
{
    private readonly System.Collections.Generic.Dictionary<string, Items.AffixTemplate> _dataMap;
    private readonly System.Collections.Generic.List<Items.AffixTemplate> _dataList;
    
    public TbAmuletAffixes(JsonElement _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<string, Items.AffixTemplate>();
        _dataList = new System.Collections.Generic.List<Items.AffixTemplate>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            Items.AffixTemplate _v;
            _v = Items.AffixTemplate.DeserializeAffixTemplate(_ele);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<string, Items.AffixTemplate> DataMap => _dataMap;
    public System.Collections.Generic.List<Items.AffixTemplate> DataList => _dataList;

    public Items.AffixTemplate GetOrDefault(string key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Items.AffixTemplate Get(string key) => _dataMap[key];
    public Items.AffixTemplate this[string key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

