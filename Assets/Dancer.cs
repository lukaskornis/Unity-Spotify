using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dancer : MonoBehaviour
{
	[Range(0,5)]public float rotateSpeed;

	void Start()
	{
		Analyzer.onVolumeChanged.AddListener(Dance);
	}

	public void Dance(float volume)
	{
		transform.Rotate(0,0,-0.1f + volume * rotateSpeed);
		transform.position = Vector3.Lerp(new Vector3(0, 0, 0), new Vector3(3, 2, 0), volume * 5);
	}
}