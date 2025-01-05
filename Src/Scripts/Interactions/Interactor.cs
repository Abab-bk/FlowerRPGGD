using Godot;

namespace Game.Scripts.Interactions;

public partial class Interactor(
    InteractionType interactionType,
    string interactContent,
    Shape2D collisionShape
    ) : Area2D, IInteractable
{
    public InteractionType InteractionType => interactionType;

    public override void _Ready()
    {
        CollisionLayer = 0;
        CollisionMask = 0;
        
        SetCollisionLayerValue((int)Enums.CollisionLayer.Interaction, true);
        
        AddChild(new CollisionShape2D
        {
            Shape = collisionShape
        });
    }

    public void Interact()
    {
        switch (InteractionType)
        {
            case InteractionType.Dialogue:
                Logger.Log("[Interactor] InteractionType.Dialogue");
                break;
        }
    }
}