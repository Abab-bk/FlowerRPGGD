using Godot;

namespace Game.AnimationProcessors;

public class DefaultAnimationProcessor : IAnimationProcessor
{
    public SpriteFrames Process(string texturePath)
    {
        var spriteFrames = new SpriteFrames();
     
        var texture = ResourceLoader.Load<Texture2D>(texturePath);
        
        spriteFrames.AddAnimation("Idle");
        var atlas = new AtlasTexture
        {
            Atlas = texture,
            Region = new Rect2(0, 0, 64, 64)
        };
        spriteFrames.AddFrame("Idle", atlas);
        
        return spriteFrames;
    }
}