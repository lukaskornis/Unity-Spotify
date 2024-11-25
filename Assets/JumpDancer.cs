using UnityEngine;

public class JumpDancer : MonoBehaviour
{
    public float sensitivity = 10f;

    void Start()
    {
        MusicPlayer.onBeat.AddListener(Dance);
    }

    public void Dance(float volume)
    {
        transform.position = Vector3.up * volume * sensitivity;
    }
}