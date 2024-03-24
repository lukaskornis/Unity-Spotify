using UnityEngine;

public class CircleDancer : MonoBehaviour
{
    public GameObject prefab;
    public int count = 2;
    public float radius = 5;
    public float rotateSpeed = 360;
    public float sensitivity = 2;

    void Start()
    {
        Analyzer.onVolumeChanged.AddListener(Dance);

        for (int i = 0; i < count; i++)
        {
            var angle = i * Mathf.PI * 2 / count;

            var x = Mathf.Cos(angle);
            var y = Mathf.Sin(angle);

            var pos = new Vector3(x, y, 0) * radius;
            var obj = Instantiate(prefab, pos, Quaternion.identity,transform);
            obj.transform.LookAt(transform);
        }
    }

    public void Dance(float volume)
    {
        transform.Rotate(0,0,Mathf.Pow(volume,sensitivity) * Time.deltaTime * rotateSpeed);
        transform.localScale = Vector3.one * 5f * volume;
    }
}