using cfg.Stats;
using RPGCore.Stats;

namespace Game.Scripts.Ui.CharacterStatsUi;

public partial class CharacterStatsUiPanel : CharacterStatsUi
{
    public void UpdateUi(CharacterStats stats)
    {
        S_MaxHealth.Instance.UpdateUi(stats.GetVital(VitalType.Health).MaxValue, "MaxHealth");
        S_Speed.Instance.UpdateUi(stats.GetStat(StatType.MovementSpeed), "Speed");
    }
}
