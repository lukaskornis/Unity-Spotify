using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;
    public TMP_Text nameText;
    public TMP_Text lengthText;
    public UnityEvent<float> onBeat;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        nameText.text = audioSource.clip.name;

        // format float to minutes:seconds
        int minutes = (int)audioSource.clip.length / 60;
        int seconds = (int)audioSource.clip.length % 60;
        lengthText.text = minutes + ":" + string.Format( "{0:00}", seconds );
    }

    void Update()
    {
        float[] samples = new float[100];
        audioSource.clip.GetData(samples, audioSource.timeSamples);
        onBeat.Invoke(samples[0]);
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