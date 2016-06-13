using UnityEngine;
using System.Collections;

public class CameraPan : MonoBehaviour
{
	// The target we are following
	private Transform target;
	// Use this for initialization
	void Start ()
	{
		target = GameObject.FindGameObjectWithTag ("Player").GetComponent <Transform> ();
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
		if (!target)
			return;
		print ("RHorizontal " + Input.GetAxis ("RHorizontal"));
		print ("RVertical " + Input.GetAxis ("RVertical"));
		transform.LookAt (target);
	}

}
