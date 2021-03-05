using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsBehaviour : MonoBehaviour
{
    public Button[] buttons = new Button[4];
    public Color mycolorWrong;
    public Color mycolorRight;
    public GameObject WrongMessage;
    public GameObject RightMessage;
    public GameObject NextQuestion;
    public string VillageSceneName;



    public void PlayQuizGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Answer()
    {
        for(int i = 0; i < 4; i++)
        {
            if(buttons[i].tag == "Wrong")
            {
                ColorBlock colors = buttons[i].colors;
                colors.normalColor = Color.red;
                colors.highlightedColor = new Color32(255, 100, 100, 255);
                buttons[i].colors = colors;
            }
            else
            {
                ColorBlock colors = buttons[i].colors;
                colors.normalColor = Color.green;
                colors.highlightedColor = new Color32(255, 100, 100, 255);
                buttons[i].colors = colors;


            }
        }
    }

    public IEnumerator showWrongMessage()
    {
        WrongMessage.SetActive(true);
        yield return new WaitForSeconds(2);
        WrongMessage.SetActive(false);

    }

    public IEnumerator showRightMessage()
    {
        RightMessage.SetActive(true);
        yield return new WaitForSeconds(2);
        RightMessage.SetActive(false);

    }

    public void showRightMessageFunction()
    {
        StartCoroutine(showRightMessage());
        GoToNextQuestionFunction();
    }

    public void showWrongMessageFunction()
    {
        StartCoroutine(showWrongMessage());
    }

    public IEnumerator GoToNextQuestion()
    {
        yield return new WaitForSeconds(2);
        NextQuestion.SetActive(true);
        this.gameObject.SetActive(false);

    }

    private void GoToNextQuestionFunction()
    {
        StartCoroutine(GoToNextQuestion());
    }

    public void CloseQuestions()
    {
        SceneManager.LoadScene(VillageSceneName);
    }
    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
