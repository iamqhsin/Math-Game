using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamesController : MonoBehaviour {
    public string RandomOperator;
    public int ans;
    public GameObject question;
    public GameObject Option1;
    public GameObject Option2;
    public GameObject Option3;
    public int Repeat;


    // Use this for initialization
    void Start () {
        GenerateQuestion();
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Repeat == 1){
            GenerateQuestion();
            Repeat = 0;
        }
	}
    public void GenerateQuestion()
    {
        int a = Random.Range(0, 101);
        int b = Random.Range(0, 101);
        int option = Random.Range(0, 3);
        int OperatorNumber = Random.Range(0, 3);
        if (OperatorNumber == 0){
            RandomOperator = "+";
            ans = a + b;
        }
        else if(OperatorNumber == 1){
            RandomOperator = "*";
            ans = a * b;
        }
        else{
            RandomOperator = "-";
            ans = a - b;
        }
        question.GetComponent<TextMesh>().text = a + " " + RandomOperator + " " + b + " = ?";


        if (option == 0){
            Option1.GetComponent<TextMesh>().text = ans.ToString();
            Option2.GetComponent<TextMesh>().text = (ans + Random.Range(-2,3)).ToString();
            Option3.GetComponent<TextMesh>().text = (ans + Random.Range(-2, 3)).ToString();
            Option1.GetComponent<option>().isCorrect = 1;
            Option2.GetComponent<option>().isCorrect = 4;
            Option3.GetComponent<option>().isCorrect = 4;
            Option1.GetComponent<option>().control = 0;
            Option2.GetComponent<option>().control = 0;
            Option3.GetComponent<option>().control = 0;

        }
        else if(option == 1){
            Option1.GetComponent<TextMesh>().text = (ans + Random.Range(-2, 3)).ToString();
            Option2.GetComponent<TextMesh>().text = ans.ToString();
            Option3.GetComponent<TextMesh>().text = (ans + Random.Range(-2, 3)).ToString();
            Option1.GetComponent<option>().isCorrect = 4;
            Option2.GetComponent<option>().isCorrect = 1;
            Option3.GetComponent<option>().isCorrect = 4;
            Option1.GetComponent<option>().control = 1;
            Option2.GetComponent<option>().control = 1;
            Option3.GetComponent<option>().control = 1;
        }
        else{
            Option1.GetComponent<TextMesh>().text = (ans + Random.Range(-2, 3)).ToString();
            Option2.GetComponent<TextMesh>().text = (ans + Random.Range(-2, 3)).ToString();
            Option3.GetComponent<TextMesh>().text = ans.ToString();
            Option1.GetComponent<option>().isCorrect = 4;
            Option2.GetComponent<option>().isCorrect = 4;
            Option3.GetComponent<option>().isCorrect = 1;
            Option1.GetComponent<option>().control = 2;
            Option2.GetComponent<option>().control = 2;
            Option3.GetComponent<option>().control = 2;
        }

    }
}
