namespace Game.Scripts.Ui.AbilityLoadoutUi;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class AbilityLoadoutUi : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: AbilityLoadoutUi.Abilities
    /// </summary>
    public Abilities L_Abilities
    {
        get
        {
            if (_L_Abilities == null) _L_Abilities = new Abilities((AbilityLoadoutUiPanel)this, GetNode<Godot.HBoxContainer>("Abilities"));
            return _L_Abilities;
        }
    }
    private Abilities _L_Abilities;


    public AbilityLoadoutUi() : base(nameof(AbilityLoadoutUi))
    {
    }

    public sealed override void OnInitNestedUi()
    {

        var inst1 = L_Abilities;
        RecordNestedUi(inst1.L_PrimaryBtn.Instance, inst1, UiManager.RecordType.Open);
        inst1.L_PrimaryBtn.Instance.OnCreateUi();
        inst1.L_PrimaryBtn.Instance.OnInitNestedUi();

        var inst2 = L_Abilities;
        RecordNestedUi(inst2.L_SecondaryBtn.Instance, inst2, UiManager.RecordType.Open);
        inst2.L_SecondaryBtn.Instance.OnCreateUi();
        inst2.L_SecondaryBtn.Instance.OnInitNestedUi();

    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.AbilityButton.AbilityButtonPanel"/>, 路径: AbilityLoadoutUi.Abilities.PrimaryBtn
    /// </summary>
    public class PrimaryBtn : UiNode<AbilityLoadoutUiPanel, Game.Scripts.Ui.AbilityButton.AbilityButtonPanel, PrimaryBtn>
    {
        public PrimaryBtn(AbilityLoadoutUiPanel uiPanel, Game.Scripts.Ui.AbilityButton.AbilityButtonPanel node) : base(uiPanel, node) {  }
        public override PrimaryBtn Clone()
        {
            var uiNode = new PrimaryBtn(UiPanel, (Game.Scripts.Ui.AbilityButton.AbilityButtonPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.AbilityButton.AbilityButtonPanel"/>, 路径: AbilityLoadoutUi.Abilities.SecondaryBtn
    /// </summary>
    public class SecondaryBtn : UiNode<AbilityLoadoutUiPanel, Game.Scripts.Ui.AbilityButton.AbilityButtonPanel, SecondaryBtn>
    {
        public SecondaryBtn(AbilityLoadoutUiPanel uiPanel, Game.Scripts.Ui.AbilityButton.AbilityButtonPanel node) : base(uiPanel, node) {  }
        public override SecondaryBtn Clone()
        {
            var uiNode = new SecondaryBtn(UiPanel, (Game.Scripts.Ui.AbilityButton.AbilityButtonPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: AbilityLoadoutUi.Abilities
    /// </summary>
    public class Abilities : UiNode<AbilityLoadoutUiPanel, Godot.HBoxContainer, Abilities>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.AbilityButton.AbilityButtonPanel"/>, 节点路径: AbilityLoadoutUi.PrimaryBtn
        /// </summary>
        public PrimaryBtn L_PrimaryBtn
        {
            get
            {
                if (_L_PrimaryBtn == null) _L_PrimaryBtn = new PrimaryBtn(UiPanel, Instance.GetNode<Game.Scripts.Ui.AbilityButton.AbilityButtonPanel>("PrimaryBtn"));
                return _L_PrimaryBtn;
            }
        }
        private PrimaryBtn _L_PrimaryBtn;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.AbilityButton.AbilityButtonPanel"/>, 节点路径: AbilityLoadoutUi.SecondaryBtn
        /// </summary>
        public SecondaryBtn L_SecondaryBtn
        {
            get
            {
                if (_L_SecondaryBtn == null) _L_SecondaryBtn = new SecondaryBtn(UiPanel, Instance.GetNode<Game.Scripts.Ui.AbilityButton.AbilityButtonPanel>("SecondaryBtn"));
                return _L_SecondaryBtn;
            }
        }
        private SecondaryBtn _L_SecondaryBtn;

        public Abilities(AbilityLoadoutUiPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override Abilities Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.AbilityButton.AbilityButtonPanel"/>, 节点路径: AbilityLoadoutUi.Abilities.PrimaryBtn
    /// </summary>
    public PrimaryBtn S_PrimaryBtn => L_Abilities.L_PrimaryBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.AbilityButton.AbilityButtonPanel"/>, 节点路径: AbilityLoadoutUi.Abilities.SecondaryBtn
    /// </summary>
    public SecondaryBtn S_SecondaryBtn => L_Abilities.L_SecondaryBtn;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: AbilityLoadoutUi.Abilities
    /// </summary>
    public Abilities S_Abilities => L_Abilities;

}
