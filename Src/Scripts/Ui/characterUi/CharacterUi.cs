namespace Game.Scripts.Ui.CharacterUi;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class CharacterUi : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.InventoryUi.InventoryUiPanel"/>, 节点路径: CharacterUi.InventoryUi
    /// </summary>
    public InventoryUi L_InventoryUi
    {
        get
        {
            if (_L_InventoryUi == null) _L_InventoryUi = new InventoryUi((CharacterUiPanel)this, GetNode<Game.Scripts.Ui.InventoryUi.InventoryUiPanel>("InventoryUi"));
            return _L_InventoryUi;
        }
    }
    private InventoryUi _L_InventoryUi;


    public CharacterUi() : base(nameof(CharacterUi))
    {
    }

    public sealed override void OnInitNestedUi()
    {

        var inst1 = this;
        RecordNestedUi(inst1.L_InventoryUi.Instance, null, UiManager.RecordType.Open);
        inst1.L_InventoryUi.Instance.OnCreateUi();
        inst1.L_InventoryUi.Instance.OnInitNestedUi();

    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.InventoryUi.InventoryUiPanel"/>, 路径: CharacterUi.InventoryUi
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
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.InventoryUi.InventoryUiPanel"/>, 节点路径: CharacterUi.InventoryUi
    /// </summary>
    public InventoryUi S_InventoryUi => L_InventoryUi;

}
