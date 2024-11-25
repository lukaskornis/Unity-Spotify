using UnityEngine;

public class Jumper : MonoBehaviour
{
    public float sensitivity = 10;
    Vector3 startPos;

    void Start()
    {
        MusicPlayer.onBeat.AddListener(Dance);
        startPos = transform.localPosition;
    }

    public void Dance(float volume)
    {
        transform.localPosition = startPos + Vector3.right * volume * sensitivity;
    }
}