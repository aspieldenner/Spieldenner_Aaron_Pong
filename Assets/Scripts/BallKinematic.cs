using UnityEngine;
using System.Collections;

public class BallKinematic : MonoBehaviour {

	float ballSpeed = 10.0f;


	void Start() {

	}


	void Update () {

		//we are using the transform component to move the object, there are many more options that can be found here:
		//http://docs.unity3d.com/ScriptReference/Transform.Translate.html
		//http://docs.unity3d.com/ScriptReference/Vector3.html

		//also note the use of a time function/method
		//http://docs.unity3d.com/ScriptReference/Time-deltaTime.html

		//		transform.Translate(Vector2.left * ballSpeed*Time.deltaTime);
		transform.Translate (new Vector2(-0.5f, -0.5f)* ballSpeed*Time.deltaTime);

	}

	void OnCollisionEnter(Collision collisionInfo)
	{
		rigidbody.AddForce(Vector3.Reflect(direction, 
			collisionInfo.contacts[0].normal) * mag,   
			ForceMode.Impulse);
	}
}