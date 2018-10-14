using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option : MonoBehaviour
{
    public GameObject Option1;
    public GameObject Option2;
    public GameObject Option3;
    public int isCorrect;
    public int control;
    private void OnMouseDown()
    {

        if (control == 0)
        {
            Option1.GetComponent<TextMesh>().color = new Color(1f, 0.4f, 0f);
        }
        else if (control == 1){
            Option2.GetComponent<TextMesh>().color = new Color(1f, 0.4f, 0f);
        }
        else{
            Option3.GetComponent<TextMesh>().color = new Color(1f, 0.4f, 0f);
        }

        if (isCorrect == 1)
        {
            GetComponent<TextMesh>().color = Color.green;
        }
        else
        {
            GetComponent<TextMesh>().color = Color.red;

        }
    }

    private void OnMouseExit()
    {
        Option1.GetComponent<TextMesh>().color = Color.white;
        Option2.GetComponent<TextMesh>().color = Color.white;
        Option3.GetComponent<TextMesh>().color = Color.white;
    }
}
