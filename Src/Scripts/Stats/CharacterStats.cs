using cfg;
using cfg.Stats;
using FlowerRpg.Stats;

namespace Game.Scripts.Stats;

public class CharacterStats(StatsInfo info) : IStats
{
    public Vital
        Health { get; } = new Vital(
        new Stat(info.MaxHealth),
        0,
        0,
        true,
        1f
        );
    
    public IStat
        Speed { get; } = new Stat(info.Speed);
    
    public Vital GetVital(int statType)
    {
        switch ((VitalType)statType)
        {
            case VitalType.Health:
                return Health;
        }
        
        throw new System.NotImplementedException();
    }

    public IStat GetStat(int statType)
    {
        switch ((StatType)statType)
        {
            case StatType.Speed:
                return Speed;
            case StatType.MaxHealth:
                return Health.MaxValue;
        }
        
        throw new System.NotImplementedException();
    }
}