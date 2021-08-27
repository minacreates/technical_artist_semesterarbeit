using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characte2DController : MonoBehaviour
{
	public float speed;
	public float jump;
	
	private float move;
	private Rigidbody2D rb;
	
	void Start()
	{
		rb= GetComponent<Rigidbody2D>();
	}
	
	
	void Update()
	{
			move = Input.GetAxisRaw("Horizontal");
			
			rb.velocity = new Vector2(move * speed, rb.velocity.y);
			if(Input.GetButtonDown("Jump"))
			{
			rb.AddForce(new Vector2(rb.velocity.x, jump));	
			}
	}
 

}