using UnityEngine;

public class DancingCube : MonoBehaviour
{
    public float sensitivity = 5;

    void Start()
    {
        MusicPlayer.onBeat.AddListener(Dance);
    }

    public void Dance(float volume)
    {
        transform.localScale = Vector3.one * volume * sensitivity;
    }
}