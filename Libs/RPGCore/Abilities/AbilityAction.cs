namespace RPGCore.Abilities;

public class AbilityAction
{
    public AbilityActionType AbilityActionType { get; set; } = AbilityActionType.None;
    
    // == FireProjectile
    public string ProjectileName { get; set; } = "";
    public float MoveSpeed { get; set; }
    public float Rotation { get; set; }
    public float Damage { get; set; }
}