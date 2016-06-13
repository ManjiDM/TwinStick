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

		PlayerPrefsManager.UnlockLevel (0);
		print (PlayerPrefsManager.IsLevelUnlocked (1));
		print (PlayerPrefsManager.IsLevelUnlocked (2));
		print (PlayerPrefsManager.IsLevelUnlocked (0));

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
