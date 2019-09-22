using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject parachute;
    public float respawnTime = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemyWave());
    }

    void spawnEnemy()
    {
        GameObject go = Instantiate(parachute) as GameObject;
        go.transform.position = new Vector2(5.44f, 5.07f);
    }

    IEnumerator enemyWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
