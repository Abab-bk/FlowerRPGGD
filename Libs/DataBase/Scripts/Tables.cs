
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
public partial class Tables
{
    public TbConstants TbConstants {get; }
    public Characters.TbCharacters TbCharacters {get; }

    public Tables(System.Func<string, JsonElement> loader)
    {
        TbConstants = new TbConstants(loader("tbconstants"));
        TbCharacters = new Characters.TbCharacters(loader("characters_tbcharacters"));
        ResolveRef();
    }
    
    private void ResolveRef()
    {
        TbConstants.ResolveRef(this);
        TbCharacters.ResolveRef(this);
    }
}

}
