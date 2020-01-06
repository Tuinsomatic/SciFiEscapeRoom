using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePiece : MonoBehaviour
{
    public PuzzleSystem main;
    public GameObject thisPiece;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            main.selectedPiece = thisPiece;
        }
    }
}
