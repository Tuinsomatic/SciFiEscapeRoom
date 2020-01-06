using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Room");
    }

    public void EndGame() //no spoilers pls
    {
        SceneManager.LoadScene("Title Screen");
    }

}
