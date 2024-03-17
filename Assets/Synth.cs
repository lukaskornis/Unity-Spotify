using UnityEngine;

public class Synth : MonoBehaviour
{
    public float frequency = 440f;
    AudioSource audioSource;

    void callback(float[] samples)
    {
        for(int i = 0; i < samples.Length; i++)
        {
            samples[i] = Mathf.Sin(i / 41000f * 2 * Mathf.PI * 440 * Time.time);
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        AudioClip clip = AudioClip.Create("Sin", 41000 * 3, 1, 41000, true,callback);
        float[] samples = new float[41000 * 3];

        for(int i = 0; i < samples.Length; i++)
        {
	        //samples[i] = Random.Range(-1f, 1f);
            samples[i] = Mathf.Sin(i / 41000f * 2 * Mathf.PI * 853);
            samples[i] += Mathf.Sin(i / 41000f * 2 * Mathf.PI * 960);
        }


        clip.SetData(samples, 0);
        audioSource.clip = clip;
        audioSource.Play();
    }


}