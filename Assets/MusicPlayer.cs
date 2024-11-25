using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class MusicPlayer : MonoBehaviour
{
    AudioSource source;
    public TMP_Text musicNameText;
    public TMP_Text musicLengthText;
    public Transform dancer;
    public UnityEvent<float> onBeat;

    void Start()
    {
        source = GetComponent<AudioSource>();
        musicNameText.text = source.clip.name;
        musicLengthText.text = source.clip.length.ToString();
    }

    void Update()
    {
        float[] data = new float[512];
        source.clip.GetData(data, source.timeSamples);

        float sum = 0;
        foreach (float sample in data)
        {
            sum += Mathf.Abs(sample);
        }
        onBeat.Invoke(sum / data.Length );
    }

    public void Pause()
    {

    }

    public void SetTime(float time)
    {
        source.time = time;
    }
}