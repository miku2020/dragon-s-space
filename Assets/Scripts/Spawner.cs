using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject EnemyObject;
    public GameObject RouteObject;
    public float Timer;
    public int amount;
    private int spawned;

    // Start is called before the first frame update
    void Start()
    {
        spawned = 1;
        StartCoroutine(SpawnTimer());
        Debug.Log("timer started");
    }

    IEnumerator SpawnTimer()
    {
        if(spawned != amount){
            yield return new WaitForSeconds(Timer);
            Spawn();    
            StartCoroutine(SpawnTimer());
            spawned++;
            Debug.Log(spawned-1);
        } 
    }

    public void Spawn() 
    {
        Instantiate(EnemyObject, RouteObject.transform.parent);
    }
}
