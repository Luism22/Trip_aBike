using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    //anwers A
    public GameObject answerAbackBlue;      //is waiting
    public GameObject answerAbackGreen;     // is correct
    public GameObject answerAbackRed;       // is wrong

    //anwers B
    public GameObject answerBbackBlue;      //is waiting
    public GameObject answerBbackGreen;     // is correct
    public GameObject answerBbackRed;       // is wrong

    //answers C
    public GameObject answerCbackBlue;      //is waiting
    public GameObject answerCbackGreen;     // is correct
    public GameObject answerCbackRed;       // is wrong

    //answers D
    public GameObject answerDbackBlue;      //is waiting
    public GameObject answerDbackGreen;     // is correct
    public GameObject answerDbackRed;       // is wrong

    //general answers
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    //sounds
    public AudioSource correctFX;
    public AudioSource wrongFX;

    //score
    public GameObject currentScore;
    public GameObject bestDisplay;
    public int scoreValue;
    public int bestScore;


    void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScore");
        //bestScore = scoreValue;
        bestDisplay.GetComponent<Text>().text = "Best: " + bestScore;

    }
    void Update()
    {
        currentScore.GetComponent<Text>().text = "Score: " + scoreValue;
    }
    public void AnswerA()
    {
        if (QuestionGenerateEasy.actualAnswer == "A")
        {
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
            wrongFX.Play();
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());

    }
    public void AnswerB()
    {
        if (QuestionGenerateEasy.actualAnswer == "B")
        {
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(false);
            wrongFX.Play();
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }
    public void AnswerC()
    {
        if (QuestionGenerateEasy.actualAnswer == "C")
        {
            answerCbackGreen.SetActive(true);
            answerCbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackBlue.SetActive(false);
            wrongFX.Play();
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }
    public void AnswerD()
    {
        if (QuestionGenerateEasy.actualAnswer == "D")
        {
            answerDbackGreen.SetActive(true);
            answerDbackBlue.SetActive(false);
            correctFX.Play();
            scoreValue += 5;
        }
        else
        {
            answerDbackRed.SetActive(true);
            answerDbackBlue.SetActive(false);
            wrongFX.Play();
            scoreValue = 0;
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());

    }
    IEnumerator NextQuestion()
    {
        if (bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScore", scoreValue);
            bestDisplay.GetComponent<Text>().text = "Best: " + bestScore;
        }
        yield return new WaitForSeconds(5f);

        answerAbackGreen.SetActive(false);
        answerBbackGreen.SetActive(false);
        answerCbackGreen.SetActive(false);
        answerDbackGreen.SetActive(false);

        answerAbackRed.SetActive(false);
        answerBbackRed.SetActive(false);
        answerCbackRed.SetActive(false);
        answerDbackRed.SetActive(false);

        answerAbackBlue.SetActive(true);
        answerBbackBlue.SetActive(true);
        answerCbackBlue.SetActive(true);
        answerDbackBlue.SetActive(true);

        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;

        QuestionGenerateEasy.displayingQuestion = false;
    }
}
