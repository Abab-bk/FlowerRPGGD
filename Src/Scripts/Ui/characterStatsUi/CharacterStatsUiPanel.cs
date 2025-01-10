using cfg.Stats;
using DsUi;
using FastEnumUtility;
using Game.Scripts.Ui.StatItemUi;
using RPGCore.Stats;

namespace Game.Scripts.Ui.CharacterStatsUi;

public partial class CharacterStatsUiPanel : CharacterStatsUi
{
    public void UpdateUi(CharacterStats stats)
    {
        foreach (var node in S_Items.Instance.GetChildren())
        {
            if (node is not StatItemUiPanel statItemUiPanel) continue;
            statItemUiPanel.UpdateUi(
                stats.GetStat(statItemUiPanel.StatType),
                statItemUiPanel.StatType.ToString()
                );
        }
    }

    public void Init(CharacterStats stats)
    {
        foreach (var statType in FastEnum.GetValues<StatType>())
        {
            S_Items
                .OpenNestedUi<StatItemUiPanel>(UiManager.UiName.StatItemUi)
                .Init(statType)
                .UpdateUi(stats.GetStat(statType), statType.ToString());
        }
    }
}
