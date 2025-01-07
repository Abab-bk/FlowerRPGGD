namespace Game.Scripts.Ui.CharacterUi;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class CharacterUi : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: CharacterUi.HBoxContainer
    /// </summary>
    public HBoxContainer L_HBoxContainer
    {
        get
        {
            if (_L_HBoxContainer == null) _L_HBoxContainer = new HBoxContainer((CharacterUiPanel)this, GetNode<Godot.HBoxContainer>("HBoxContainer"));
            return _L_HBoxContainer;
        }
    }
    private HBoxContainer _L_HBoxContainer;


    public CharacterUi() : base(nameof(CharacterUi))
    {
    }

    public sealed override void OnInitNestedUi()
    {

        var inst1 = L_HBoxContainer;
        RecordNestedUi(inst1.L_CharacterEquipmentsUi.Instance, inst1, UiManager.RecordType.Open);
        inst1.L_CharacterEquipmentsUi.Instance.OnCreateUi();
        inst1.L_CharacterEquipmentsUi.Instance.OnInitNestedUi();

        var inst2 = L_HBoxContainer;
        RecordNestedUi(inst2.L_InventoryUi.Instance, inst2, UiManager.RecordType.Open);
        inst2.L_InventoryUi.Instance.OnCreateUi();
        inst2.L_InventoryUi.Instance.OnInitNestedUi();

    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.CharacterEquipmentsUi.CharacterEquipmentsUiPanel"/>, 路径: CharacterUi.HBoxContainer.CharacterEquipmentsUi
    /// </summary>
    public class CharacterEquipmentsUi : UiNode<CharacterUiPanel, Game.Scripts.Ui.CharacterEquipmentsUi.CharacterEquipmentsUiPanel, CharacterEquipmentsUi>
    {
        public CharacterEquipmentsUi(CharacterUiPanel uiPanel, Game.Scripts.Ui.CharacterEquipmentsUi.CharacterEquipmentsUiPanel node) : base(uiPanel, node) {  }
        public override CharacterEquipmentsUi Clone()
        {
            var uiNode = new CharacterEquipmentsUi(UiPanel, (Game.Scripts.Ui.CharacterEquipmentsUi.CharacterEquipmentsUiPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.InventoryUi.InventoryUiPanel"/>, 路径: CharacterUi.HBoxContainer.InventoryUi
    /// </summary>
    public class InventoryUi : UiNode<CharacterUiPanel, Game.Scripts.Ui.InventoryUi.InventoryUiPanel, InventoryUi>
    {
        public InventoryUi(CharacterUiPanel uiPanel, Game.Scripts.Ui.InventoryUi.InventoryUiPanel node) : base(uiPanel, node) {  }
        public override InventoryUi Clone()
        {
            var uiNode = new InventoryUi(UiPanel, (Game.Scripts.Ui.InventoryUi.InventoryUiPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: CharacterUi.HBoxContainer
    /// </summary>
    public class HBoxContainer : UiNode<CharacterUiPanel, Godot.HBoxContainer, HBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.CharacterEquipmentsUi.CharacterEquipmentsUiPanel"/>, 节点路径: CharacterUi.CharacterEquipmentsUi
        /// </summary>
        public CharacterEquipmentsUi L_CharacterEquipmentsUi
        {
            get
            {
                if (_L_CharacterEquipmentsUi == null) _L_CharacterEquipmentsUi = new CharacterEquipmentsUi(UiPanel, Instance.GetNode<Game.Scripts.Ui.CharacterEquipmentsUi.CharacterEquipmentsUiPanel>("CharacterEquipmentsUi"));
                return _L_CharacterEquipmentsUi;
            }
        }
        private CharacterEquipmentsUi _L_CharacterEquipmentsUi;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.InventoryUi.InventoryUiPanel"/>, 节点路径: CharacterUi.InventoryUi
        /// </summary>
        public InventoryUi L_InventoryUi
        {
            get
            {
                if (_L_InventoryUi == null) _L_InventoryUi = new InventoryUi(UiPanel, Instance.GetNode<Game.Scripts.Ui.InventoryUi.InventoryUiPanel>("InventoryUi"));
                return _L_InventoryUi;
            }
        }
        private InventoryUi _L_InventoryUi;

        public HBoxContainer(CharacterUiPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.CharacterEquipmentsUi.CharacterEquipmentsUiPanel"/>, 节点路径: CharacterUi.HBoxContainer.CharacterEquipmentsUi
    /// </summary>
    public CharacterEquipmentsUi S_CharacterEquipmentsUi => L_HBoxContainer.L_CharacterEquipmentsUi;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.InventoryUi.InventoryUiPanel"/>, 节点路径: CharacterUi.HBoxContainer.InventoryUi
    /// </summary>
    public InventoryUi S_InventoryUi => L_HBoxContainer.L_InventoryUi;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: CharacterUi.HBoxContainer
    /// </summary>
    public HBoxContainer S_HBoxContainer => L_HBoxContainer;

}
