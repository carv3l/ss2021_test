using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hazard;
    public Vector3 spawnvalues;
    public int hazardNum;
    public float spawnWait,waitWave;
    void Start()
    {
        StartCoroutine(SpawnWaves());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnWaves() {
        while (true)
        {
            for (int i = 0; i < hazardNum; i++)
            {
                float pos = Random.Range(-spawnvalues.x, spawnvalues.x);
                Vector3 spawnPosition = new Vector3(pos, spawnvalues.y, spawnvalues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
        }
       

    }
}
