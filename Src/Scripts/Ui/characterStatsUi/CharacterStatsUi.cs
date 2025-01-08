namespace Game.Scripts.Ui.CharacterStatsUi;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class CharacterStatsUi : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: CharacterStatsUi.PanelContainer
    /// </summary>
    public PanelContainer L_PanelContainer
    {
        get
        {
            if (_L_PanelContainer == null) _L_PanelContainer = new PanelContainer((CharacterStatsUiPanel)this, GetNode<Godot.PanelContainer>("PanelContainer"));
            return _L_PanelContainer;
        }
    }
    private PanelContainer _L_PanelContainer;


    public CharacterStatsUi() : base(nameof(CharacterStatsUi))
    {
    }

    public sealed override void OnInitNestedUi()
    {

        var inst1 = L_PanelContainer.L_VBoxContainer;
        RecordNestedUi(inst1.L_MaxHealth.Instance, inst1, UiManager.RecordType.Open);
        inst1.L_MaxHealth.Instance.OnCreateUi();
        inst1.L_MaxHealth.Instance.OnInitNestedUi();

        var inst2 = L_PanelContainer.L_VBoxContainer;
        RecordNestedUi(inst2.L_Speed.Instance, inst2, UiManager.RecordType.Open);
        inst2.L_Speed.Instance.OnCreateUi();
        inst2.L_Speed.Instance.OnInitNestedUi();

    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.StatItemUi.StatItemUiPanel"/>, 路径: CharacterStatsUi.PanelContainer.VBoxContainer.MaxHealth
    /// </summary>
    public class MaxHealth : UiNode<CharacterStatsUiPanel, Game.Scripts.Ui.StatItemUi.StatItemUiPanel, MaxHealth>
    {
        public MaxHealth(CharacterStatsUiPanel uiPanel, Game.Scripts.Ui.StatItemUi.StatItemUiPanel node) : base(uiPanel, node) {  }
        public override MaxHealth Clone()
        {
            var uiNode = new MaxHealth(UiPanel, (Game.Scripts.Ui.StatItemUi.StatItemUiPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.StatItemUi.StatItemUiPanel"/>, 路径: CharacterStatsUi.PanelContainer.VBoxContainer.Speed
    /// </summary>
    public class Speed : UiNode<CharacterStatsUiPanel, Game.Scripts.Ui.StatItemUi.StatItemUiPanel, Speed>
    {
        public Speed(CharacterStatsUiPanel uiPanel, Game.Scripts.Ui.StatItemUi.StatItemUiPanel node) : base(uiPanel, node) {  }
        public override Speed Clone()
        {
            var uiNode = new Speed(UiPanel, (Game.Scripts.Ui.StatItemUi.StatItemUiPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: CharacterStatsUi.PanelContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<CharacterStatsUiPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.StatItemUi.StatItemUiPanel"/>, 节点路径: CharacterStatsUi.PanelContainer.MaxHealth
        /// </summary>
        public MaxHealth L_MaxHealth
        {
            get
            {
                if (_L_MaxHealth == null) _L_MaxHealth = new MaxHealth(UiPanel, Instance.GetNode<Game.Scripts.Ui.StatItemUi.StatItemUiPanel>("MaxHealth"));
                return _L_MaxHealth;
            }
        }
        private MaxHealth _L_MaxHealth;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.StatItemUi.StatItemUiPanel"/>, 节点路径: CharacterStatsUi.PanelContainer.Speed
        /// </summary>
        public Speed L_Speed
        {
            get
            {
                if (_L_Speed == null) _L_Speed = new Speed(UiPanel, Instance.GetNode<Game.Scripts.Ui.StatItemUi.StatItemUiPanel>("Speed"));
                return _L_Speed;
            }
        }
        private Speed _L_Speed;

        public VBoxContainer(CharacterStatsUiPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: CharacterStatsUi.PanelContainer.HBoxContainer.VBoxContainer2
    /// </summary>
    public class VBoxContainer2 : UiNode<CharacterStatsUiPanel, Godot.VBoxContainer, VBoxContainer2>
    {
        public VBoxContainer2(CharacterStatsUiPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer2 Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: CharacterStatsUi.PanelContainer.HBoxContainer
    /// </summary>
    public class HBoxContainer : UiNode<CharacterStatsUiPanel, Godot.HBoxContainer, HBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: CharacterStatsUi.PanelContainer.VBoxContainer2
        /// </summary>
        public VBoxContainer2 L_VBoxContainer2
        {
            get
            {
                if (_L_VBoxContainer2 == null) _L_VBoxContainer2 = new VBoxContainer2(UiPanel, Instance.GetNode<Godot.VBoxContainer>("VBoxContainer2"));
                return _L_VBoxContainer2;
            }
        }
        private VBoxContainer2 _L_VBoxContainer2;

        public HBoxContainer(CharacterStatsUiPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: CharacterStatsUi.PanelContainer
    /// </summary>
    public class PanelContainer : UiNode<CharacterStatsUiPanel, Godot.PanelContainer, PanelContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: CharacterStatsUi.VBoxContainer
        /// </summary>
        public VBoxContainer L_VBoxContainer
        {
            get
            {
                if (_L_VBoxContainer == null) _L_VBoxContainer = new VBoxContainer(UiPanel, Instance.GetNode<Godot.VBoxContainer>("VBoxContainer"));
                return _L_VBoxContainer;
            }
        }
        private VBoxContainer _L_VBoxContainer;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: CharacterStatsUi.HBoxContainer
        /// </summary>
        public HBoxContainer L_HBoxContainer
        {
            get
            {
                if (_L_HBoxContainer == null) _L_HBoxContainer = new HBoxContainer(UiPanel, Instance.GetNode<Godot.HBoxContainer>("HBoxContainer"));
                return _L_HBoxContainer;
            }
        }
        private HBoxContainer _L_HBoxContainer;

        public PanelContainer(CharacterStatsUiPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override PanelContainer Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.StatItemUi.StatItemUiPanel"/>, 节点路径: CharacterStatsUi.PanelContainer.VBoxContainer.MaxHealth
    /// </summary>
    public MaxHealth S_MaxHealth => L_PanelContainer.L_VBoxContainer.L_MaxHealth;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.StatItemUi.StatItemUiPanel"/>, 节点路径: CharacterStatsUi.PanelContainer.VBoxContainer.Speed
    /// </summary>
    public Speed S_Speed => L_PanelContainer.L_VBoxContainer.L_Speed;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: CharacterStatsUi.PanelContainer.VBoxContainer
    /// </summary>
    public VBoxContainer S_VBoxContainer => L_PanelContainer.L_VBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: CharacterStatsUi.PanelContainer.HBoxContainer.VBoxContainer2
    /// </summary>
    public VBoxContainer2 S_VBoxContainer2 => L_PanelContainer.L_HBoxContainer.L_VBoxContainer2;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: CharacterStatsUi.PanelContainer.HBoxContainer
    /// </summary>
    public HBoxContainer S_HBoxContainer => L_PanelContainer.L_HBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: CharacterStatsUi.PanelContainer
    /// </summary>
    public PanelContainer S_PanelContainer => L_PanelContainer;

}
