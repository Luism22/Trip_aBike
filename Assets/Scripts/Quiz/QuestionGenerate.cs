using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;

    private List<int> usedQuestions = new List<int>();
    private int totalQuestions = 19; // Número total de preguntas disponibles.

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
            } while (usedQuestions.Contains(questionNumber));

            usedQuestions.Add(questionNumber);

            // Asigna las preguntas y respuestas según el número de pregunta.
            if (questionNumber == 1)
            {
                QuestionDisplay.newQuestion = "how are you?";
                QuestionDisplay.newA = "A. mario";
                QuestionDisplay.newB = "B. luis";
                QuestionDisplay.newC = "C. carlos";
                QuestionDisplay.newD = "D. juan";
                actualAnswer = "A";
            }
            else if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "where are you from?";
                QuestionDisplay.newA = "A. canada";
                QuestionDisplay.newB = "B. bogota";
                QuestionDisplay.newC = "C. cundinamarca";
                QuestionDisplay.newD = "D. cartagena";
                actualAnswer = "D";
            }
            else if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "where is japan?";
                QuestionDisplay.newA = "A. africa";
                QuestionDisplay.newB = "B. asia";
                QuestionDisplay.newC = "C. america";
                QuestionDisplay.newD = "D. antatica";
                actualAnswer = "B";
            }
            else if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "how old are you?";
                QuestionDisplay.newA = "A. 22";
                QuestionDisplay.newB = "B. 34";
                QuestionDisplay.newC = "C. 23";
                QuestionDisplay.newD = "D. 41";
                actualAnswer = "C";
            }
            else if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "Question 5: What is the largest planet in our solar system?";
                QuestionDisplay.newA = "A. Earth";
                QuestionDisplay.newB = "B. Mars";
                QuestionDisplay.newC = "C. Jupiter";
                QuestionDisplay.newD = "D. Saturn";
                actualAnswer = "C";
            }
            else if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "Question 6: Who painted the Mona Lisa?";
                QuestionDisplay.newA = "A. Vincent van Gogh";
                QuestionDisplay.newB = "B. Pablo Picasso";
                QuestionDisplay.newC = "C. Leonardo da Vinci";
                QuestionDisplay.newD = "D. Michelangelo";
                actualAnswer = "C";
            }
            else if (questionNumber == 7)
            {
                QuestionDisplay.newQuestion = "Question 7: What is the chemical symbol for gold?";
                QuestionDisplay.newA = "A. Go";
                QuestionDisplay.newB = "B. Au";
                QuestionDisplay.newC = "C. Ag";
                QuestionDisplay.newD = "D. Gd";
                actualAnswer = "B";
            }
            else if (questionNumber == 8)
            {
                QuestionDisplay.newQuestion = "Question 8: Which gas do plants absorb from the atmosphere?";
                QuestionDisplay.newA = "A. Oxygen";
                QuestionDisplay.newB = "B. Carbon dioxide";
                QuestionDisplay.newC = "C. Nitrogen";
                QuestionDisplay.newD = "D. Hydrogen";
                actualAnswer = "B";
            }
            else if (questionNumber == 9)
            {
                QuestionDisplay.newQuestion = "Question 9: What is the capital of Australia?";
                QuestionDisplay.newA = "A. Sydney";
                QuestionDisplay.newB = "B. Melbourne";
                QuestionDisplay.newC = "C. Canberra";
                QuestionDisplay.newD = "D. Perth";
                actualAnswer = "C";
            }
            else if (questionNumber == 10)
            {
                QuestionDisplay.newQuestion = "Question 10: What is the capital of Japan?";
                QuestionDisplay.newA = "A. Beijing";
                QuestionDisplay.newB = "B. Seoul";
                QuestionDisplay.newC = "C. Tokyo";
                QuestionDisplay.newD = "D. Bangkok";
                actualAnswer = "C";
            }
            else if (questionNumber == 11)
            {
                QuestionDisplay.newQuestion = "Question 11: Who is the author of 'To Kill a Mockingbird'?";
                QuestionDisplay.newA = "A. Ernest Hemingway";
                QuestionDisplay.newB = "B. J.K. Rowling";
                QuestionDisplay.newC = "C. Harper Lee";
                QuestionDisplay.newD = "D. George Orwell";
                actualAnswer = "C";
            }
            else if (questionNumber == 12)
            {
                QuestionDisplay.newQuestion = "Question 12: What is the largest desert in the world?";
                QuestionDisplay.newA = "A. Sahara Desert";
                QuestionDisplay.newB = "B. Gobi Desert";
                QuestionDisplay.newC = "C. Antarctic Desert";
                QuestionDisplay.newD = "D. Atacama Desert";
                actualAnswer = "A";
            }
            else if (questionNumber == 13)
            {
                QuestionDisplay.newQuestion = "Question 13: Who was the first woman to fly solo across the Atlantic Ocean?";
                QuestionDisplay.newA = "A. Amelia Earhart";
                QuestionDisplay.newB = "B. Marie Curie";
                QuestionDisplay.newC = "C. Rosa Parks";
                QuestionDisplay.newD = "D. Sacagawea";
                actualAnswer = "A";
            }
            else if (questionNumber == 14)
            {
                QuestionDisplay.newQuestion = "Question 14: Which planet is known as the 'Evening Star' or the 'Morning Star'?";
                QuestionDisplay.newA = "A. Venus";
                QuestionDisplay.newB = "B. Mercury";
                QuestionDisplay.newC = "C. Mars";
                QuestionDisplay.newD = "D. Neptune";
                actualAnswer = "A";
            }
            else if (questionNumber == 15)
            {
                QuestionDisplay.newQuestion = "Question 15: Who is the author of '1984'?";
                QuestionDisplay.newA = "A. F. Scott Fitzgerald";
                QuestionDisplay.newB = "B. George Orwell";
                QuestionDisplay.newC = "C. Charles Dickens";
                QuestionDisplay.newD = "D. Jane Austen";
                actualAnswer = "B";
            }
            else if (questionNumber == 16)
            {
                QuestionDisplay.newQuestion = "Question 16: What is the world's largest ocean?";
                QuestionDisplay.newA = "A. Atlantic Ocean";
                QuestionDisplay.newB = "B. Indian Ocean";
                QuestionDisplay.newC = "C. Arctic Ocean";
                QuestionDisplay.newD = "D. Pacific Ocean";
                actualAnswer = "D";
            }
            else if (questionNumber == 17)
            {
                QuestionDisplay.newQuestion = "Question 17: Who painted the 'Starry Night'?";
                QuestionDisplay.newA = "A. Vincent van Gogh";
                QuestionDisplay.newB = "B. Pablo Picasso";
                QuestionDisplay.newC = "C. Leonardo da Vinci";
                QuestionDisplay.newD = "D. Michelangelo";
                actualAnswer = "A";
            }
            else if (questionNumber == 18)
            {
                QuestionDisplay.newQuestion = "Question 18: Which gas makes up the majority of Earth's atmosphere?";
                QuestionDisplay.newA = "A. Oxygen";
                QuestionDisplay.newB = "B. Carbon dioxide";
                QuestionDisplay.newC = "C. Nitrogen";
                QuestionDisplay.newD = "D. Hydrogen";
                actualAnswer = "C";
            }
            else if (questionNumber == 19)
            {
                QuestionDisplay.newQuestion = "Question 19: What is the currency of Brazil?";
                QuestionDisplay.newA = "A. Dollar";
                QuestionDisplay.newB = "B. Euro";
                QuestionDisplay.newC = "C. Real";
                QuestionDisplay.newD = "D. Peso";
                actualAnswer = "C";
            }



            QuestionDisplay.pleaseUpdate = false;
        }
    }
}
