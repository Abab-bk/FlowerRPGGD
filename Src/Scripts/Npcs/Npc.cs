using Godot;
using cfg.Characters;
using Game.Scripts.Base;

namespace Game.Scripts.Npcs;

public partial class Npc : CharacterEntity
{
    public static Npc Create(CharacterInfo characterInfo)
    {
        var npc = GD.Load<PackedScene>("res://Scenes/Base/Npc.tscn")
            .Instantiate<Npc>();
        npc.CharacterInfo = characterInfo;
        return npc;
    }
}
