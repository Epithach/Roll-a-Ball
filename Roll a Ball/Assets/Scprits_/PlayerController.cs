using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Rigidbody       rb;
    public float            moveHorizontal;
    public float            moveVertical;
    public float            speed;

    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
        this.moveHorizontal = Input.GetAxis("Horizontal");
        this.moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(this.moveHorizontal, 0.0f, this.moveVertical);

        rb.AddForce(movement * this.speed);
	}
}
