using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnDelay = 5.0f;
    public float spawnTime = 3.0f;
    public GameObject[] enemies;

    private Vector3 tempTran;
    private Vector3 oriTran;

    void Start(){
      InvokeRepeating("Spawn",spawnDelay,spawnTime);
      oriTran = transform.position;
    }

    void Spawn(){
      int enemyIndex = Random.Range(0,enemies.Length);
      tempTran = transform.position;
      tempTran.x += transform.position.x * Random.Range(-0.3f,0.3f);
      transform.position = tempTran;
      Instantiate(enemies[enemyIndex],transform.position, transform.rotation);
      transform.position = oriTran;

    }
}
