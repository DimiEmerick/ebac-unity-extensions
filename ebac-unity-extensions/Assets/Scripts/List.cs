using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public List<GameObject> objects;

    private void Start()
    {
        var randomObj = objects.GetRandom();
        randomObj.transform.position += Vector3.up * 3;
        Debug.Log(randomObj.name);
    }
}
