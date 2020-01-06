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

    private void Start()
    {
        {
            currentTime = startingTime;
        }
    }
    private void Update()
    {
        {
            currentTime -= 1 * Time.deltaTime;
            //countdownText.text = ("0"+(currentTime/60).ToString("0")+":"+(currentTime-120).ToString());
            countdownText.text = currentTime.ToString("0");

            if (currentTime <= 60)
            {
                countdownText.color = Color.yellow;
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
    }
}
