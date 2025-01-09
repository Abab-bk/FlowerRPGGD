using cfg;
using cfg.Stats;
using DataBase;
using FastEnumUtility;
using FlowerRpg.Stats;
using FlowerRpg.Stats.Modifiers;
using ModifierType = FlowerRpg.Stats.Modifiers.ModifierType;

namespace RPGCore.Stats;

public class CharacterStats : IStats
{
    private IStat[] Stats { get; set; }
    private Vital[] Vitals { get; set; }
    public int Level { get; set; }
    
    public CharacterStats(StatsInfo info)
    {
        Stats = new IStat[FastEnum.GetValues<StatType>().Length];
        Vitals = new Vital[FastEnum.GetValues<VitalType>().Length];

        var maxHealth = new Stat(100f);
        var maxMana = new Stat(100f);
        var movementSpeed = new Stat(300f);
        
        foreach (var statType in FastEnum.GetValues<StatType>())
        {
            if (Data.Constants.CoreStats.Contains(statType))
            {
                Stats[(int)statType] = statType switch
                {
                    StatType.Strength => new Stat(info.Strength),
                    StatType.Intelligence => new Stat(info.Intelligence),
                    StatType.Willpower => new Stat(info.Willpower),
                    StatType.Dexterity => new Stat(info.Dexterity),
                    _ => throw new ArgumentOutOfRangeException()
                };
                continue;
            }

            if (statType == StatType.MaxHealth ||
                statType == StatType.MaxMana ||
                statType == StatType.MovementSpeed
                )
            {
                Stats[(int)statType] = statType switch
                {
                    StatType.MaxHealth => maxHealth,
                    StatType.MaxMana => maxMana,
                    StatType.MovementSpeed => movementSpeed,
                    _ => throw new ArgumentOutOfRangeException()
                };
                continue;
            }

            Stats[(int)statType] = new Stat(0f);
        }
        
        foreach (var vitalType in FastEnum.GetValues<VitalType>())
        {
            Vitals[(int)vitalType] = vitalType switch
            {
                VitalType.Health => new Vital(maxHealth, 0f, 0f, true, 1f),
                VitalType.Mana => new Vital(maxMana, 0f, 0f, true, 1f),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
        
        CleanModifiers();
        CalculateModifiers();
    }
    
    private void CleanModifiers()
    {
        GetStat(StatType.Armor).RemoveAllModifiersFromSource(this);
        GetStat(StatType.FireResistance).RemoveAllModifiersFromSource(this);
        GetStat(StatType.ColdResistance).RemoveAllModifiersFromSource(this);
        GetStat(StatType.LightningResistance).RemoveAllModifiersFromSource(this);
        GetStat(StatType.PhysicalResistance).RemoveAllModifiersFromSource(this);
        GetStat(StatType.HealingReceived).RemoveAllModifiersFromSource(this);
        GetStat(StatType.OverPowerDamage).RemoveAllModifiersFromSource(this);
        GetStat(StatType.DodgeChance).RemoveAllModifiersFromSource(this);
    }
    private void CalculateModifiers()
    {
        var armorBonus = GetStat(StatType.Strength).Value * 0.2f; // Flat
        var allResistanceBonus = GetStat(StatType.Intelligence).Value * 0.02f; // PercentAdd
        
        var healingReceivedBonus = GetStat(StatType.Willpower).Value * 0.075f; // PercentAdd
        var overPowerBonus = GetStat(StatType.Willpower).Value * 0.25f; // PercentAdd

        var dodgeChanceBonus = GetStat(StatType.Dexterity).Value * 0.006f; // PercentAdd

        var armorModifier = new Modifier(armorBonus, ModifierType.Flat, this);
        var allResistanceModifier = new Modifier(allResistanceBonus, ModifierType.PercentAdd, this);
        
        var healingReceivedModifier = new Modifier(healingReceivedBonus, ModifierType.PercentAdd, this);
        var overPowerModifier = new Modifier(overPowerBonus, ModifierType.PercentAdd, this);
        
        var dodgeChanceModifier = new Modifier(dodgeChanceBonus, ModifierType.PercentAdd, this);

        GetStat(StatType.Armor).AddModifier(armorModifier);
        
        GetStat(StatType.ColdResistance).AddModifier(allResistanceModifier);
        GetStat(StatType.FireResistance).AddModifier(allResistanceModifier);
        GetStat(StatType.LightningResistance).AddModifier(allResistanceModifier);
        GetStat(StatType.PhysicalResistance).AddModifier(allResistanceModifier);
        
        GetStat(StatType.HealingReceived).AddModifier(healingReceivedModifier);
        GetStat(StatType.OverPowerDamage).AddModifier(overPowerModifier);
        
        GetStat(StatType.DodgeChance).AddModifier(dodgeChanceModifier);
    }

    public void LevelUp()
    {
        Level += 1;

        foreach (var statType in FastEnum.GetValues<StatType>())
        {
            if (!Data.Constants.CoreStats.Contains(statType)) continue;
            Stats[(int)statType].SetBaseValue(Stats[(int)statType].BaseValue + 1);
        }
        
        CleanModifiers();
        CalculateModifiers();
    }

    public Vital GetVital(int statType) => Vitals[statType];
    public IStat GetStat(int statType) => Stats[statType];
    
    public Vital GetVital(VitalType vitalType) => Vitals[(int)vitalType];
    public IStat GetStat(StatType statType) => Stats[(int)statType];
}