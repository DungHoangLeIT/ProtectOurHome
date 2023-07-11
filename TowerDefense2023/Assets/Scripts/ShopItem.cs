using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItem : MonoBehaviour
{
    private TurretBuilded turretBuilded;

    private void Start()
    {
        turretBuilded = TurretBuilded.Instance;
    }

    public void SelectedTurret1()
    {
        turretBuilded.SetSelectedTurret(turretBuilded.buildedTurret1);
    }

    public void SelectdTurret2()
    {
        turretBuilded.SetSelectedTurret(turretBuilded.buildedTurret2);
    }

}
