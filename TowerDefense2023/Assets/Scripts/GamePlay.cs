using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPos;
    public float timeWaveLeft = 5f;
    public TMP_Text timeWaveLeftText;

    private float countDown = 2f;
    private int waveNumber = 0;

    private void Update()
    {
        if(countDown <= 0f)
        {
            countDown = timeWaveLeft;
            StartCoroutine(SpawnWave());
        }
        timeWaveLeftText.text = Mathf.Round(countDown).ToString();
        countDown -= Time.deltaTime;
    }

    private IEnumerator SpawnWave()
    {
        waveNumber++;
        for(int i = 0; i <= waveNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }



    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPos.position, spawnPos.rotation);
    }


}
