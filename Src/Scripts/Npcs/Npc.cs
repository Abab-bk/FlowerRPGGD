using Godot;
using Game.Scripts.Base;
using Game.Scripts.Interactions;

namespace Game.Scripts.Npcs;

public partial class Npc : CharacterEntity
{
    private NpcConfig _npcConfig;
    
    public override void _Ready()
    {
        CharacterInfo = _npcConfig.CharacterInfo;

        base._Ready();
        
        var signNode = _npcConfig.SignNode;
        
        if (signNode == null || signNode.InteractionType == InteractionType.None) return;

        var interactor = new Interactor(
            signNode.InteractionType,
            signNode.InteractionContent,
            CollisionShape2D.Shape
            );
        AddChild(interactor);
    }

    public static Npc Create(NpcConfig npcConfig)
    {
        var npc = GD.Load<PackedScene>("res://Scenes/Base/Npc.tscn")
            .Instantiate<Npc>();
        npc._npcConfig = npcConfig;
        return npc;
    }
}
