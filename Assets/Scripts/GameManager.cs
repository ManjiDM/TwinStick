using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour
{

	private bool _playback;
	private ReplaySystem[] replaySystem;
	// Use this for initialization
	void Start ()
	{
		playback = false;

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (CrossPlatformInputManager.GetButton ("Fire1")) {
			playback = true;
		} else
			playback = false;
	}

	public bool playback {
		get {
			return _playback;
		}
		set {
			_playback = value;
		}
	}
}
