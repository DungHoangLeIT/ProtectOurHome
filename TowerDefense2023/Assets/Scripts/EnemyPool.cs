using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    public static EnemyPool instance;
    private List<GameObject> pooledObjects = new List<GameObject>();

    private int amountPool = 20;

    [SerializeField] private GameObject enemyPrefab;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        for (int i = 0; i < amountPool; i++)
        {
            GameObject gameObj = Instantiate(enemyPrefab);
            gameObj.SetActive(false);
            pooledObjects.Add(gameObj);  
        }
    }

    public GameObject GetPoolEnemy()
    {
        for(int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
