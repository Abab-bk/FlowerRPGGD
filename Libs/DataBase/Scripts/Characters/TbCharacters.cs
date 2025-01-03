
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg.Characters
{
public partial class TbCharacters
{
    private readonly System.Collections.Generic.Dictionary<string, Characters.CharacterInfo> _dataMap;
    private readonly System.Collections.Generic.List<Characters.CharacterInfo> _dataList;
    
    public TbCharacters(JsonElement _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<string, Characters.CharacterInfo>();
        _dataList = new System.Collections.Generic.List<Characters.CharacterInfo>();
        
        foreach(JsonElement _ele in _buf.EnumerateArray())
        {
            Characters.CharacterInfo _v;
            _v = Characters.CharacterInfo.DeserializeCharacterInfo(_ele);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<string, Characters.CharacterInfo> DataMap => _dataMap;
    public System.Collections.Generic.List<Characters.CharacterInfo> DataList => _dataList;

    public Characters.CharacterInfo GetOrDefault(string key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Characters.CharacterInfo Get(string key) => _dataMap[key];
    public Characters.CharacterInfo this[string key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

