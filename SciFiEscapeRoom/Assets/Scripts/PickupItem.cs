using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public float z;
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = new Vector3(-6.177f, 0.09f, z);
        }
    }
}
