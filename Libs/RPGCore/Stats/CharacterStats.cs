using cfg;
using cfg.Stats;
using FlowerRpg.Stats;

namespace RPGCore.Stats;

public class CharacterStats(StatsInfo info) : IStats
{
    public Vital Health { get; } = new Vital(
        new Stat(info.MaxHealth),
        0,
        0,
        true,
        1f
    );
    public IStat Speed { get; } = new Stat(info.Speed);
    
    public Vital GetVital(int statType)
    {
        switch ((StatType)statType)
        {
            case StatType.MaxHealth:
                return Health;
        }
        
        throw new NotImplementedException();
    }

    public IStat GetStat(int statType)
    {
        switch ((StatType)statType)
        {
            case StatType.MovementSpeed:
                return Speed;
            case StatType.MaxHealth:
                return Health.MaxValue;
        }
        
        throw new NotImplementedException();
    }
}