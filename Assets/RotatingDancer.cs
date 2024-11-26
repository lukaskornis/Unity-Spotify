using UnityEngine;

public class RotatingDancer : MonoBehaviour
{
	public float bias = 0.5f;
	public float sensitivity = 2;
	public float speed = 5;

	void Start()
	{
		MusicPlayer.onBeat.AddListener(Dance);
	}

	public void Dance(float volume)
	{
		transform.Rotate(0,0,bias + Mathf.Pow(volume,sensitivity) * speed);
	}
}