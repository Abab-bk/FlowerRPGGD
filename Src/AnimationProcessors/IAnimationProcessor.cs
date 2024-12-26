using Godot;

namespace Game.AnimationProcessors;

public interface IAnimationProcessor
{
    public SpriteFrames Process(string texturePath);
}