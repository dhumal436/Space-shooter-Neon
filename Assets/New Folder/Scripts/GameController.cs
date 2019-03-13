using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public Vector3 spawnValues;
    public GameObject hazard0;
    public GameObject hazard1;
    public GameObject hazard2;
    public GameObject hazard;
    public float StopTime, StartTime,waveWait;
    public GameObject Bulet;
    public int HazCount;
   public Material[] s;
    
    // Use this for initialization
    void Start() {
       
        StartCoroutine(SpawnWaves());
    }

    void Tester()
    {
        float check = UnityEngine.Random.Range(1f, 10f);
        if (check < 5 && check > 2)
        {
            hazard = hazard0;
        }
        else if (check > 5)
        {
            hazard = hazard1;
        }
        else if (check < 2)
        {
            hazard = hazard2;
        }
    }

   
   

    // Update is called once per frame
    IEnumerator SpawnWaves() {
        yield return new WaitForSeconds(StartTime);
        while (10>5) { 

        for (int i = 0; i < HazCount; i++)
        {
                Tester();
            Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(hazard, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(StopTime);
        }
            yield return new WaitForSeconds(waveWait);
        }
    }


    public void ChangeBuletColor(int i)
    {
      
           
            Bulet.GetComponent<Renderer>().sharedMaterial = s[i];
        
    }

}
