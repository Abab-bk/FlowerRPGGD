using DataBase;
using Game.Scripts.Npcs;
using Game.Scripts.Players;
using Godot;

namespace Game.Scripts.Maps;

public partial class Map : Node2D
{
    [Export] private TileMapLayer _tileMapLayer;
    [Export] private Node2D _signs;

    public void Init()
    {
        foreach (var sign in _signs.GetChildren())
        {
            if (sign is not SignNode signNode) continue;
            switch (signNode.SignType)
            {
                case SignType.Npc:
                    var npc = Npc.Create(Data.Tables.TbCharacters.Get(signNode.Content));
                    AddChild(npc);
                    npc.GlobalPosition = signNode.GlobalPosition;
                    continue;
                case SignType.PlayerStartPos:
                    var player = Player.Create(Data.Tables.TbCharacters.Get("c_player"));
                    AddChild(player);
                    player.GlobalPosition = signNode.GlobalPosition;

                    var playerController = new PlayerController(player);
                    player.AddChild(playerController);
                    
                    continue;
            }
        }
    }
}