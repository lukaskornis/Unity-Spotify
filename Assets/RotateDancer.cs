using UnityEngine;

public class RotateDancer : MonoBehaviour
{
	public float sensitivity = 10;

	void Start()
	{
		MusicPlayer.onBeat.AddListener(Dance);
	}

	public void Dance(float volume)
	{
		transform.Rotate(0,0,volume * sensitivity);
	}
}