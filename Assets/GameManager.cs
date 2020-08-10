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

    private int CurrentQuestionIndex; 
    // Start is called before the first frame update
    void Start()
    {
        scoreLabel.text = "0";

        questionLabel.text = questions[0].question;

        optionLabel[0].text = questions[0].options[0].option;

        for (int i = 0; i < questions[0].options.Length; i++)
        {

            optionLabel[i].text = questions[0].options[i].option;

        }
    }

    // Update is called once per frame
    private void Update()
    {
        timebar.fillAmount -= Time.deltaTime / TotalTime;
    }
    public void NextQuestion()
    {
        CurrentQuestionIndex++;
        questionLabel.text = questions[CurrentQuestionIndex].question;

        for (int i = 0; i < questions[CurrentQuestionIndex].options.Length; i++)
        {
            optionLabel[i].text = questions[CurrentQuestionIndex].options[i].option;
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
