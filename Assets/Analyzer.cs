using UnityEngine;
using UnityEngine.Events;

public class Analyzer : MonoBehaviour
{
	public GameObject cube;
	public AudioSource source;
	public static UnityEvent<float> onVolumeChanged = new();

	void Start()
	{
	}

	void Update()
	{
		var samples = new float[source.clip.frequency / 60];
		source.clip.GetData(samples, source.timeSamples);

		float sum = 0;
		for(int i = 0; i < samples.Length; i++)
		{
			sum += Mathf.Abs(samples[i]);
		}
		var average = sum / samples.Length;
		print(average);
		onVolumeChanged.Invoke(average);
	}
}