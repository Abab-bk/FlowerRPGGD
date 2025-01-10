using System.Globalization;
using cfg.Stats;
using FlowerRpg.Stats;

namespace Game.Scripts.Ui.StatItemUi;

public partial class StatItemUiPanel : StatItemUi
{
    public StatType StatType { get; set; }
    
    public StatItemUiPanel Init(StatType statType)
    {
        StatType = statType;
        Show();
        return this;
    }

    public void UpdateUi(IStat stat, string statName)
    {
        S_Number.Instance.Text = stat.Value.ToString(CultureInfo.CurrentCulture);
        S_Name.Instance.Text = statName;
    }
}
