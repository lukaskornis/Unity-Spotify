using UnityEngine;

public class DanceRotator : MonoBehaviour
{
    public float sensitivity = 10f;

    void Start()
    {
        MusicPlayer.onBeat.AddListener(Dance);
    }

    public void Dance(float volume)
    {
        transform.Rotate(0,0,volume * sensitivity);
    }

}