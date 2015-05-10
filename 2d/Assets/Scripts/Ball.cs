using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public float ballVelocity = 3000;

	Rigidbody rb;
	bool isPlay;
	int randInt;

	// When Object is created
	void Awake () 
	{
		rb = gameObject.GetComponent<Rigidbody> ();
		randInt = Random.Range (1, 3);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButton(0) == true && isPlay == false)
		{
			transform.parent = null;
			isPlay = true;
			rb.isKinematic = false;
			switch (randInt) {
			case 1:
				rb.AddForce(new Vector3(ballVelocity, ballVelocity, 0));
				break;
			case 2:
				rb.AddForce(new Vector3(-ballVelocity, -ballVelocity, 0));
				break;
			default:
			break;
			}
		}
	}
}
