using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFoods : MonoBehaviour
{
    [SerializeField] private GameObject[] foodPrefab;
    [SerializeField] private float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnFood), 0, spawnInterval);
    }
    
    private void SpawnFood()
    {
        // food spawn random pada koordinat yang diinginkan
        Vector3 spawnPosition = new Vector3(Random.Range(-8f, 8f), 6f, 0f);
        GameObject spawnedFood = Instantiate(foodPrefab[Random.Range(0, foodPrefab.Length)], spawnPosition, Quaternion.identity);

        if (!spawnedFood.TryGetComponent<Rigidbody2D>(out _))
        {
            spawnedFood.AddComponent<Rigidbody2D>();
        }

        spawnedFood.AddComponent<DestroyFood>();
    }
}
