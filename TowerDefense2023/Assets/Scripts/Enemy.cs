using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int wavePointIndex = 0;

    private void Start()
    {
        target = Waypoints.points[0];
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        if(Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextPoint();
        }
    }

    private void GetNextPoint()
    {
        if(wavePointIndex >= Waypoints.points.Length - 1)
        {
            gameObject.SetActive(false);
            target = Waypoints.points[0];
            wavePointIndex = 0;
            return;
        }
        wavePointIndex += 1;
        target = Waypoints.points[wavePointIndex];
        Debug.Log(wavePointIndex);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            gameObject.SetActive(false);
            target = Waypoints.points[0];
            wavePointIndex = 0;
            Destroy(other.gameObject);
        }
    }
}
