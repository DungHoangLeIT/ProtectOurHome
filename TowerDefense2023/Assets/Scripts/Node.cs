using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 heightPosTurret;

    private Color startColor;
    private Renderer rend;
    private TurretBuilded turretBuilded;

    private GameObject turret; 

    private void Start()
    {
        rend = GetComponent<Renderer>();    
        startColor = rend.material.color;
        turretBuilded = TurretBuilded.Instance; 
    }

    private void OnMouseDown()
    {
        if(turretBuilded.GetTurretToBuild() == null)
        {
            return;
        }
        if(turret != null)
        {
            Debug.Log("can't build here");
            return;
        }
        GameObject turretToBuild = turretBuilded.GetTurretToBuild();
        turret = Instantiate(turretToBuild, transform.position + heightPosTurret,transform.rotation); 
    }

    private void OnMouseEnter()
    {
        if (turretBuilded.GetTurretToBuild() == null)
        {
            return;
        }
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {

        rend.material.color = startColor;
    }
}
