using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSystem : MonoBehaviour
{
    public GameObject selectedPiece;
    public PuzzleSlot s1;
    public PuzzleSlot s2;
    public PuzzleSlot s3;
    public PuzzleSlot s4;
    public PuzzleSlot s5;
    public PuzzleSlot s6;
    public PuzzleSlot s7;
    public PuzzleSlot s8;
    public PuzzleSlot s9;

    public DoorOpen panel;

    bool audioPlayed = false;
    [SerializeField] AudioSource sound;

    void Start()
    {
        selectedPiece = null;
    }

    private void Update()
    {
        if (s1.done == true && s2.done == true && s3.done == true && s4.done == true && s5.done == true && s6.done == true && s7.done == true && s8.done == true && s9.done == true && audioPlayed == false)
        {
            panel.animator.SetBool("puzzleComplete", true);
            sound.Play();
            audioPlayed = true;
        }
    }
}
