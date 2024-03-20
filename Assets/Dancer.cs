using UnityEngine;

public class Dancer : MonoBehaviour
{
    public GameObject danceObject;

    void Start()
    {
	    GetComponent<Analyzer>().onVolumeChanged.AddListener(Dance);
    }


    public void Dance(float volume)
    {
       // print(volume);
        danceObject.transform.localScale = Vector3.one * ( 0.5f +  volume * 10);
    }
}