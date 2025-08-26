using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public List<GameObject> objects;

    private void Start()
    {
        objects.GetRandom();
    }
}
