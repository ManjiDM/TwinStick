using UnityEngine;
using System.Collections;

public class SelfieStick : MonoBehaviour
{
	[SerializeField]
	private float _panSpeed = 10f;
	private Transform target;
	private Vector3 armRotation;
	// Use this for initialization
	void Start ()
	{
		target = GameObject.FindGameObjectWithTag ("Player").GetComponent <Transform> ();
		armRotation = transform.rotation.eulerAngles;
	}
	
	// Update is called once per frame
	void Update ()
	{
		armRotation.y += Input.GetAxis ("RHorizontal") * panSpeed;
		armRotation.x += Input.GetAxis ("RVertical") * panSpeed;


		transform.position = target.position;
		transform.rotation = Quaternion.Euler (armRotation);
	}

	public float panSpeed {
		get {
			return _panSpeed;
		}
		set {
			_panSpeed = value;
		}
	}
}
