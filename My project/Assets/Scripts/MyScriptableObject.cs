using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyWave", menuName = "EnemySpawn")]

public class MyScriptableObject : ScriptableObject
{
    public GameObject enemy;
    public int spawnAmount = 5;
    public float spawnDelay = 0.5f;

    public string saySomething = "hey";
}
