using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RewardSpawner : MonoBehaviour
{
    public GameObject RewardPrefab;


    // Start is called before the first frame update
    void Start()
    {
        SpawnReward();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnReward()
    {
        Vector3 randomOffset = Random.insideUnitSphere * 10f;
        Vector3 randomPosition = transform.position + randomOffset;

        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomPosition, out hit, 10.0f, NavMesh.AllAreas))
        {
            randomPosition = hit.position;
        }

        randomPosition.y = 1.5f; 

        Quaternion rotation = Quaternion.Euler(0f, 0f, 90f);
        Instantiate(RewardPrefab, randomPosition, rotation);
    }
}
