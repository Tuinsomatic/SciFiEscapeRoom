using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    public Light lightSource;
    [SerializeField] float time;
    [SerializeField] float strength;

    private void Start()
    {
        StartCoroutine("Switch");
    }

    IEnumerator Switch()
    {
        for(; ; )
        {
            lightSource.range = 0;
            yield return new WaitForSeconds(time);
            lightSource.range = strength;
            yield return new WaitForSeconds(time);
        }
    }
}
