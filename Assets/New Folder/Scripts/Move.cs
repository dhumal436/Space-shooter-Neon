using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float speed;
     
    Rigidbody rb;

  



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
       
        rb.velocity = transform.forward * speed;
       
    }

  

  

}
