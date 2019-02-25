using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveBall : MonoBehaviour {
	public float BallSpeed;
	Vector3 position;
	bool currntPlatformAndroid = false;
	Rigidbody2D rb;
	void Awake()
	{
		rb = GetComponent<Rigidbody2D> ();
		#if UNITY_ANDROID
		currntPlatformAndroid = true;
		#else
		currntPlatformAndroid=false;
		#endif
	}

	// Use this for initialization
	void Start () {
		position = transform.position;
		if (currntPlatformAndroid == true){
			Debug.Log ("Android");
	}else{
		Debug.Log("Windows");
	}
	}
	
	// Update is called once per frame
	void Update () {
		if (currntPlatformAndroid == true) {
			//android specific code
		} else {
			if (Input.GetKey (KeyCode.UpArrow)) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, BallSpeed);
			}
			if (Input.GetKey (KeyCode.RightArrow)) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (BallSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			}
			if (Input.GetKey (KeyCode.LeftArrow)) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (-BallSpeed, GetComponent<Rigidbody2D> ().velocity.y);

			}
		}
	}
	public void Up()
	{
		rb.velocity = new Vector2 (0, BallSpeed);
	}
	public void Down()
	{
		rb.velocity = new Vector2 (0, -BallSpeed);
	}
	public void Right()
	{
		rb.velocity = new Vector2 (BallSpeed, 0);
	}
	public void Left()
	{
		rb.velocity = new Vector2 (-BallSpeed, 0);
	}
	public void SetVelocityZero()
	{
		rb.velocity = Vector2.zero;
	}
}
