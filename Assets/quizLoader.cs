using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class quizLoader : MonoBehaviour
{
    public List<Question> questions;
    [Space,Header("Question Data")]
    public TextMeshProUGUI CurrentQuestion;
    public TextMeshProUGUI Title;
    public TextMeshProUGUI optionA;
    public TextMeshProUGUI optionB;
    public TextMeshProUGUI optionC;
    public TextMeshProUGUI optionD;

    [Space,Header("Result")]
    public GameObject panel;
    public GameObject win;
    public GameObject lose;
    public TextMeshProUGUI winMarks;
    public TextMeshProUGUI loseMarks;
    
    private int currentIndex;
    private int questionsLeft;
    private int correctAnswers;
    void Start()
    {
        correctAnswers = 0;
        questionsLeft = questions.Count;
       Load(0);
    }

    public void Load(int index){
        currentIndex = index;
        CurrentQuestion.text = $"{index + 1}";
        Title.text = questions[index].question;
        optionA.text = questions[index].option1;
        optionB.text = questions[index].option2;
        optionC.text = questions[index].option3;
        optionD.text = questions[index].option4;
        Options.Answer = questions[index].correct;
    }

    public void OptionA(){
        Options.currentAnswer = Options.Option.a;
        if(Options.Answer == Options.currentAnswer){
            Correct();
        }else{
            Lost();
        }
    }
    public void OptionB(){
        Options.currentAnswer = Options.Option.b;
        if(Options.Answer == Options.currentAnswer){
           Correct();
        }else{
            Lost();
        }
    }
    public void OptionC(){
        Options.currentAnswer = Options.Option.c;
        if(Options.Answer == Options.currentAnswer){
            Correct();
        }else{
            Lost();
        }
    }
    public void OptionD(){
        Options.currentAnswer = Options.Option.d;
        if(Options.Answer == Options.currentAnswer){
           Correct();
        }else{
            Lost();
        }
    }

    private void Correct(){
        correctAnswers++;
        questionsLeft--;
        currentIndex++;
        if(questionsLeft > 0){
               Load(currentIndex);
        }else{
            Win();
        }
    }
    private void Win(){
        panel.SetActive(false);
        win.SetActive(true);
        winMarks.text = correctAnswers.ToString();
    }
    private void Lost(){
        panel.SetActive(false);
        lose.SetActive(true);
        loseMarks.text = correctAnswers.ToString();
    }
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
