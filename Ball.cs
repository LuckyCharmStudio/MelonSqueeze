using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float moveSpeed;
    public float maxSpeed;
    public float jumpHeight;
    private Rigidbody2D ballRigid;

	// Use this for initialization
	void Start () {
        ballRigid = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal") * moveSpeed;

        ballRigid.AddForce(Vector2.right * h);

        if (Input.GetButtonDown("Jump"))
        {
            ballRigid.AddForce(Vector2.up * jumpHeight);
        }
        
    }
}
