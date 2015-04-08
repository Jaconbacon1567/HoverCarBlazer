using UnityEngine;
using System.Collections;
using System.Xml.Schema;

[System.Serializable]
public class Boundary
{
    public float XMin, XMax, ZMin, ZMax;
}

public class PlayerMovement : MonoBehaviour {

    Rigidbody rb;
    Vector3 movement;
    
    public float speed;

    public Boundary bounds;

	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float moveHorizontal = Input.GetAxis("Horizontal");
	  //float moveVertical = Input.GetAxis("Vertical");// Its here where the movement problem is happening when added to horizontal movement

        movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
      
        rb.velocity = (movement * speed);
	}

    void FixedUpdate()
    {
        rb.position = new Vector3(
                                  Mathf.Clamp(rb.position.x, bounds.XMin, bounds.XMax), //x
                                  0.0f,                                //y
                                  0.0f //z
                                  );
    }
}
