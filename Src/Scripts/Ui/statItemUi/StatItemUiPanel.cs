using System.Globalization;
using FlowerRpg.Stats;

namespace Game.Scripts.Ui.StatItemUi;

public partial class StatItemUiPanel : StatItemUi
{
    public void UpdateUi(IStat stat, string statName)
    {
        S_Number.Instance.Text = stat.Value.ToString(CultureInfo.CurrentCulture);
        S_Name.Instance.Text = statName;
    }
}
