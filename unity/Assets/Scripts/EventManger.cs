using UnityEngine;
using System.Collections;

public class EventManger : MonoBehaviour {
	//public delegate void CollideHandler (bool isCollide);
	//public static event CollideHandler onCollide;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnCollisionEnter(Collision hit)
	{
		if (hit.gameObject.tag == "cube1")
		{
			GameObject.Find("Sphere").renderer.material.color = Color.red;
		}
		if (hit.gameObject.tag == "cube2")
		{			
			GameObject.Find("Sphere").renderer.material.color = Color.yellow;		
		}
	}
}
