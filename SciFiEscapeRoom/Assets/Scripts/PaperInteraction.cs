using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperInteraction : MonoBehaviour
{

    public Image img;

    void Start()
    {
        img.color = Color.clear;
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            img.color = Color.white;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            img.color = Color.clear;
        }
    }
}
