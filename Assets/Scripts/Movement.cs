using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Rigidbody2D rb;
	private Vector3 left = new Vector3(-1,0,0);
	private Vector3 right = new Vector3(1,0,0);
	public float moveSpeed = 5f;
	public float jumpPower = 5f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		characterController();
	}

	void characterController()
	{
		if(Input.GetKeyDown(KeyCode.A))
		{
		//	rb.velocity = left*moveSpeed;
			rb.AddForce(new Vector2(-1f*moveSpeed,0));
		}
		else if(Input.GetKey(KeyCode.D))
		{
		//	rb.velocity = right*moveSpeed;
			rb.AddForce(new Vector2(1f*moveSpeed,0));
		}
		else if(Input.GetKey(KeyCode.Space))
		{
		//	rb.velocity = transform.up*jumpPower;
			rb.AddForce(new Vector2(0,1*jumpPower));
		}

		//	rb.velocity = new Vector3(0,0,0);

	}
}
