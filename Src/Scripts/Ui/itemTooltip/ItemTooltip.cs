namespace Game.Scripts.Ui.ItemTooltip;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class ItemTooltip : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: ItemTooltip.PanelContainer
    /// </summary>
    public PanelContainer L_PanelContainer
    {
        get
        {
            if (_L_PanelContainer == null) _L_PanelContainer = new PanelContainer((ItemTooltipPanel)this, GetNode<Godot.PanelContainer>("PanelContainer"));
            return _L_PanelContainer;
        }
    }
    private PanelContainer _L_PanelContainer;


    public ItemTooltip() : base(nameof(ItemTooltip))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureRect"/>, 路径: ItemTooltip.PanelContainer.VBoxContainer.Info.HBoxContainer.Icon
    /// </summary>
    public class Icon : UiNode<ItemTooltipPanel, Godot.TextureRect, Icon>
    {
        public Icon(ItemTooltipPanel uiPanel, Godot.TextureRect node) : base(uiPanel, node) {  }
        public override Icon Clone() => new (UiPanel, (Godot.TextureRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: ItemTooltip.PanelContainer.VBoxContainer.Info.HBoxContainer.Name
    /// </summary>
    public class Name : UiNode<ItemTooltipPanel, Godot.Label, Name>
    {
        public Name(ItemTooltipPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Name Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.HBoxContainer"/>, 路径: ItemTooltip.PanelContainer.VBoxContainer.Info.HBoxContainer
    /// </summary>
    public class HBoxContainer : UiNode<ItemTooltipPanel, Godot.HBoxContainer, HBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: ItemTooltip.PanelContainer.VBoxContainer.Info.Icon
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: ItemTooltip.PanelContainer.VBoxContainer.Info.Name
        /// </summary>
        public Name L_Name
        {
            get
            {
                if (_L_Name == null) _L_Name = new Name(UiPanel, Instance.GetNode<Godot.Label>("Name"));
                return _L_Name;
            }
        }
        private Name _L_Name;

        public HBoxContainer(ItemTooltipPanel uiPanel, Godot.HBoxContainer node) : base(uiPanel, node) {  }
        public override HBoxContainer Clone() => new (UiPanel, (Godot.HBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: ItemTooltip.PanelContainer.VBoxContainer.Info.Rarity
    /// </summary>
    public class Rarity : UiNode<ItemTooltipPanel, Godot.Label, Rarity>
    {
        public Rarity(ItemTooltipPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override Rarity Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: ItemTooltip.PanelContainer.VBoxContainer.Info
    /// </summary>
    public class Info : UiNode<ItemTooltipPanel, Godot.VBoxContainer, Info>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: ItemTooltip.PanelContainer.VBoxContainer.HBoxContainer
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

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: ItemTooltip.PanelContainer.VBoxContainer.Rarity
        /// </summary>
        public Rarity L_Rarity
        {
            get
            {
                if (_L_Rarity == null) _L_Rarity = new Rarity(UiPanel, Instance.GetNode<Godot.Label>("Rarity"));
                return _L_Rarity;
            }
        }
        private Rarity _L_Rarity;

        public Info(ItemTooltipPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override Info Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: ItemTooltip.PanelContainer.VBoxContainer.BaseStats
    /// </summary>
    public class BaseStats : UiNode<ItemTooltipPanel, Godot.VBoxContainer, BaseStats>
    {
        public BaseStats(ItemTooltipPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override BaseStats Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: ItemTooltip.PanelContainer.VBoxContainer.AdditionStats
    /// </summary>
    public class AdditionStats : UiNode<ItemTooltipPanel, Godot.VBoxContainer, AdditionStats>
    {
        public AdditionStats(ItemTooltipPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override AdditionStats Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.VBoxContainer"/>, 路径: ItemTooltip.PanelContainer.VBoxContainer
    /// </summary>
    public class VBoxContainer : UiNode<ItemTooltipPanel, Godot.VBoxContainer, VBoxContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: ItemTooltip.PanelContainer.Info
        /// </summary>
        public Info L_Info
        {
            get
            {
                if (_L_Info == null) _L_Info = new Info(UiPanel, Instance.GetNode<Godot.VBoxContainer>("Info"));
                return _L_Info;
            }
        }
        private Info _L_Info;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: ItemTooltip.PanelContainer.BaseStats
        /// </summary>
        public BaseStats L_BaseStats
        {
            get
            {
                if (_L_BaseStats == null) _L_BaseStats = new BaseStats(UiPanel, Instance.GetNode<Godot.VBoxContainer>("BaseStats"));
                return _L_BaseStats;
            }
        }
        private BaseStats _L_BaseStats;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: ItemTooltip.PanelContainer.AdditionStats
        /// </summary>
        public AdditionStats L_AdditionStats
        {
            get
            {
                if (_L_AdditionStats == null) _L_AdditionStats = new AdditionStats(UiPanel, Instance.GetNode<Godot.VBoxContainer>("AdditionStats"));
                return _L_AdditionStats;
            }
        }
        private AdditionStats _L_AdditionStats;

        public VBoxContainer(ItemTooltipPanel uiPanel, Godot.VBoxContainer node) : base(uiPanel, node) {  }
        public override VBoxContainer Clone() => new (UiPanel, (Godot.VBoxContainer)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: ItemTooltip.PanelContainer
    /// </summary>
    public class PanelContainer : UiNode<ItemTooltipPanel, Godot.PanelContainer, PanelContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: ItemTooltip.VBoxContainer
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

        public PanelContainer(ItemTooltipPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override PanelContainer Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: ItemTooltip.PanelContainer.VBoxContainer.Info.HBoxContainer.Icon
    /// </summary>
    public Icon S_Icon => L_PanelContainer.L_VBoxContainer.L_Info.L_HBoxContainer.L_Icon;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: ItemTooltip.PanelContainer.VBoxContainer.Info.HBoxContainer.Name
    /// </summary>
    public Name S_Name => L_PanelContainer.L_VBoxContainer.L_Info.L_HBoxContainer.L_Name;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.HBoxContainer"/>, 节点路径: ItemTooltip.PanelContainer.VBoxContainer.Info.HBoxContainer
    /// </summary>
    public HBoxContainer S_HBoxContainer => L_PanelContainer.L_VBoxContainer.L_Info.L_HBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: ItemTooltip.PanelContainer.VBoxContainer.Info.Rarity
    /// </summary>
    public Rarity S_Rarity => L_PanelContainer.L_VBoxContainer.L_Info.L_Rarity;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: ItemTooltip.PanelContainer.VBoxContainer.Info
    /// </summary>
    public Info S_Info => L_PanelContainer.L_VBoxContainer.L_Info;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: ItemTooltip.PanelContainer.VBoxContainer.BaseStats
    /// </summary>
    public BaseStats S_BaseStats => L_PanelContainer.L_VBoxContainer.L_BaseStats;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: ItemTooltip.PanelContainer.VBoxContainer.AdditionStats
    /// </summary>
    public AdditionStats S_AdditionStats => L_PanelContainer.L_VBoxContainer.L_AdditionStats;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.VBoxContainer"/>, 节点路径: ItemTooltip.PanelContainer.VBoxContainer
    /// </summary>
    public VBoxContainer S_VBoxContainer => L_PanelContainer.L_VBoxContainer;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: ItemTooltip.PanelContainer
    /// </summary>
    public PanelContainer S_PanelContainer => L_PanelContainer;

}
