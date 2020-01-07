using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePiece : MonoBehaviour
{
    public PuzzleSystem main;
    public GameObject thisPiece;

    void OnMouseOver()
    {
        GetComponent<Light>().range = 2;
        if (Input.GetMouseButtonDown(0))
        {
            main.selectedPiece = thisPiece;
        }
    }

    private void OnMouseExit()
    {
        GetComponent<Light>().range = 0;
    }
}
