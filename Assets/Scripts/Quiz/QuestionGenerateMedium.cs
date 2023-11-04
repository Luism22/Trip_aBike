using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerateMedium : MonoBehaviour
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
                QuestionDisplay.newQuestion = "Question 1: What is the English word for 'computadora'?";
                QuestionDisplay.newA = "A. Computer";
                QuestionDisplay.newB = "B. Compote";
                QuestionDisplay.newC = "C. Commuter";
                QuestionDisplay.newD = "D. Composter";
                actualAnswer = "A";
            }
            else if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "Question 2: Complete the sentence: 'If it _____ raining, we could go to the park.'";
                QuestionDisplay.newA = "A. Stops";
                QuestionDisplay.newB = "B. Will stop";
                QuestionDisplay.newC = "C. Stop";
                QuestionDisplay.newD = "D. Stopped";
                actualAnswer = "D";
            }
            else if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Question 3: Which of the following words is a synonym for 'delicious' in English?";
                QuestionDisplay.newA = "A. Tasty";
                QuestionDisplay.newB = "B. Fast";
                QuestionDisplay.newC = "C. Spicy";
                QuestionDisplay.newD = "D. Cold";
                actualAnswer = "A";
            }
            else if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Question 4: What is the past tense of the verb 'to run'?";
                QuestionDisplay.newA = "A. Runned";
                QuestionDisplay.newB = "B. Ran";
                QuestionDisplay.newC = "C. Running";
                QuestionDisplay.newD = "D. Runner";
                actualAnswer = "B";
            }
            else if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "Question 5: If you are feeling 'peckish', what do you want?";
                QuestionDisplay.newA = "A. To go for a run";
                QuestionDisplay.newB = "B. To take a nap";
                QuestionDisplay.newC = "C. Something to eat";
                QuestionDisplay.newD = "D. To read a book";
                actualAnswer = "C";
            }
            else if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "Question 6: What do you call the person who drives a bus?";
                QuestionDisplay.newA = "A. Pilot";
                QuestionDisplay.newB = "B. Captain";
                QuestionDisplay.newC = "C. Driver";
                QuestionDisplay.newD = "D. Conductor";
                actualAnswer = "C";
            }
            else if (questionNumber == 7)
            {
                QuestionDisplay.newQuestion = "Question 7: Which sport uses a 'bat' and a 'ball'?";
                QuestionDisplay.newA = "A. Football";
                QuestionDisplay.newB = "B. Basketball";
                QuestionDisplay.newC = "C. Cricket";
                QuestionDisplay.newD = "D. Tennis";
                actualAnswer = "C";
            }
            else if (questionNumber == 8)
            {
                QuestionDisplay.newQuestion = "Question 8: What is the capital of Australia?";
                QuestionDisplay.newA = "A. Sydney";
                QuestionDisplay.newB = "B. Melbourne";
                QuestionDisplay.newC = "C. Canberra";
                QuestionDisplay.newD = "D. Perth";
                actualAnswer = "C";
            }
            else if (questionNumber == 9)
            {
                QuestionDisplay.newQuestion = "Question 9: If you are 'browsing' on a computer, what are you doing?";
                QuestionDisplay.newA = "A. Writing an email.";
                QuestionDisplay.newB = "B. Looking at websites.";
                QuestionDisplay.newC = "C. Playing a game.";
                QuestionDisplay.newD = "D. Creating a document.";
                actualAnswer = "B";
            }
            else if (questionNumber == 10)
            {
                QuestionDisplay.newQuestion = "Question 10: What is the English word for ‘gato’?";
                QuestionDisplay.newA = "A. Dog";
                QuestionDisplay.newB = "B. Cat";
                QuestionDisplay.newC = "C. Mouse";
                QuestionDisplay.newD = "D. Bird";
                actualAnswer = "B";
            }
            else if (questionNumber == 11)
            {
                QuestionDisplay.newQuestion = "Question 11: Complete the sentence: 'If I _____ (be) rich, I would travel the world.'";
                QuestionDisplay.newA = "A. Was";
                QuestionDisplay.newB = "B. Were";
                QuestionDisplay.newC = "C. Am";
                QuestionDisplay.newD = "D. Is";
                actualAnswer = "B";
            }
            else if (questionNumber == 12)
            {
                QuestionDisplay.newQuestion = "Question 12: Fill in the blank: 'She is _____ (go) to the supermarket to buy some groceries.'";
                QuestionDisplay.newA = "A. Going";
                QuestionDisplay.newB = "B. Go";
                QuestionDisplay.newC = "C. Goes";
                QuestionDisplay.newD = "D. Went";
                actualAnswer = "A";
            }
            else if (questionNumber == 13)
            {
                QuestionDisplay.newQuestion = "Question 13: Complete the sentence: 'It's raining, you should take _____ (you) umbrella.'";
                QuestionDisplay.newA = "A. Your";
                QuestionDisplay.newB = "B. You're";
                QuestionDisplay.newC = "C. You";
                QuestionDisplay.newD = "D. Yours";
                actualAnswer = "A";
            }
            else if (questionNumber == 14)
            {
                QuestionDisplay.newQuestion = "Question 14: Fill in the blank: 'I can't find my keys, I must have _____ (lose) them.'";
                QuestionDisplay.newA = "A. Lost";
                QuestionDisplay.newB = "B. Loses";
                QuestionDisplay.newC = "C. Loose";
                QuestionDisplay.newD = "D. Loosed";
                actualAnswer = "A";
            }
            else if (questionNumber == 15)
            {
                QuestionDisplay.newQuestion = "Question 15: Complete the sentence: 'I'm not interested _____ (in) playing football.'";
                QuestionDisplay.newA = "A. On";
                QuestionDisplay.newB = "B. At";
                QuestionDisplay.newC = "C. In";
                QuestionDisplay.newD = "D. To";
                actualAnswer = "C";
            }
            else if (questionNumber == 16)
            {
                QuestionDisplay.newQuestion = "Question 16: Fill in the blank: ‘He _____ (have) a new car.’";
                QuestionDisplay.newA = "A. Has";
                QuestionDisplay.newB = "B. Have";
                QuestionDisplay.newC = "C. Having";
                QuestionDisplay.newD = "D. Had";
                actualAnswer = "A";
            }
            else if (questionNumber == 17)
            {
                QuestionDisplay.newQuestion = "Question 17: Complete the sentence: ‘She is _____ (read) a book.’";
                QuestionDisplay.newA = "A. Read";
                QuestionDisplay.newB = "B. Reading";
                QuestionDisplay.newC = "C. Reads";
                QuestionDisplay.newD = "D. Readed";
                actualAnswer = "B";
            }
            else if (questionNumber == 18)
            {
                QuestionDisplay.newQuestion = "Question 18: Fill in the blank: ‘They _____ (be) at the park yesterday.’";
                QuestionDisplay.newA = "A. Was";
                QuestionDisplay.newB = "B. Were";
                QuestionDisplay.newC = "C. Is";
                QuestionDisplay.newD = "D. Are";
                actualAnswer = "B";
            }
            else if (questionNumber == 19)
            {
                QuestionDisplay.newQuestion = "Question 19: Complete the sentence: ‘It’s a nice day, let’s go _____ (for) a walk.’";
                QuestionDisplay.newA = "A. To";
                QuestionDisplay.newB = "B. For";
                QuestionDisplay.newC = "C. On";
                QuestionDisplay.newD = "D. In";
                actualAnswer = "B";
            }
            else if (questionNumber == 20)
            {
                QuestionDisplay.newQuestion = "Question 20: Fill in the blank: ‘I’m going to the beach because I love _____ (swim).’";
                QuestionDisplay.newA = "A. Swim";
                QuestionDisplay.newB = "B. Swimming";
                QuestionDisplay.newC = "C. Swam";
                QuestionDisplay.newD = "D. Swims";
                actualAnswer = "B";
            }
            else if (questionNumber == 21)
            {
                QuestionDisplay.newQuestion = "Question 21: What is the English word for 'libro'?";
                QuestionDisplay.newA = "A. Book";
                QuestionDisplay.newB = "B. Library";
                QuestionDisplay.newC = "C. Look";
                QuestionDisplay.newD = "D. Leaf";
                actualAnswer = "A";
            }
            else if (questionNumber == 22)
            {
                QuestionDisplay.newQuestion = "Question 22: Complete the sentence: 'I _____ (be) very tired yesterday.'";
                QuestionDisplay.newA = "A. Was";
                QuestionDisplay.newB = "B. Were";
                QuestionDisplay.newC = "C. Am";
                QuestionDisplay.newD = "D. Is";
                actualAnswer = "A";
            }
            else if (questionNumber == 23)
            {
                QuestionDisplay.newQuestion = "Question 23: What is the English word for 'perro'?";
                QuestionDisplay.newA = "A. Cat";
                QuestionDisplay.newB = "B. Dog";
                QuestionDisplay.newC = "C. Bird";
                QuestionDisplay.newD = "D. Fish";
                actualAnswer = "B";
            }
            else if (questionNumber == 24)
            {
                QuestionDisplay.newQuestion = "Question 24: Fill in the blank: 'She _____ (have) a beautiful smile.'";
                QuestionDisplay.newA = "A. Has";
                QuestionDisplay.newB = "B. Have";
                QuestionDisplay.newC = "C. Having";
                QuestionDisplay.newD = "D. Had";
                actualAnswer = "A";
            }
            else if (questionNumber == 25)
            {
                QuestionDisplay.newQuestion = "Question 25: What is the English word for ‘casa’?";
                QuestionDisplay.newA = "A. Case";
                QuestionDisplay.newB = "B. Castle";
                QuestionDisplay.newC = "C. Home";
                QuestionDisplay.newD = "D. Room";
                actualAnswer = "C";
            }
            else if (questionNumber == 26)
            {
                QuestionDisplay.newQuestion = "Question 26: Complete the sentence: ‘If I _____ (be) you, I would study more.’";
                QuestionDisplay.newA = "A. Am";
                QuestionDisplay.newB = "B. Was";
                QuestionDisplay.newC = "C. Were";
                QuestionDisplay.newD = "D. Is";
                actualAnswer = "C";
            }
            else if (questionNumber == 27)
            {
                QuestionDisplay.newQuestion = "Question 27: What is the English word for ‘amigo’?";
                QuestionDisplay.newA = "A. Enemy";
                QuestionDisplay.newB = "B. Friend";
                QuestionDisplay.newC = "C. Family";
                QuestionDisplay.newD = "D. Stranger";
                actualAnswer = "B";
            }
            else if (questionNumber == 28)
            {
                QuestionDisplay.newQuestion = "Question 28: Fill in the blank: ‘I’m going to the beach because I love _____ (swim).’";
                QuestionDisplay.newA = "A. Swim";
                QuestionDisplay.newB = "B. Swimming";
                QuestionDisplay.newC = "C. Swam";
                QuestionDisplay.newD = "D. Swims";
                actualAnswer = "B";
            }
            else if (questionNumber == 29)
            {
                QuestionDisplay.newQuestion = "Question 29: What is the English word for ‘feliz’?";
                QuestionDisplay.newA = "A. Sad";
                QuestionDisplay.newB = "B. Angry";
                QuestionDisplay.newC = "C. Happy";
                QuestionDisplay.newD = "D. Excited";
                actualAnswer = "C";
            }
            else if (questionNumber == 30)
            {
                QuestionDisplay.newQuestion = "Question 30: Complete the sentence: ‘It’s a nice day, let’s go _____ (for) a walk.’";
                QuestionDisplay.newA = "A. To";
                QuestionDisplay.newB = "B. For";
                QuestionDisplay.newC = "C. On";
                QuestionDisplay.newD = "D. In";
                actualAnswer = "B";
            }
            else if (questionNumber == 31)
            {
                QuestionDisplay.newQuestion = "Question 31: What is the English word for 'nube'?";
                QuestionDisplay.newA = "A. Cloud";
                QuestionDisplay.newB = "B. Sky";
                QuestionDisplay.newC = "C. Rain";
                QuestionDisplay.newD = "D. Wind";
                actualAnswer = "A";
            }
            else if (questionNumber == 32)
            {
                QuestionDisplay.newQuestion = "Question 32: Complete the sentence: 'I _____ (be) very hungry, I need to eat something.'";
                QuestionDisplay.newA = "A. Am";
                QuestionDisplay.newB = "B. Was";
                QuestionDisplay.newC = "C. Were";
                QuestionDisplay.newD = "D. Is";
                actualAnswer = "A";
            }
            else if (questionNumber == 33)
            {
                QuestionDisplay.newQuestion = "Question 33: What is the English word for 'autobús'?";
                QuestionDisplay.newA = "A. Car";
                QuestionDisplay.newB = "B. Train";
                QuestionDisplay.newC = "C. Bus";
                QuestionDisplay.newD = "D. Bicycle";
                actualAnswer = "C";
            }
            else if (questionNumber == 34)
            {
                QuestionDisplay.newQuestion = "Question 34: Fill in the blank: 'She _____ (have) a new job.'";
                QuestionDisplay.newA = "A. Has";
                QuestionDisplay.newB = "B. Have";
                QuestionDisplay.newC = "C. Having";
                QuestionDisplay.newD = "D. Had";
                actualAnswer = "A";
            }
            else if (questionNumber == 35)
            {
                QuestionDisplay.newQuestion = "Question 35: What is the English word for ‘fútbol’?";
                QuestionDisplay.newA = "A. Basketball";
                QuestionDisplay.newB = "B. Baseball";
                QuestionDisplay.newC = "C. Football";
                QuestionDisplay.newD = "D. Tennis";
                actualAnswer = "C";
            }
            else if (questionNumber == 36)
            {
                QuestionDisplay.newQuestion = "Question 36: Complete the sentence: ‘If I _____ (be) you, I would take a break.’";
                QuestionDisplay.newA = "A. Am";
                QuestionDisplay.newB = "B. Was";
                QuestionDisplay.newC = "C. Were";
                QuestionDisplay.newD = "D. Is";
                actualAnswer = "C";
            }
            else if (questionNumber == 37)
            {
                QuestionDisplay.newQuestion = "Question 37: What is the English word for ‘viaje’?";
                QuestionDisplay.newA = "A. Voyage";
                QuestionDisplay.newB = "B. Travel";
                QuestionDisplay.newC = "C. Trip";
                QuestionDisplay.newD = "D. Journey";
                actualAnswer = "C";
            }
            else if (questionNumber == 38)
            {
                QuestionDisplay.newQuestion = "Question 38: Fill in the blank: ‘I’m going to the beach because I love _____ (swim).’";
                QuestionDisplay.newA = "A. Swim";
                QuestionDisplay.newB = "B. Swimming";
                QuestionDisplay.newC = "C. Swam";
                QuestionDisplay.newD = "D. Swims";
                actualAnswer = "B";
            }
            else if (questionNumber == 39)
            {
                QuestionDisplay.newQuestion = "Question 39: What is the English word for ‘bebida’?";
                QuestionDisplay.newA = "A. Food";
                QuestionDisplay.newB = "B. Drink";
                QuestionDisplay.newC = "C. Meal";
                QuestionDisplay.newD = "D. Dish";
                actualAnswer = "B";
            }
            else if (questionNumber == 40)
            {
                QuestionDisplay.newQuestion = "Question 40: Complete the sentence: ‘It’s a nice day, let’s go _____ (for) a walk.’";
                QuestionDisplay.newA = "A. To";
                QuestionDisplay.newB = "B. For";
                QuestionDisplay.newC = "C. On";
                QuestionDisplay.newD = "D. In";
                actualAnswer = "B";
            }
            else if (questionNumber == 41)
            {
                QuestionDisplay.newQuestion = "Question 41: What is the English word for 'sol'?";
                QuestionDisplay.newA = "A. Sun";
                QuestionDisplay.newB = "B. Moon";
                QuestionDisplay.newC = "C. Star";
                QuestionDisplay.newD = "D. Sky";
                actualAnswer = "A";
            }
            else if (questionNumber == 42)
            {
                QuestionDisplay.newQuestion = "Question 42: Complete the sentence: 'I _____ (be) very excited about the concert.'";
                QuestionDisplay.newA = "A. Am";
                QuestionDisplay.newB = "B. Was";
                QuestionDisplay.newC = "C. Were";
                QuestionDisplay.newD = "D. Is";
                actualAnswer = "A";
            }
            else if (questionNumber == 43)
            {
                QuestionDisplay.newQuestion = "Question 43: What is the English word for 'tren'?";
                QuestionDisplay.newA = "A. Car";
                QuestionDisplay.newB = "B. Train";
                QuestionDisplay.newC = "C. Bus";
                QuestionDisplay.newD = "D. Bicycle";
                actualAnswer = "B";
            }
            else if (questionNumber == 44)
            {
                QuestionDisplay.newQuestion = "Question 44: Fill in the blank: 'She _____ (have) a new phone.'";
                QuestionDisplay.newA = "A. Has";
                QuestionDisplay.newB = "B. Have";
                QuestionDisplay.newC = "C. Having";
                QuestionDisplay.newD = "D. Had";
                actualAnswer = "A";
            }
            else if (questionNumber == 45)
            {
                QuestionDisplay.newQuestion = "Question 45: What is the English word for ‘baloncesto’?";
                QuestionDisplay.newA = "A. Football";
                QuestionDisplay.newB = "B. Baseball";
                QuestionDisplay.newC = "C. Basketball";
                QuestionDisplay.newD = "D. Tennis";
                actualAnswer = "C";
            }
            else if (questionNumber == 46)
            {
                QuestionDisplay.newQuestion = "Question 46: Complete the sentence: ‘If I _____ (be) you, I would take a vacation.’";
                QuestionDisplay.newA = "A. Am";
                QuestionDisplay.newB = "B. Was";
                QuestionDisplay.newC = "C. Were";
                QuestionDisplay.newD = "D. Is";
                actualAnswer = "C";
            }
            else if (questionNumber == 47)
            {
                QuestionDisplay.newQuestion = "Question 47: What is the English word for ‘turismo’?";
                QuestionDisplay.newA = "A. Travel";
                QuestionDisplay.newB = "B. Tourism";
                QuestionDisplay.newC = "C. Journey";
                QuestionDisplay.newD = "D. Voyage";
                actualAnswer = "B";
            }
            else if (questionNumber == 48)
            {
                QuestionDisplay.newQuestion = "Question 48: Fill in the blank: ‘I’m going to the beach because I love _____ (swim).’";
                QuestionDisplay.newA = "A. Swim";
                QuestionDisplay.newB = "B. Swimming";
                QuestionDisplay.newC = "C. Swam";
                QuestionDisplay.newD = "D. Swims";
                actualAnswer = "B";
            }
            else if (questionNumber == 49)
            {
                QuestionDisplay.newQuestion = "Question 49: What is the English word for ‘comida’?";
                QuestionDisplay.newA = "A. Drink";
                QuestionDisplay.newB = "B. Food";
                QuestionDisplay.newC = "C. Meal";
                QuestionDisplay.newD = "D. Dish";
                actualAnswer = "B";
            }
            else if (questionNumber == 50)
            {
                QuestionDisplay.newQuestion = "Question 50: Complete the sentence: ‘It’s a nice day, let’s go _____ (for) a walk.’";
                QuestionDisplay.newA = "A. To";
                QuestionDisplay.newB = "B. For";
                QuestionDisplay.newC = "C. On";
                QuestionDisplay.newD = "D. In";
                actualAnswer = "B";
            }

            QuestionDisplay.pleaseUpdate = false;
        }
    }
}