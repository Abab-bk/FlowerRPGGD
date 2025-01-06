namespace RPGCore.Combat;

public class Attack(ICollection<Damage> damages)
{
    public ICollection<Damage> Damages { get; set; } = damages;
    
    public float Damage => Damages.Sum(d => d.Value);
}