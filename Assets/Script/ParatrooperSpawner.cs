using UnityEngine;
using System.Collections;

public class ParatrooperSpawner : MonoBehaviour
{
    public GameObject paratrooperPrefab;
    public float spawnRate = 2f;

    void Start()
    {
        StartCoroutine(SpawnParatroopers());
    }

    IEnumerator SpawnParatroopers()
    {
        while (true)
        {
            SpawnParatrooper();
            yield return new WaitForSeconds(spawnRate);
        }
    }

    void SpawnParatrooper()
    {
        float spawnX = Random.Range(-7f, 7f);
        Vector3 spawnPosition = new Vector3(spawnX, 5, 0);
        Instantiate(paratrooperPrefab, spawnPosition, Quaternion.identity);
    }
}
