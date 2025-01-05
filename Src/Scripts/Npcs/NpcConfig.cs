using cfg.Characters;
using Game.Scripts.Maps;

namespace Game.Scripts.Npcs;

public class NpcConfig(SignNode signNode, CharacterInfo characterInfo)
{
    public SignNode SignNode => signNode;
    public CharacterInfo CharacterInfo => characterInfo;
}