﻿using UnityEngine;
using System.Collections;
using System;

public class ReplaySystem: MonoBehaviour
{
	private const int bufferFrames = 200;
	private Keyframe[] keyFrames = new Keyframe[bufferFrames];
	private Rigidbody rBody;
	private GameManager manager;
	// Use this for initialization

	void Start ()
	{
		rBody = GetComponent <Rigidbody> ();
		manager = GameObject.FindObjectOfType <GameManager> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (manager.playback) {
			Playback ();
		} else {
			Record ();
		}

	}

	void Playback ()
	{
		rBody.isKinematic = true;
		int frame = Time.frameCount % bufferFrames;
		transform.position = keyFrames [frame].position;
		transform.rotation = keyFrames [frame].rotation;
	}

	void Record ()
	{
		rBody.isKinematic = false;
		int frame = Time.frameCount % bufferFrames;
		float time = Time.time;
		keyFrames [frame] = new Keyframe (Time.time, transform.position, transform.rotation);
	}
}

public struct Keyframe
{
	private float timeFrame;
	private Vector3 pos;
	private Quaternion rot;

	public Keyframe (float time, Vector3 pos, Quaternion rot)
	{
		this.timeFrame = time;
		this.pos = pos;
		this.rot = rot;
	}

	public float time {
		get {
			return timeFrame;
		}
		set {
			timeFrame = value;
		}
	}

	public Vector3 position {
		get {
			return pos;
		}
		set {
			pos = value;
		}
	}

	public Quaternion rotation {
		get {
			return rot;
		}
		set {
			rot = value;
		}
	}
}
