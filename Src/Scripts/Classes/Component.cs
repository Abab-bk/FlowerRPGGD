namespace Game.Scripts.Classes;

public abstract class Component
{
    public virtual void Process(float delta)
    {
    }
    
    public virtual void PhysicsProcess(float delta)
    {
    }
}