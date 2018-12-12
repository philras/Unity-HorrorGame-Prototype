using UnityEngine;
using System.Collections;

public class EnemyRandomSpawn : MonoBehaviour {

    public GameObject objectToSpawn;
    public int numberOfEnemies;
    public float spawnRadius = 5;
    private Vector3 spawnPosition;

	void Start () {
        SpawnEnemy();
	}
	
    void SpawnEnemy()
    {
        for(int i = 0; i < numberOfEnemies; i++)
        {
            spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            Vector3 adjustedPosition = new Vector3(spawnPosition.x, 203, spawnPosition.z);
            Instantiate(objectToSpawn, adjustedPosition, Quaternion.identity);
        }
    }
}
