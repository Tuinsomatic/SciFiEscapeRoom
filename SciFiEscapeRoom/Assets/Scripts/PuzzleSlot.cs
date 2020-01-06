using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSlot : MonoBehaviour
{
    public GameObject requiredPiece;
    public PuzzleSystem main;
    public bool done = false;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (requiredPiece == main.selectedPiece)
            {
                requiredPiece.transform.position = this.transform.position;
                requiredPiece.transform.rotation = this.transform.rotation;
                this.transform.position += Vector3.left;
                done = true;
            }
        }
    }
}
