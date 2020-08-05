using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Image timebar;
    public float TotalTime = 10;

    public TMP_Text scoreLabel;
    public TMP_Text questionLabel;

    public TMP_Text[] optionLabel;
    public QuestionData[] questions;
    // Start is called before the first frame update
    void Start()
    {
        scoreLabel.text = "0";

        questionLabel.text = questions[0].question;
        for (int i = 0; i < questions[CurrenteQuestionIndex].options.length; i++)
        {
            optionLabel[i].text = questions[CurrenteQuestionIndex].options[i].option;
        }
    }

    // Update is called once per frame
   private void Update()
    {
        timebar.fillamount -= Time.deltaTime / totaltime;
    }
    public void NextQuestion()
    {
        CurrenteQuestionIndex++;
        questionLabel.text = questions[CurrenteQuestionIndex].question;

        for (int i = 0; i < questions[CurrenteQuestionIndex].options.length; i++)
        {
            optionLabel[i].text = questions[CurrenteQuestionIndex].options[i].option;
        }
    
    }
}

[System.Serializable]
public struct QuestionData 
{
    public string question;
    public Option[] options;
}
[System.Serializable]
public struct Option
{
    public string option;
    public bool isCorrect;
}