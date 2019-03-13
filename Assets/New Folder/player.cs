using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Boundry
{
    public float xMin, zMin, xMax, zMax;

}

public class player : MonoBehaviour {
    public float speed;
    public float tilt;
    public Boundry boundary;
    Rigidbody rb;
    public float moveVertical;
    public float moveHorizontal;
    Transform BuletPos;// from whre bullet is fire
    GameObject Bulet;

    // Use this for initialization
    void Start () {
     rb = GetComponent<Rigidbody>();
	}

    private void Update()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate () {
        if (Input.touchCount>0&& Input.GetTouch(0).phase==TouchPhase.Moved)
        {
           Vector2 touch = Input.GetTouch(0).position;
             moveHorizontal = touch.x;
             moveVertical = touch.y;

        }
        

        Vector3 Movement = new Vector3(moveHorizontal,0f,moveVertical);
        rb.velocity = Movement *speed;
      rb.position = new Vector3
        (
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
        );
        

        

    }
}
