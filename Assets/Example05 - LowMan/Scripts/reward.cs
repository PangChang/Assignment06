using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class reward : MonoBehaviour
{
    public GameObject RewardPrefab;
    public GameObject PlayerPrefab;

    void OnTriggerEnter(Collider collide)
    {
        if (collide.tag == "Player")
        {
            Score.CurrentScore++;
            DestroyReward();
        }
    }


    public void DestroyReward()
    {
        Destroy(RewardPrefab);
        SpawnReward();
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
