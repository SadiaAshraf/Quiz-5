using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefab;
    private GameObject temp;
    PathScript pathScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawner", 2, 1);
    }

    public void Spawner()
    {
        int index = Random.Range(0, ballPrefab.Length);
        temp = Instantiate(ballPrefab[index], transform.position, transform.rotation);
        pathScript = temp.GetComponent<PathScript>();
        pathScript.enabled = true;
    }
}
