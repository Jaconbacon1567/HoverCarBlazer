using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    Rigidbody rb;
    Vector3 movement;
    
    float speed =20;

	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {
      
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
      
        rb.velocity = (movement * speed);       
        
	}
}
