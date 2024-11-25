using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;
    public TMP_Text musicNameText;
    public TMP_Text musicTimeText;
    public static UnityEvent<float> onBeat = new();

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        musicNameText.text = audioSource.clip.name;
        musicTimeText.text = audioSource.clip.length.ToString();
    }

    void Update()
    {
        float[] data = new float[1024];
        audioSource.clip.GetData(data, audioSource.timeSamples); // sample rate 44100hz
        onBeat.Invoke(data[1000]);
    }

    public void Pause()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.Play();
        }
    }

    public void SetTime(float time)
    {
        audioSource.time = time;
    }

    public void SetVolume(float value)
    {

    }
}