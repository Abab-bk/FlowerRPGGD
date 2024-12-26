using System;
using Godot;

namespace Game.Scripts;

public partial class TickSystem : Node
{
    public static event Action<int>
        OnTick,
        OnTick5;

    private const float TickTimerMax = 0.2f;
    
    private float _tickTimer;
    private static int _tick;

    public static void ForceTick(int tick = 1)
    {
        for (int i = 0; i < tick; i++)
        {
            _tick++;
            OnTick?.Invoke(_tick);
        }
    }

    public override void _Process(double delta)
    {
        _tickTimer += (float)delta;
        if (_tickTimer < TickTimerMax) return;
        
        _tickTimer -= TickTimerMax;
        _tick++;
        OnTick?.Invoke(_tick);
        
        if (_tick % 5 == 0)
        {
            OnTick5?.Invoke(_tick);
        }
    }
}