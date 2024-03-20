using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDancer : MonoBehaviour
{
    public GameObject prefab;
    public int count = 2;
    public float radius = 5;

    void Start()
    {
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

    }
}