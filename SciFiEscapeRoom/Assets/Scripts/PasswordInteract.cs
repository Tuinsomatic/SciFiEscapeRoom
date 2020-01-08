using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordInteract : MonoBehaviour
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
    public bool complete = false;

    [SerializeField] AudioSource doorSound;
    [SerializeField] AudioSource beepSound;
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
                if (Input.GetKeyUp(KeyCode.B) || Input.GetKeyUp(KeyCode.C) || Input.GetKeyUp(KeyCode.E) || Input.GetKeyUp(KeyCode.F) || Input.GetKeyUp(KeyCode.G) || Input.GetKeyUp(KeyCode.H) || Input.GetKeyUp(KeyCode.I) || Input.GetKeyUp(KeyCode.J) || Input.GetKeyUp(KeyCode.K) || Input.GetKeyUp(KeyCode.L) || Input.GetKeyUp(KeyCode.M) || Input.GetKeyUp(KeyCode.N) || Input.GetKeyUp(KeyCode.O) || Input.GetKeyUp(KeyCode.P) || Input.GetKeyUp(KeyCode.Q) || Input.GetKeyUp(KeyCode.R) || Input.GetKeyUp(KeyCode.T) || Input.GetKeyUp(KeyCode.U) || Input.GetKeyUp(KeyCode.V) || Input.GetKeyUp(KeyCode.Y) || Input.GetKeyUp(KeyCode.Z))
                {
                    beepSound.Play();
                }
                if (Input.anyKey)
                {
                    debounce = true;
                    if (Input.GetKeyDown(KeyCode.B))
                    {
                        letter = "b";
                    }
                    else if (Input.GetKeyDown(KeyCode.C))
                    {
                        letter = "c";
                    }
                    else if (Input.GetKeyDown(KeyCode.E))
                    {
                        letter = "e";
                    }
                    else if (Input.GetKeyDown(KeyCode.F))
                    {
                        letter = "f";
                    }
                    else if (Input.GetKeyDown(KeyCode.G))
                    {
                        letter = "g";
                    }
                    else if (Input.GetKeyDown(KeyCode.H))
                    {
                        letter = "h";
                    }
                    else if (Input.GetKeyDown(KeyCode.I))
                    {
                        letter = "i";
                    }
                    else if (Input.GetKeyDown(KeyCode.J))
                    {
                        letter = "j";
                    }
                    else if (Input.GetKeyDown(KeyCode.K))
                    {
                        letter = "k";
                    }
                    else if (Input.GetKeyDown(KeyCode.L))
                    {
                        letter = "l";
                    }
                    else if (Input.GetKeyDown(KeyCode.M))
                    {
                        letter = "m";
                    }
                    else if (Input.GetKeyDown(KeyCode.N))
                    {
                        letter = "n";
                    }
                    else if (Input.GetKeyDown(KeyCode.O))
                    {
                        letter = "o";
                    }
                    else if (Input.GetKeyDown(KeyCode.P))
                    {
                        letter = "p";
                    }
                    else if (Input.GetKeyDown(KeyCode.Q))
                    {
                        letter = "q";
                    }
                    else if (Input.GetKeyDown(KeyCode.R))
                    {
                        letter = "r";
                    }
                    else if (Input.GetKeyDown(KeyCode.T))
                    {
                        letter = "t";
                    }
                    else if (Input.GetKeyDown(KeyCode.U))
                    {
                        letter = "u";
                    }
                    else if (Input.GetKeyDown(KeyCode.V))
                    {
                        letter = "v";
                    }
                    else if (Input.GetKeyDown(KeyCode.Y))
                    {
                        letter = "y";
                    }
                    else if (Input.GetKeyDown(KeyCode.Z))
                    {
                        letter = "z";
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
        if (inp1.GetComponent<Text>().text == "f" && inp2.GetComponent<Text>().text == "o" && inp3.GetComponent<Text>().text == "u" && inp4.GetComponent<Text>().text == "r" && complete == false)
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
            doorSound.Play();
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
