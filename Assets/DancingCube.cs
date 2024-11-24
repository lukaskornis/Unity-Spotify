using UnityEngine;

public class DancingCube : MonoBehaviour
{
    public float sensitivity = 5;
    public void Dance(float volume)
    {
        transform.localScale = Vector3.one * volume * sensitivity;
    }
}