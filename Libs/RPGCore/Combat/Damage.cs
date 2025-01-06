namespace RPGCore.Combat;

public class Damage(DamageType type, float value)
{
    public DamageType Type { get; set; } = type;
    public float Value { get; set; } = value;
}