using UnityEngine;
using UnityEngine.Events;

public class Analyzer : MonoBehaviour
{
	public GameObject cube;
	public AudioSource source;
	public UnityEvent<float> onVolumeChanged;

	void Start()
	{
		source.time = 30;
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