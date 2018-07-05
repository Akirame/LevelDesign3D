using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour
{
	public float speed = 10.0f;
	CharacterController cc;
	
	void Awake()
	{
		cc = GetComponent<CharacterController>();
	}
	
	void Update()
	{
		Vector3 move = Vector3.zero;
		move.z = Input.GetAxis("Horizontal") * speed;
		move.x = Input.GetAxis("Vertical") * -speed;
		cc.SimpleMove(move);
	}	
}
