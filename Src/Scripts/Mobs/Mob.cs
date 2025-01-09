using cfg;
using cfg.Stats;
using Game.Scripts.Base;
using Game.Scripts.Prefabs;
using Godot;
using RPGCore.Combat;

namespace Game.Scripts.Mobs;

public partial class Mob : CharacterEntity
{
    [Export] protected HurtBox HurtBox { get; set; }
    [Export] protected AnimationPlayer Animation2 { get; set; }
    
    protected MobAi Ai { get; set; }
    
    public override void _Ready()
    {
        base._Ready();
        
        HurtBox.OnHurt += OnHurt;
        
        Ai = GetNode<MobAi>("MobAi");
        Ai.Init(StateMachine, this);

        Stats.GetVital(VitalType.Health).OnValueToMin += Die;
    }

    protected virtual void Die()
    {
        QueueFree();
    }

    protected virtual void OnHurt(Attack attack)
    {
        Animation2.Play("OnHurt");
        Stats.GetVital(VitalType.Health).Decrease(attack.Damage);
    }

    public void MoveToPlayer()
    {
        Velocity = Velocity with { X = (GlobalPosition.DirectionTo(Global.Player.GlobalPosition) *
                                      Stats.GetStat(StatType.MovementSpeed).Value).X };
    }

    public static Mob Create(CharacterInfo characterInfo)
    {
        var mob = GD.Load<PackedScene>($"res://Scenes/Mobs/{characterInfo.SceneName}.tscn")
            .Instantiate<Mob>();
        mob.CharacterInfo = characterInfo;
        return mob;
    }
}
