using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{   [SerializeField]
    private float FireTime;
    private float FireRate= .25f;
   
    public float speed;
    public float tilt;
    public Boundary boundary;
    Rigidbody rb;
    public Transform BuletPos;// from whre bullet is fire
    public GameObject Bulet;
    private void Start()
    {
        
        rb=GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetButton("Fire1")&&FireTime < Time.time)
        {
            FireTime = Time.time + FireRate;
            Instantiate(Bulet, BuletPos.position, Bulet.transform.rotation);
        }
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;

        rb.position = new Vector3
        (
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
        );
        
        rb.rotation = Quaternion.Euler(90, 0.0f, rb.velocity.x * -tilt);
    }
    

}