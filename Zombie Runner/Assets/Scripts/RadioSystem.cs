using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour
{

	public AudioClip initialHelicall;
	public AudioClip initialCallReply;

	private AudioSource audioSource;

	// Use this for initialization
	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	void OnMakeInitialHeliCall()
	{
		print(name + "OnMakeInitialHeliCall");
		audioSource.clip = initialHelicall;
		audioSource.Play();
		Invoke("InitialReply", initialHelicall.length + 1f);
	}

	void InitialReply()
	{
		audioSource.clip = initialCallReply;
		audioSource.Play();
		BroadcastMessage("OnDispatchHelicopter");
	}

}
