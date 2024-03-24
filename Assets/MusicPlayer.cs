using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    AudioSource source;
    public Slider timeSlider;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (source.isPlaying)
        {
            timeSlider.SetValueWithoutNotify( timeSlider.value + Time.deltaTime);
        }
    }
}