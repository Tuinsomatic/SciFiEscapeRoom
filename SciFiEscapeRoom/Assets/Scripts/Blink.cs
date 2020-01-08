using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public Light lightSource;
    private void Start()
    {
        StartCoroutine("Switch");
    }

    IEnumerator Switch()
    {
        for(; ; )
        {
            lightSource.range = 0;
            yield return new WaitForSeconds(1);
            lightSource.range = 8.53f;
            yield return new WaitForSeconds(1);
        }
    }
}
