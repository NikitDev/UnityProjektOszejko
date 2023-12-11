using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    private float timeUntilSpawn = 0f;
    private float respawnCooldown = 1f;

    [SerializeField] public List<GameObject> enemyPrefabs;
    [SerializeField] private List<Transform> spawnPoints;

    void Update()
    {
        timeUntilSpawn -= Time.deltaTime;

        if (timeUntilSpawn <= 0f)
        {
            SpawnEnemies();
            timeUntilSpawn = respawnCooldown;
        }
    }

    private void SpawnEnemies()
    {
        int randomSpawnPointIndex = Random.Range(0, spawnPoints.Count);
        Transform spawnPoint = spawnPoints[randomSpawnPointIndex];

        int randomEnemyIndex = Random.Range(0, enemyPrefabs.Count);
        GameObject enemy = enemyPrefabs[randomEnemyIndex];

        GameObject newEnemy = Instantiate(enemy, spawnPoint.position, Quaternion.identity);
        EnemyMove enemyMoveScript = newEnemy.GetComponent<EnemyMove>();

        if (spawnPoint.position.x > 0)
        {
            newEnemy.GetComponent<SpriteRenderer>().flipX = true;
            enemyMoveScript.SetDirection(new Vector2(-1f, 0f));
        }

    }
}
