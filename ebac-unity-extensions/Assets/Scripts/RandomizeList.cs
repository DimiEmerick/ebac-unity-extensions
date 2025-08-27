using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RandomizeList
{
#if UNITY_EDITOR
    [UnityEditor.MenuItem("Ebac/Test")]
    public static void Test()
    {
        Debug.Log("Teste");
    }
    
    [UnityEditor.MenuItem("Ebac/Test 2 %g")]
    public static void Test2()
    {
        Debug.Log("Teste");
    }
#endif

    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

    public static T GetRandomButNotSame<T>(this List<T> list, T unique)
    {
        if (list.Count == 1)
            return unique;

        int randomIndex = Random.Range(0, list.Count);
        return list[randomIndex];
    }
}
