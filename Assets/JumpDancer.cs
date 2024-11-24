using UnityEngine;

public class JumpDancer : MonoBehaviour
{
    public float sensitivity = 10f;

    public void Dance(float volume)
    {
        transform.position = Vector3.up * volume * sensitivity;
    }
}