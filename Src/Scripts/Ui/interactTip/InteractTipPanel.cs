using Game.Scripts.Interactions;
using Godot;

namespace Game.Scripts.Ui.InteractTip;

public partial class InteractTipPanel : InteractTip
{
    public IInteractable Interactable { get; private set; }

    public override void _Ready()
    {
        switch (Interactable.InteractionType)
        {
            case InteractionType.Dialogue:
                S_Label.Instance.Text = "Press E to interact";
                break;
        }
    }

    public static InteractTipPanel Create(IInteractable interactable)
    {
        var panel = GD
            .Load<PackedScene>("res://Scenes/Ui/InteractTip.tscn")
            .Instantiate<InteractTipPanel>();
        return panel.Config(interactable);
    }

    public InteractTipPanel Config(IInteractable interactable)
    {
        Interactable = interactable;
        return this;
    }
}
