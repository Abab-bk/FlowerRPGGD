using Godot;

namespace Game.Scripts.Mobs;

[GlobalClass]
public partial class MobAi : Node
{
    protected HFSM StateMachine { get; private set; }
    protected Mob Mob { get; private set; }
    
    public void Init(HFSM stateMachine, Mob mob)
    {
        StateMachine = stateMachine;
        Mob = mob;
        
        StateMachine.PhysicUpdated += OnPhysicUpdated;
        StateMachine.Transited += OnTransited;
        StateMachine.Entered += OnEntered;
        StateMachine.Exited += OnExited;
    }
    
    protected virtual void OnPhysicUpdated(State state, float delta) { }
    protected virtual void OnTransited(State from, State to) { }
    protected virtual void OnEntered(State state) { }
    protected virtual void OnExited(State state) { }
}