using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 180f;

    [SerializeField] Text countdownText;
    public GameManager manager;

    public PasswordInteract input;
    [SerializeField] AudioSource hint1;
    bool hint1Played = false;

    public PickupItem puzzlePiece1;
    public PickupItem puzzlePiece2;
    [SerializeField] AudioSource hint2;
    bool hint2Played = false;

    [SerializeField] AudioSource hint3;
    bool hint3Played = false;

    public PasscodeInteract combo;

    private void Start()
    {
        {
            currentTime = startingTime;
        }
    }
    private void Update()
    {
        {
            if (combo.complete == false)
            {
                currentTime -= 1 * Time.deltaTime;
                //countdownText.text = ("0"+(currentTime/60).ToString("0")+":"+(currentTime-120).ToString());
                countdownText.text = currentTime.ToString("0");
            }


            if (currentTime <= 120 && input.complete == false && hint1Played == false)
            {
                hint1.Play();
                hint1Played = true;
            }
            if (currentTime <= 60)
            {
                countdownText.color = Color.yellow;
                if (puzzlePiece1.moved == false || puzzlePiece2.moved == false)
                {
                    if (hint2Played == false)
                    {
                        hint2.Play();
                        hint2Played = true;
                    } 
                }
            }
            if (currentTime <= 30 && hint3Played == false)
            {
                hint3.Play();
                hint3Played = true;
            }
            if (currentTime <= 20)
            {
                countdownText.color = Color.red;
            }

            if (currentTime <= 0)
            {
                currentTime = 0;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                manager.EndGame();
            } 
        }
        if (combo.complete == true)
        {
            StartCoroutine("End");
        }
    }
    IEnumerator End()
    {
        yield return new WaitForSeconds(22);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        manager.EndGame();
    }
}
