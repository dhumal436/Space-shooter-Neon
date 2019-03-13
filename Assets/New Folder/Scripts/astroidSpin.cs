using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidSpin : MonoBehaviour {

   
    

    public void Start()
    {

        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * 5;
    }
    private void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundry")
        {
            
            return;
        }
       Destroy(other.gameObject);
        Destroy(gameObject);
    

    }

}
