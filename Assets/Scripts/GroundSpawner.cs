using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile;
    private Vector3 nextSpawnPoint;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            SpawnTile();
        }
    }

    public void SpawnTile()
    {
        //Instantiate a ground tile in the nextSpawnPoint with no rotation
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        //Next spawn point is the second child of the Ground gameobject
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
}
