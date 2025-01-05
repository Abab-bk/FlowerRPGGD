namespace Game.Scripts.Interactions;

public interface IInteractable
{
    public InteractionType InteractionType { get; }
    public void Interact();
}