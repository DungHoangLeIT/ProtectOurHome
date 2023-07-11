using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBuilded : MonoBehaviour
{
    private GameObject turretToBuild;

    public GameObject buildedTurret1;
    public GameObject buildedTurret2;   

    public static TurretBuilded Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    



    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void  SetSelectedTurret(GameObject turret)
    {
        turretToBuild = turret;
    }
}
