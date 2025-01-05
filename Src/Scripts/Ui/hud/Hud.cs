namespace Game.Scripts.Ui.Hud;

using DsUi;

/// <summary>
/// Ui代码, 该类是根据ui场景自动生成的, 请不要手动编辑该类, 以免造成代码丢失
/// </summary>
public abstract partial class Hud : UiBase
{
    /// <summary>
    /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.TabContainer"/>, 节点路径: Hud.Pages
    /// </summary>
    public Pages L_Pages
    {
        get
        {
            if (_L_Pages == null) _L_Pages = new Pages((HudPanel)this, GetNode<Godot.TabContainer>("Pages"));
            return _L_Pages;
        }
    }
    private Pages _L_Pages;


    public Hud() : base(nameof(Hud))
    {
    }

    public sealed override void OnInitNestedUi()
    {

        var inst1 = L_Pages;
        RecordNestedUi(inst1.L_CharacterUi.Instance, inst1, UiManager.RecordType.Open);
        inst1.L_CharacterUi.Instance.OnCreateUi();
        inst1.L_CharacterUi.Instance.OnInitNestedUi();

    }

    /// <summary>
    /// 类型: <see cref="Godot.Control"/>, 路径: Hud.Pages.Home
    /// </summary>
    public class Home : UiNode<HudPanel, Godot.Control, Home>
    {
        public Home(HudPanel uiPanel, Godot.Control node) : base(uiPanel, node) {  }
        public override Home Clone() => new (UiPanel, (Godot.Control)Instance.Duplicate());
    }

    /// <summary>
    /// 类型: <see cref="Game.Scripts.Ui.CharacterUi.CharacterUiPanel"/>, 路径: Hud.Pages.CharacterUi
    /// </summary>
    public class CharacterUi : UiNode<HudPanel, Game.Scripts.Ui.CharacterUi.CharacterUiPanel, CharacterUi>
    {
        public CharacterUi(HudPanel uiPanel, Game.Scripts.Ui.CharacterUi.CharacterUiPanel node) : base(uiPanel, node) {  }
        public override CharacterUi Clone()
        {
            var uiNode = new CharacterUi(UiPanel, (Game.Scripts.Ui.CharacterUi.CharacterUiPanel)Instance.Duplicate());
            UiPanel.RecordNestedUi(uiNode.Instance, this, UiManager.RecordType.Open);
            uiNode.Instance.OnCreateUi();
            uiNode.Instance.OnInitNestedUi();
            return uiNode;
        }
    }

    /// <summary>
    /// 类型: <see cref="Godot.TabContainer"/>, 路径: Hud.Pages
    /// </summary>
    public class Pages : UiNode<HudPanel, Godot.TabContainer, Pages>
    {
        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Godot.Control"/>, 节点路径: Hud.Home
        /// </summary>
        public Home L_Home
        {
            get
            {
                if (_L_Home == null) _L_Home = new Home(UiPanel, Instance.GetNode<Godot.Control>("Home"));
                return _L_Home;
            }
        }
        private Home _L_Home;

        /// <summary>
        /// 使用 Instance 属性获取当前节点实例对象, 节点类型: <see cref="Game.Scripts.Ui.CharacterUi.CharacterUiPanel"/>, 节点路径: Hud.CharacterUi
        /// </summary>
        public CharacterUi L_CharacterUi
        {
            get
            {
                if (_L_CharacterUi == null) _L_CharacterUi = new CharacterUi(UiPanel, Instance.GetNode<Game.Scripts.Ui.CharacterUi.CharacterUiPanel>("CharacterUi"));
                return _L_CharacterUi;
            }
        }
        private CharacterUi _L_CharacterUi;

        public Pages(HudPanel uiPanel, Godot.TabContainer node) : base(uiPanel, node) {  }
        public override Pages Clone() => new (UiPanel, (Godot.TabContainer)Instance.Duplicate());
    }


    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.Control"/>, 节点路径: Hud.Pages.Home
    /// </summary>
    public Home S_Home => L_Pages.L_Home;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Game.Scripts.Ui.CharacterUi.CharacterUiPanel"/>, 节点路径: Hud.Pages.CharacterUi
    /// </summary>
    public CharacterUi S_CharacterUi => L_Pages.L_CharacterUi;

    /// <summary>
    /// 场景中唯一名称的节点, 节点类型: <see cref="Godot.TabContainer"/>, 节点路径: Hud.Pages
    /// </summary>
    public Pages S_Pages => L_Pages;

}
