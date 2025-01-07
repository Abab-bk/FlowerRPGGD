namespace Game.Scripts.Ui.AbilityButton;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class AbilityButton : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: AbilityButton.PanelContainer
    /// </summary>
    public PanelContainer L_PanelContainer
    {
        get
        {
            if (_L_PanelContainer == null) _L_PanelContainer = new PanelContainer((AbilityButtonPanel)this, GetNode<Godot.PanelContainer>("PanelContainer"));
            return _L_PanelContainer;
        }
    }
    private PanelContainer _L_PanelContainer;

    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureProgressBar"/>, 节点路径: AbilityButton.CooldownProgress
    /// </summary>
    public CooldownProgress L_CooldownProgress
    {
        get
        {
            if (_L_CooldownProgress == null) _L_CooldownProgress = new CooldownProgress((AbilityButtonPanel)this, GetNode<Godot.TextureProgressBar>("CooldownProgress"));
            return _L_CooldownProgress;
        }
    }
    private CooldownProgress _L_CooldownProgress;


    public AbilityButton() : base(nameof(AbilityButton))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureRect"/>, 路径: AbilityButton.PanelContainer.Icon
    /// </summary>
    public class Icon : UiNode<AbilityButtonPanel, Godot.TextureRect, Icon>
    {
        public Icon(AbilityButtonPanel uiPanel, Godot.TextureRect node) : base(uiPanel, node) {  }
        public override Icon Clone() => new (UiPanel, (Godot.TextureRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: AbilityButton.PanelContainer.KeyLabel
    /// </summary>
    public class KeyLabel : UiNode<AbilityButtonPanel, Godot.Label, KeyLabel>
    {
        public KeyLabel(AbilityButtonPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override KeyLabel Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: AbilityButton.PanelContainer
    /// </summary>
    public class PanelContainer : UiNode<AbilityButtonPanel, Godot.PanelContainer, PanelContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: AbilityButton.Icon
        /// </summary>
        public Icon L_Icon
        {
            get
            {
                if (_L_Icon == null) _L_Icon = new Icon(UiPanel, Instance.GetNode<Godot.TextureRect>("Icon"));
                return _L_Icon;
            }
        }
        private Icon _L_Icon;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: AbilityButton.KeyLabel
        /// </summary>
        public KeyLabel L_KeyLabel
        {
            get
            {
                if (_L_KeyLabel == null) _L_KeyLabel = new KeyLabel(UiPanel, Instance.GetNode<Godot.Label>("KeyLabel"));
                return _L_KeyLabel;
            }
        }
        private KeyLabel _L_KeyLabel;

        public PanelContainer(AbilityButtonPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override PanelContainer Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureProgressBar"/>, 路径: AbilityButton.CooldownProgress
    /// </summary>
    public class CooldownProgress : UiNode<AbilityButtonPanel, Godot.TextureProgressBar, CooldownProgress>
    {
        public CooldownProgress(AbilityButtonPanel uiPanel, Godot.TextureProgressBar node) : base(uiPanel, node) {  }
        public override CooldownProgress Clone() => new (UiPanel, (Godot.TextureProgressBar)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: AbilityButton.PanelContainer.Icon
    /// </summary>
    public Icon S_Icon => L_PanelContainer.L_Icon;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: AbilityButton.PanelContainer.KeyLabel
    /// </summary>
    public KeyLabel S_KeyLabel => L_PanelContainer.L_KeyLabel;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: AbilityButton.PanelContainer
    /// </summary>
    public PanelContainer S_PanelContainer => L_PanelContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureProgressBar"/>, 节点路径: AbilityButton.CooldownProgress
    /// </summary>
    public CooldownProgress S_CooldownProgress => L_CooldownProgress;

}
