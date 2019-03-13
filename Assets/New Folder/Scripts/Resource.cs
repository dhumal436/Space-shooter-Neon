using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour {
    [SerializeField]
    private int ID;
    public GameController gameController;

    private void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter(Collider other)
    {
     
        gameController.ChangeBuletColor(ID);
    }

}

