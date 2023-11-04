using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerateEasy : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;

    private List<int> usedQuestions = new List<int>();
    private int totalQuestions = 10; // Número total de preguntas disponibles.

    // Update is called once per frame
    void Update()
    {
        if (displayingQuestion == false)
        {
            displayingQuestion = true;

            if (usedQuestions.Count == totalQuestions)
            {
                // Si se han mostrado todas las preguntas, reinicia la lista.
                usedQuestions.Clear();
            }

            // Genera un número de pregunta aleatorio que no se haya utilizado.
            do
            {
                questionNumber = Random.Range(1, totalQuestions + 1);
            }
            while (usedQuestions.Contains(questionNumber));

            usedQuestions.Add(questionNumber);

            // Asigna las preguntas y respuestas según el número de pregunta.
            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "Question 1: What is the correct past tense of the verb 'go'?";
                QuestionDisplay.newA = "A. goed";
                QuestionDisplay.newB = "B. gone";
                QuestionDisplay.newC = "C. went";
                QuestionDisplay.newD = "D. goes";
                actualAnswer = "C";
            }
            else if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "Question 2: Which of the following is a synonym for 'happy'?";
                QuestionDisplay.newA = "A. sad";
                QuestionDisplay.newB = "B. joyful";
                QuestionDisplay.newC = "C. angry";
                QuestionDisplay.newD = "D. upset";
                actualAnswer = "B";
            }
            else if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Question 3: What is the plural form of 'child'?";
                QuestionDisplay.newA = "A. childs";
                QuestionDisplay.newB = "B. child";
                QuestionDisplay.newC = "C. childes";
                QuestionDisplay.newD = "D. children";
                actualAnswer = "D";
            }
            else if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Question 4: Which of the following sentences is correct?";
                QuestionDisplay.newA = "A. She don’t like apples.";
                QuestionDisplay.newB = "B. She doesn’t likes apples.";
                QuestionDisplay.newC = "C. She doesn’t like apples.";
                QuestionDisplay.newD = "D. She don’t likes apples.";
                actualAnswer = "C";
            }
            else if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "Question 5: What is the superlative form of 'good'?";
                QuestionDisplay.newA = "A. gooder";
                QuestionDisplay.newB = "B. goodest";
                QuestionDisplay.newC = "C. better";
                QuestionDisplay.newD = "D. best";
                actualAnswer = "D";
            }
            else if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "Question 6: Which of the following words is an adverb?";
                QuestionDisplay.newA = "A. quickly";
                QuestionDisplay.newB = "B. quick";
                QuestionDisplay.newC = "C. quickest";
                QuestionDisplay.newD = "D. quicker";
                actualAnswer = "A";
            }
            else if (questionNumber == 7)
            {
                QuestionDisplay.newQuestion = "Question 7: What is the correct contraction of 'I am'?";
                QuestionDisplay.newA = "A. Im";
                QuestionDisplay.newB = "B. I’m";
                QuestionDisplay.newC = "C. Am";
                QuestionDisplay.newD = "D. Iam";
                actualAnswer = "B";
            }
            else if (questionNumber == 8)
            {
                QuestionDisplay.newQuestion = "Question 8: Which of the following sentences is in the future tense?";
                QuestionDisplay.newA = "A. I ate dinner.";
                QuestionDisplay.newB = "B. I eat dinner.";
                QuestionDisplay.newC = "C. I will eat dinner.";
                QuestionDisplay.newD = "D. I eating dinner.";
                actualAnswer = "C";
            }
            else if (questionNumber == 9)
            {
                QuestionDisplay.newQuestion = "Question 9: What is the past participle of 'see'?";
                QuestionDisplay.newA = "A. saw";
                QuestionDisplay.newB = "B. seen";
                QuestionDisplay.newC = "C. see";
                QuestionDisplay.newD = "D. sees";
                actualAnswer = "B";
            }
            else if (questionNumber == 10)
            {
                QuestionDisplay.newQuestion = "Question 10: Which of the following is a proper noun?";
                QuestionDisplay.newA = "A. city";
                QuestionDisplay.newB = "B. dog";
                QuestionDisplay.newC = "C. John";
                QuestionDisplay.newD = "D. book";
                actualAnswer = "C";
            }


            QuestionDisplay.pleaseUpdate = false;
        }
    }
}