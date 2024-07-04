using UnityEngine;

public class GroundTIle : MonoBehaviour
{
    GroundSpawner groundSpawner;

    public GameObject enemyPrefab;


    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnEnemies();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    private void SpawnEnemies()
    {
        //choose a random point to spawn the enemy
        int enemySpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(enemySpawnIndex).transform;
        
        //spawn the enemy at the position
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity, transform);
    }
}
