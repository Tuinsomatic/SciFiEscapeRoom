using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasscodeInteract : MonoBehaviour
{
    public Image img;
    public GameObject inp1;
    public GameObject inp2;
    public GameObject inp3;
    public GameObject inp4;
    bool active;
    int position;
    string letter = "_";
    bool debounce = false;
    bool complete = false;

    public DoorOpen doorPanel1;
    public DoorOpen doorPanel2;

    void Start()
    {
        img.color = Color.clear;
        inp1.GetComponent<Text>().color = Color.clear;
        inp2.GetComponent<Text>().color = Color.clear;
        inp3.GetComponent<Text>().color = Color.clear;
        inp4.GetComponent<Text>().color = Color.clear;

        active = false;
        position = 1;
        StartCoroutine("Debounce");
    }

    private void OnMouseOver()
    {
        GetComponent<Light>().range = 2;
        if (Input.GetMouseButtonDown(0) && complete == false)
        {
            img.color = Color.white;
            inp1.GetComponent<Text>().color = Color.black;
            inp2.GetComponent<Text>().color = Color.black;
            inp3.GetComponent<Text>().color = Color.black;
            inp4.GetComponent<Text>().color = Color.black;
            active = true;
        }
    }

    private void OnMouseExit()
    {
        GetComponent<Light>().range = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            img.color = Color.clear;
            inp1.GetComponent<Text>().color = Color.clear;
            inp2.GetComponent<Text>().color = Color.clear;
            inp3.GetComponent<Text>().color = Color.clear;
            inp4.GetComponent<Text>().color = Color.clear;
            active = false;
            position = 1;
        }
        if (active == true)
        {
            if (debounce == false)
            {
                if (Input.anyKey)
                {
                    debounce = true;
                    if (Input.GetKeyDown(KeyCode.Alpha1))
                    {
                        letter = "1";
                    }
                    else if (Input.GetKeyDown(KeyCode.Alpha2))
                    {
                        letter = "2";
                    }
                    else if (Input.GetKeyDown(KeyCode.Alpha3))
                    {
                        letter = "3";
                    }
                    else if (Input.GetKeyDown(KeyCode.Alpha4))
                    {
                        letter = "4";
                    }
                    else if (Input.GetKeyDown(KeyCode.Alpha5))
                    {
                        letter = "5";
                    }
                    else if (Input.GetKeyDown(KeyCode.Alpha6))
                    {
                        letter = "6";
                    }
                    else if (Input.GetKeyDown(KeyCode.Alpha7))
                    {
                        letter = "7";
                    }
                    else if (Input.GetKeyDown(KeyCode.Alpha8))
                    {
                        letter = "8";
                    }
                    else if (Input.GetKeyDown(KeyCode.Alpha9))
                    {
                        letter = "9";
                    }

                    if (letter != "_")
                    {
                        if (position == 1)
                        {
                            inp1.GetComponent<Text>().text = letter;
                            position += 1;
                        }
                        else if (position == 2)
                        {
                            inp2.GetComponent<Text>().text = letter;
                            position += 1;
                        }
                        else if (position == 3)
                        {
                            inp3.GetComponent<Text>().text = letter;
                            position += 1;
                        }
                        else if (position == 4)
                        {
                            inp4.GetComponent<Text>().text = letter;
                            position = 1;
                        }
                    }
                    letter = "_";
                }
            }
        }
        if (inp1.GetComponent<Text>().text == "7" && inp2.GetComponent<Text>().text == "3" && inp3.GetComponent<Text>().text == "1" && inp4.GetComponent<Text>().text == "6")
        {
            img.color = Color.clear;
            inp1.GetComponent<Text>().color = Color.clear;
            inp2.GetComponent<Text>().color = Color.clear;
            inp3.GetComponent<Text>().color = Color.clear;
            inp4.GetComponent<Text>().color = Color.clear;
            active = false;
            position = 1;
            complete = true;
            doorPanel1.animator.SetBool("codeCorrect", true);
            doorPanel2.animator.SetBool("codeCorrect", true);
        }
    }

    IEnumerator Debounce()
    {
        for (; ; )
        {
            debounce = false;
            yield return new WaitForSeconds(0.01f);
        }
    }
}

