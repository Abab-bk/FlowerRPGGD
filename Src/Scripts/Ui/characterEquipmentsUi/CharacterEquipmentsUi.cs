namespace Game.Scripts.Ui.CharacterEquipmentsUi;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class CharacterEquipmentsUi : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: CharacterEquipmentsUi.PanelContainer
    /// </summary>
    public PanelContainer L_PanelContainer
    {
        get
        {
            if (_L_PanelContainer == null) _L_PanelContainer = new PanelContainer((CharacterEquipmentsUiPanel)this, GetNode<Godot.PanelContainer>("PanelContainer"));
            return _L_PanelContainer;
        }
    }
    private PanelContainer _L_PanelContainer;


    public CharacterEquipmentsUi() : base(nameof(CharacterEquipmentsUi))
    {
    }

    public sealed override void OnInitNestedUi()
    {

        var inst1 = L_PanelContainer.L_HBoxContainer.L_VBoxContainer;
        RecordNestedUi(inst1.L_WeaponSlot.Instance, inst1, UiManager.RecordType.Open);
        inst1.L_WeaponSlot.Instance.OnCreateUi();
        inst1.L_WeaponSlot.Instance.OnInitNestedUi();

        var inst2 = L_PanelContainer.L_HBoxContainer.L_VBoxContainer;
        RecordNestedUi(inst2.L_ItemSlotUi2.Instance, inst2, UiManager.RecordType.Open);
        inst2.L_ItemSlotUi2.Instance.OnCreateUi();
        inst2.L_ItemSlotUi2.Instance.OnInitNestedUi();

        var inst3 = L_PanelContainer.L_HBoxContainer.L_VBoxContainer;
        RecordNestedUi(inst3.L_ItemSlotUi3.Instance, inst3, UiManager.RecordType.Open);
        inst3.L_ItemSlotUi3.Instance.OnCreateUi();
        inst3.L_ItemSlotUi3.Instance.OnInitNestedUi();

        var inst4 = L_PanelContainer.L_HBoxContainer.L_VBoxContainer2;
        RecordNestedUi(inst4.L_ItemSlotUi.Instance, inst4, UiManager.RecordType.Open);
        inst4.L_ItemSlotUi.Instance.OnCreateUi();
        inst4.L_ItemSlotUi.Instance.OnInitNestedUi();

        var inst5 = L_PanelContainer.L_HBoxContainer.L_VBoxContainer2;
        RecordNestedUi(inst5.L_ItemSlotUi2.Instance, inst5, UiManager.RecordType.Open);
        inst5.L_ItemSlotUi2.Instance.OnCreateUi();
        inst5.L_ItemSlotUi2.Instance.OnInitNestedUi();

        var inst6 = L_PanelContainer.L_HBoxContainer.L_VBoxContainer2;
        RecordNestedUi(inst6.L_ItemSlotUi3.Instance, inst6, UiManager.RecordType.Open);
        inst6.L_ItemSlotUi3.Instance.OnCreateUi();
        inst6.L_ItemSlotUi3.Instance.OnInitNestedUi();

    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel"/>, 路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.VBoxContainer.WeaponSlot
    /// </summary>
    public class WeaponSlot : UiNode<CharacterEquipmentsUiPanel, Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel, WeaponSlot>
    {
        public WeaponSlot(CharacterEquipmentsUiPanel uiPanel, Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel node) : base(uiPanel, node) {  }
        public override WeaponSlot Clone()
        {
            var uiNode = new WeaponSlot(UiPanel, (Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel"/>, 路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.VBoxContainer.ItemSlotUi2
    /// </summary>
    public class ItemSlotUi2 : UiNode<CharacterEquipmentsUiPanel, Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel, ItemSlotUi2>
    {
        public ItemSlotUi2(CharacterEquipmentsUiPanel uiPanel, Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel node) : base(uiPanel, node) {  }
        public override ItemSlotUi2 Clone()
        {
            var uiNode = new ItemSlotUi2(UiPanel, (Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel"/>, 路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.VBoxContainer.ItemSlotUi3
    /// </summary>
    public class ItemSlotUi3 : UiNode<CharacterEquipmentsUiPanel, Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel, ItemSlotUi3>
    {
        public ItemSlotUi3(CharacterEquipmentsUiPanel uiPanel, Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel node) : base(uiPanel, node) {  }
        public override ItemSlotUi3 Clone()
        {
            var uiNode = new ItemSlotUi3(UiPanel, (Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<CharacterEquipmentsUiPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel"/>, 节点路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.WeaponSlot
        /// </summary>
        public WeaponSlot L_WeaponSlot
        {
            get
            {
                if (_L_WeaponSlot == null) _L_WeaponSlot = new WeaponSlot(UiPanel, Instance.GetNode<Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel>("WeaponSlot"));
                return _L_WeaponSlot;
            }
        }
        private WeaponSlot _L_WeaponSlot;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel"/>, 节点路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.ItemSlotUi2
        /// </summary>
        public ItemSlotUi2 L_ItemSlotUi2
        {
            get
            {
                if (_L_ItemSlotUi2 == null) _L_ItemSlotUi2 = new ItemSlotUi2(UiPanel, Instance.GetNode<Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel>("ItemSlotUi2"));
                return _L_ItemSlotUi2;
            }
        }
        private ItemSlotUi2 _L_ItemSlotUi2;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel"/>, 节点路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.ItemSlotUi3
        /// </summary>
        public ItemSlotUi3 L_ItemSlotUi3
        {
            get
            {
                if (_L_ItemSlotUi3 == null) _L_ItemSlotUi3 = new ItemSlotUi3(UiPanel, Instance.GetNode<Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel>("ItemSlotUi3"));
                return _L_ItemSlotUi3;
            }
        }
        private ItemSlotUi3 _L_ItemSlotUi3;

        public VBoxContainer(CharacterEquipmentsUiPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Control"/>, 路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.Control
    /// </summary>
    public class Control : UiNode<CharacterEquipmentsUiPanel, Godot.Control, Control>
    {
        public Control(CharacterEquipmentsUiPanel uiPanel, Godot.Control node) : base(uiPanel, node) {  }
        public override Control Clone() => new (UiPanel, (Godot.Control)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel"/>, 路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.VBoxContainer2.ItemSlotUi
    /// </summary>
    public class ItemSlotUi : UiNode<CharacterEquipmentsUiPanel, Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel, ItemSlotUi>
    {
        public ItemSlotUi(CharacterEquipmentsUiPanel uiPanel, Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel node) : base(uiPanel, node) {  }
        public override ItemSlotUi Clone()
        {
            var uiNode = new ItemSlotUi(UiPanel, (Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel"/>, 路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.VBoxContainer2.ItemSlotUi2
    /// </summary>
    public class ItemSlotUi2_1 : UiNode<CharacterEquipmentsUiPanel, Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel, ItemSlotUi2_1>
    {
        public ItemSlotUi2_1(CharacterEquipmentsUiPanel uiPanel, Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel node) : base(uiPanel, node) {  }
        public override ItemSlotUi2_1 Clone()
        {
            var uiNode = new ItemSlotUi2_1(UiPanel, (Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel"/>, 路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.VBoxContainer2.ItemSlotUi3
    /// </summary>
    public class ItemSlotUi3_1 : UiNode<CharacterEquipmentsUiPanel, Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel, ItemSlotUi3_1>
    {
        public ItemSlotUi3_1(CharacterEquipmentsUiPanel uiPanel, Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel node) : base(uiPanel, node) {  }
        public override ItemSlotUi3_1 Clone()
        {
            var uiNode = new ItemSlotUi3_1(UiPanel, (Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.VBoxContainer2
    /// </summary>
    public class VBoxContainer2 : UiNode<CharacterEquipmentsUiPanel, Godot.VBoxContainer, VBoxContainer2>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel"/>, 节点路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.ItemSlotUi
        /// </summary>
        public ItemSlotUi L_ItemSlotUi
        {
            get
            {
                if (_L_ItemSlotUi == null) _L_ItemSlotUi = new ItemSlotUi(UiPanel, Instance.GetNode<Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel>("ItemSlotUi"));
                return _L_ItemSlotUi;
            }
        }
        private ItemSlotUi _L_ItemSlotUi;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel"/>, 节点路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.ItemSlotUi2
        /// </summary>
        public ItemSlotUi2_1 L_ItemSlotUi2
        {
            get
            {
                if (_L_ItemSlotUi2 == null) _L_ItemSlotUi2 = new ItemSlotUi2_1(UiPanel, Instance.GetNode<Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel>("ItemSlotUi2"));
                return _L_ItemSlotUi2;
            }
        }
        private ItemSlotUi2_1 _L_ItemSlotUi2;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel"/>, 节点路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.ItemSlotUi3
        /// </summary>
        public ItemSlotUi3_1 L_ItemSlotUi3
        {
            get
            {
                if (_L_ItemSlotUi3 == null) _L_ItemSlotUi3 = new ItemSlotUi3_1(UiPanel, Instance.GetNode<Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel>("ItemSlotUi3"));
                return _L_ItemSlotUi3;
            }
        }
        private ItemSlotUi3_1 _L_ItemSlotUi3;

        public VBoxContainer2(CharacterEquipmentsUiPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer2 Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer
    /// </summary>
    public class HBoxContainer : UiNode<CharacterEquipmentsUiPanel, Godot.HBoxContainer, HBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: CharacterEquipmentsUi.PanelContainer.VBoxContainer
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Control"/>, 节点路径: CharacterEquipmentsUi.PanelContainer.Control
        /// </summary>
        public Control L_Control
        {
            get
            {
                if (_L_Control == null) _L_Control = new Control(UiPanel, Instance.GetNode<Godot.Control>("Control"));
                return _L_Control;
            }
        }
        private Control _L_Control;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: CharacterEquipmentsUi.PanelContainer.VBoxContainer2
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

        public HBoxContainer(CharacterEquipmentsUiPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: CharacterEquipmentsUi.PanelContainer
    /// </summary>
    public class PanelContainer : UiNode<CharacterEquipmentsUiPanel, Godot.PanelContainer, PanelContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: CharacterEquipmentsUi.HBoxContainer
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

        public PanelContainer(CharacterEquipmentsUiPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override PanelContainer Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel"/>, 节点路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.VBoxContainer.WeaponSlot
    /// </summary>
    public WeaponSlot S_WeaponSlot => L_PanelContainer.L_HBoxContainer.L_VBoxContainer.L_WeaponSlot;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.VBoxContainer
    /// </summary>
    public VBoxContainer S_VBoxContainer => L_PanelContainer.L_HBoxContainer.L_VBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Control"/>, 节点路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.Control
    /// </summary>
    public Control S_Control => L_PanelContainer.L_HBoxContainer.L_Control;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.ItemSlotUi.ItemSlotUiPanel"/>, 节点路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.VBoxContainer2.ItemSlotUi
    /// </summary>
    public ItemSlotUi S_ItemSlotUi => L_PanelContainer.L_HBoxContainer.L_VBoxContainer2.L_ItemSlotUi;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer.VBoxContainer2
    /// </summary>
    public VBoxContainer2 S_VBoxContainer2 => L_PanelContainer.L_HBoxContainer.L_VBoxContainer2;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: CharacterEquipmentsUi.PanelContainer.HBoxContainer
    /// </summary>
    public HBoxContainer S_HBoxContainer => L_PanelContainer.L_HBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: CharacterEquipmentsUi.PanelContainer
    /// </summary>
    public PanelContainer S_PanelContainer => L_PanelContainer;

}
