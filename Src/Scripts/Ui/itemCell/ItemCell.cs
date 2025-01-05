namespace Game.Scripts.Ui.ItemCell;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class ItemCell : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: ItemCell.PanelContainer
    /// </summary>
    public PanelContainer L_PanelContainer
    {
        get
        {
            if (_L_PanelContainer == null) _L_PanelContainer = new PanelContainer((ItemCellPanel)this, GetNode<Godot.PanelContainer>("PanelContainer"));
            return _L_PanelContainer;
        }
    }
    private PanelContainer _L_PanelContainer;


    public ItemCell() : base(nameof(ItemCell))
    {
    }

    public sealed override void OnInitNestedUi()
    {

    }

    /// <summary>
    /// 类型: <see cref="Godot.TextureRect"/>, 路径: ItemCell.PanelContainer.Icon
    /// </summary>
    public class Icon : UiNode<ItemCellPanel, Godot.TextureRect, Icon>
    {
        public Icon(ItemCellPanel uiPanel, Godot.TextureRect node) : base(uiPanel, node) {  }
        public override Icon Clone() => new (UiPanel, (Godot.TextureRect)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Label"/>, 路径: ItemCell.PanelContainer.ItemCount
    /// </summary>
    public class ItemCount : UiNode<ItemCellPanel, Godot.Label, ItemCount>
    {
        public ItemCount(ItemCellPanel uiPanel, Godot.Label node) : base(uiPanel, node) {  }
        public override ItemCount Clone() => new (UiPanel, (Godot.Label)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.Button"/>, 路径: ItemCell.PanelContainer.Button
    /// </summary>
    public class Button : UiNode<ItemCellPanel, Godot.Button, Button>
    {
        public Button(ItemCellPanel uiPanel, Godot.Button node) : base(uiPanel, node) {  }
        public override Button Clone() => new (UiPanel, (Godot.Button)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Godot.PanelContainer"/>, 路径: ItemCell.PanelContainer
    /// </summary>
    public class PanelContainer : UiNode<ItemCellPanel, Godot.PanelContainer, PanelContainer>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: ItemCell.Icon
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
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Label"/>, 节点路径: ItemCell.ItemCount
        /// </summary>
        public ItemCount L_ItemCount
        {
            get
            {
                if (_L_ItemCount == null) _L_ItemCount = new ItemCount(UiPanel, Instance.GetNode<Godot.Label>("ItemCount"));
                return _L_ItemCount;
            }
        }
        private ItemCount _L_ItemCount;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Button"/>, 节点路径: ItemCell.Button
        /// </summary>
        public Button L_Button
        {
            get
            {
                if (_L_Button == null) _L_Button = new Button(UiPanel, Instance.GetNode<Godot.Button>("Button"));
                return _L_Button;
            }
        }
        private Button _L_Button;

        public PanelContainer(ItemCellPanel uiPanel, Godot.PanelContainer node) : base(uiPanel, node) {  }
        public override PanelContainer Clone() => new (UiPanel, (Godot.PanelContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TextureRect"/>, 节点路径: ItemCell.PanelContainer.Icon
    /// </summary>
    public Icon S_Icon => L_PanelContainer.L_Icon;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Label"/>, 节点路径: ItemCell.PanelContainer.ItemCount
    /// </summary>
    public ItemCount S_ItemCount => L_PanelContainer.L_ItemCount;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Button"/>, 节点路径: ItemCell.PanelContainer.Button
    /// </summary>
    public Button S_Button => L_PanelContainer.L_Button;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.PanelContainer"/>, 节点路径: ItemCell.PanelContainer
    /// </summary>
    public PanelContainer S_PanelContainer => L_PanelContainer;

}
