using RPGCore.Players;

namespace Game.Scripts.Ui.CharacterEquipmentsUi;

public partial class CharacterEquipmentsUiPanel : CharacterEquipmentsUi
{
    public void Init(PlayerEquipments equipments)
    {
        S_WeaponSlot.Instance.Init(equipments.Weapon);
    }
}
