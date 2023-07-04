using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject impactEffect;

    private Transform target;
    private float speed = 70f;

    public void Seek(Transform _target)
    {
        target = _target;
    }
    

    void Update()
    {
        if(target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceFrame = speed * Time.deltaTime;
        if(dir.magnitude <= distanceFrame )
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceFrame, Space.World);
    }

    private void HitTarget()
    {
        GameObject effectIns = (GameObject)Instantiate(impactEffect,transform.position,transform.rotation);
        Destroy(effectIns, 2f);
        Destroy(target.gameObject);
    }

    
}
