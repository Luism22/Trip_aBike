using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerateHard : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;

    private List<int> usedQuestions = new List<int>();
    private int totalQuestions = 35; // Número total de preguntas disponibles.

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
                QuestionDisplay.newQuestion = "Question 1: Which of the following is a potential impact of climate change on global biodiversity?";
                QuestionDisplay.newA = "A. Increased species diversity";
                QuestionDisplay.newB = "B. Disruption of ecosystems";
                QuestionDisplay.newC = "C. Decreased coastal erosion";
                QuestionDisplay.newD = "D. Lower sea levels";
                actualAnswer = "B";
            }
            else if (questionNumber == 2)
            {
                QuestionDisplay.newQuestion = "Question 2: Which technological invention has had the biggest impact on society?";
                QuestionDisplay.newA = "A. The Internet";
                QuestionDisplay.newB = "B. The automobile";
                QuestionDisplay.newC = "C. The telephone";
                QuestionDisplay.newD = "D. The television";
                actualAnswer = "A";
            }
            else if (questionNumber == 3)
            {
                QuestionDisplay.newQuestion = "Question 3: What is the primary purpose of art in society?";
                QuestionDisplay.newA = "A. To decorate spaces";
                QuestionDisplay.newB = "B. To express the artist's emotions";
                QuestionDisplay.newC = "C. To bring about social change";
                QuestionDisplay.newD = "D. To represent historical events";
                actualAnswer = "C";
            }
            else if (questionNumber == 4)
            {
                QuestionDisplay.newQuestion = "Question 4: How does literature reflect the society and time period in which it was written?";
                QuestionDisplay.newA = "A. It doesn't reflect society or time period.";
                QuestionDisplay.newB = "B. It mirrors the culture and values of the time.";
                QuestionDisplay.newC = "C. It only reflects the author's personal views.";
                QuestionDisplay.newD = "D. It predicts future societal trends.";
                actualAnswer = "B";
            }
            else if (questionNumber == 5)
            {
                QuestionDisplay.newQuestion = "Question 5: Which of these foods is typically associated with Italian cuisine?";
                QuestionDisplay.newA = "A. Sushi";
                QuestionDisplay.newB = "B. Tacos";
                QuestionDisplay.newC = "C. Pizza";
                QuestionDisplay.newD = "D. Curry";
                actualAnswer = "C";
            }
            else if (questionNumber == 6)
            {
                QuestionDisplay.newQuestion = "Question 6: Who was a key figure in the civil rights movement in the United States?";
                QuestionDisplay.newA = "A. Abraham Lincoln";
                QuestionDisplay.newB = "B. Martin Luther King Jr.";
                QuestionDisplay.newC = "C. George Washington";
                QuestionDisplay.newD = "D. Thomas Jefferson";
                actualAnswer = "B";
            }
            else if (questionNumber == 7)
            {
                QuestionDisplay.newQuestion = "Question 7: What is a major challenge facing the global economy today?";
                QuestionDisplay.newA = "A. The rise of online shopping";
                QuestionDisplay.newB = "B. The popularity of reality TV";
                QuestionDisplay.newC = "C. Climate change";
                QuestionDisplay.newD = "D. The invention of smartphones";
                actualAnswer = "C";
            }
            else if (questionNumber == 8)
            {
                QuestionDisplay.newQuestion = "Question 8: Which of these is a famous work of literature?";
                QuestionDisplay.newA = "A. The Mona Lisa";
                QuestionDisplay.newB = "B. The Starry Night";
                QuestionDisplay.newC = "C. The Scream";
                QuestionDisplay.newD = "D. To Kill a Mockingbird";
                actualAnswer = "D";
            }
            else if (questionNumber == 9)
            {
                QuestionDisplay.newQuestion = "Question 9: What is one impact of technological advancement on society?";
                QuestionDisplay.newA = "A. Increased physical activity";
                QuestionDisplay.newB = "B. Decreased reliance on fossil fuels";
                QuestionDisplay.newC = "C. Increased connectivity and communication";
                QuestionDisplay.newD = "D. Decreased access to information";
                actualAnswer = "C";
            }
            else if (questionNumber == 10)
            {
                QuestionDisplay.newQuestion = "Question 10: Which historical event had a major impact on the world?";
                QuestionDisplay.newA = "A. The invention of the light bulb";
                QuestionDisplay.newB = "B. The first moon landing";
                QuestionDisplay.newC = "C. The release of the first iPhone";
                QuestionDisplay.newD = "D. The construction of the Great Wall of China";
                actualAnswer = "B";
            }
            else if (questionNumber == 11)
            {
                QuestionDisplay.newQuestion = "Question 11: Which of these is a renewable source of energy?";
                QuestionDisplay.newA = "A. Coal";
                QuestionDisplay.newB = "B. Natural gas";
                QuestionDisplay.newC = "C. Solar power";
                QuestionDisplay.newD = "D. Nuclear power";
                actualAnswer = "C";
            }
            else if (questionNumber == 12)
            {
                QuestionDisplay.newQuestion = "Question 12: Who wrote the novel '1984'?";
                QuestionDisplay.newA = "A. J.K. Rowling";
                QuestionDisplay.newB = "B. George Orwell";
                QuestionDisplay.newC = "C. Ernest Hemingway";
                QuestionDisplay.newD = "D. Mark Twain";
                actualAnswer = "B";
            }
            else if (questionNumber == 13)
            {
                QuestionDisplay.newQuestion = "Question 13: What is the capital of Canada?";
                QuestionDisplay.newA = "A. Toronto";
                QuestionDisplay.newB = "B. Vancouver";
                QuestionDisplay.newC = "C. Montreal";
                QuestionDisplay.newD = "D. Ottawa";
                actualAnswer = "D";
            }
            else if (questionNumber == 14)
            {
                QuestionDisplay.newQuestion = "Question 14: Which of these foods is typically associated with Japanese cuisine?";
                QuestionDisplay.newA = "A. Pizza";
                QuestionDisplay.newB = "B. Sushi";
                QuestionDisplay.newC = "C. Tacos";
                QuestionDisplay.newD = "D. Hamburger";
                actualAnswer = "B";
            }
            else if (questionNumber == 15)
            {
                QuestionDisplay.newQuestion = "Question 20: Which artist is famous for the painting 'The Starry Night'?";
                QuestionDisplay.newA = "A. Leonardo da Vinci";
                QuestionDisplay.newB = "B. Vincent van Gogh";
                QuestionDisplay.newC = "C. Pablo Picasso";
                QuestionDisplay.newD = "D. Claude Monet";
                actualAnswer = "B";
            }
            else if (questionNumber == 16)
            {
                QuestionDisplay.newQuestion = "Question 16: Who is known as the 'Father of Computer Science'?";
                QuestionDisplay.newA = "A. Isaac Newton";
                QuestionDisplay.newB = "B. Albert Einstein";
                QuestionDisplay.newC = "C. Charles Babbage";
                QuestionDisplay.newD = "D. Thomas Edison";
                actualAnswer = "C";
            }
            else if (questionNumber == 17)
            {
                QuestionDisplay.newQuestion = "Question 17: Which of these novels is a famous work of dystopian literature?";
                QuestionDisplay.newA = "A. Pride and Prejudice";
                QuestionDisplay.newB = "B. To Kill a Mockingbird";
                QuestionDisplay.newC = "C. Brave New World";
                QuestionDisplay.newD = "D. Moby Dick";
                actualAnswer = "C";
            }
            else if (questionNumber == 18)
            {
                QuestionDisplay.newQuestion = "Question 18: What is the capital of Australia?";
                QuestionDisplay.newA = "A. Sydney";
                QuestionDisplay.newB = "B. Melbourne";
                QuestionDisplay.newC = "C. Canberra";
                QuestionDisplay.newD = "D. Perth";
                actualAnswer = "C";
            }
            else if (questionNumber == 19)
            {
                QuestionDisplay.newQuestion = "Question 19: Which of these foods is typically associated with Mexican cuisine?";
                QuestionDisplay.newA = "A. Pizza";
                QuestionDisplay.newB = "B. Sushi";
                QuestionDisplay.newC = "C. Tacos";
                QuestionDisplay.newD = "D. Hamburger";
                actualAnswer = "C";
            }
            else if (questionNumber == 20)
            {
                QuestionDisplay.newQuestion = "Question 20: Who was a key figure in the women's suffrage movement in the United States?";
                QuestionDisplay.newA = "A. Abraham Lincoln";
                QuestionDisplay.newB = "B. Martin Luther King Jr.";
                QuestionDisplay.newC = "C. Susan B. Anthony";
                QuestionDisplay.newD = "D. Thomas Jefferson";
                actualAnswer = "C";
            }
            else if (questionNumber == 21)
            {
                QuestionDisplay.newQuestion = "Question 21: Which of these is a famous work of art?";
                QuestionDisplay.newA = "A. The Mona Lisa";
                QuestionDisplay.newB = "B. The Starry Night";
                QuestionDisplay.newC = "C. The Scream";
                QuestionDisplay.newD = "D. The Persistence of Memory";
                actualAnswer = "A";
            }
            else if (questionNumber == 22)
            {
                QuestionDisplay.newQuestion = "Question 22: What is the capital of Spain?";
                QuestionDisplay.newA = "A. Barcelona";
                QuestionDisplay.newB = "B. Valencia";
                QuestionDisplay.newC = "C. Madrid";
                QuestionDisplay.newD = "D. Seville";
                actualAnswer = "C";
            }
            else if (questionNumber == 23)
            {
                QuestionDisplay.newQuestion = "Question 23: Who is the author of 'Pride and Prejudice'?";
                QuestionDisplay.newA = "A. Charlotte Bronte";
                QuestionDisplay.newB = "B. Jane Austen";
                QuestionDisplay.newC = "C. Emily Bronte";
                QuestionDisplay.newD = "D. Virginia Woolf";
                actualAnswer = "B";
            }
            else if (questionNumber == 24)
            {
                QuestionDisplay.newQuestion = "Question 24: Which of these foods is typically associated with French cuisine?";
                QuestionDisplay.newA = "A. Pizza";
                QuestionDisplay.newB = "B. Sushi";
                QuestionDisplay.newC = "C. Tacos";
                QuestionDisplay.newD = "D. Croissant";
                actualAnswer = "D";
            }
            else if (questionNumber == 25)
            {
                QuestionDisplay.newQuestion = "Question 25: Who was a key figure in the scientific revolution?";
                QuestionDisplay.newA = "A. Isaac Newton";
                QuestionDisplay.newB = "B. Albert Einstein";
                QuestionDisplay.newC = "C. Nikola Tesla";
                QuestionDisplay.newD = "D. Thomas Edison";
                actualAnswer = "A";
            }

            else if (questionNumber == 26)
            {
                QuestionDisplay.newQuestion = "Question 26: Which of these is a famous work of literature?";
                QuestionDisplay.newA = "A. The Mona Lisa";
                QuestionDisplay.newB = "B. The Starry Night";
                QuestionDisplay.newC = "C. The Scream";
                QuestionDisplay.newD = "D. Moby Dick";
                actualAnswer = "D";
            }
            else if (questionNumber == 27)
            {
                QuestionDisplay.newQuestion = "Question 27: Which historical event had a major impact on the world?";
                QuestionDisplay.newA = "A. The invention of the light bulb";
                QuestionDisplay.newB = "B. The first moon landing";
                QuestionDisplay.newC = "C. The release of the first iPhone";
                QuestionDisplay.newD = "D. World War II";
                actualAnswer = "D";
            }
            else if (questionNumber == 28)
            {
                QuestionDisplay.newQuestion = "Question 28: Complete the sentence: 'Despite the _____ weather conditions, they decided to continue with the outdoor event.'";
                QuestionDisplay.newA = "A. Adverse";
                QuestionDisplay.newB = "B. Adventurous";
                QuestionDisplay.newC = "C. Advantageous";
                QuestionDisplay.newD = "D. Adequate";
                actualAnswer = "A";
            }
            else if (questionNumber == 29)
            {
                QuestionDisplay.newQuestion = "Question 29: Complete the sentence: 'The _____ I read last week was so captivating that I couldn't put it down.'";
                QuestionDisplay.newA = "A. Notebook";
                QuestionDisplay.newB = "B. Newspaper";
                QuestionDisplay.newC = "C. Novel";
                QuestionDisplay.newD = "D. Note";
                actualAnswer = "C";
            }
            else if (questionNumber == 30)
            {
                QuestionDisplay.newQuestion = "Question 30: Complete the sentence: 'In today's digital age, it's important to be aware of the _____ of sharing personal information online.'";
                QuestionDisplay.newA = "A. Impressions";
                QuestionDisplay.newB = "B. Implications";
                QuestionDisplay.newC = "C. Implementations";
                QuestionDisplay.newD = "D. Impositions";
                actualAnswer = "B";
            }
            else if (questionNumber == 31)
            {
                QuestionDisplay.newQuestion = "Question 31: Complete the sentence: ‘The _____ of the story is a young girl who dreams of becoming a pilot.’";
                QuestionDisplay.newA = "A. Narrator";
                QuestionDisplay.newB = "B. Antagonist";
                QuestionDisplay.newC = "C. Critic";
                QuestionDisplay.newD = "D. Protagonist";
                actualAnswer = "D";
            }
            else if (questionNumber == 32)
            {
                QuestionDisplay.newQuestion = "Question 32: Complete the sentence: ‘The company decided to _____ their new product line at the annual trade show.’";
                QuestionDisplay.newA = "A. Launch";
                QuestionDisplay.newB = "B. Land";
                QuestionDisplay.newC = "C. Lose";
                QuestionDisplay.newD = "D. Lend";
                actualAnswer = "A";
            }
            else if (questionNumber == 33)
            {
                QuestionDisplay.newQuestion = "Question 33: Complete the sentence: ‘The scientist was awarded a Nobel Prize for his _____ in the field of physics.’";
                QuestionDisplay.newA = "A. Disappointments";
                QuestionDisplay.newB = "B. Discrepancies";
                QuestionDisplay.newC = "C. Discoveries";
                QuestionDisplay.newD = "D. Disclosures";
                actualAnswer = "C";
            }
            else if (questionNumber == 34)
            {
                QuestionDisplay.newQuestion = "Question 34: Complete the sentence: ‘The athlete was disqualified from the competition due to a _____ of the rules.’";
                QuestionDisplay.newA = "A. Breach";
                QuestionDisplay.newB = "B. Branch";
                QuestionDisplay.newC = "C. Bunch";
                QuestionDisplay.newD = "D. Beach";
                actualAnswer = "A";
            }
            else if (questionNumber == 35)
            {
                QuestionDisplay.newQuestion = "Question 35: Complete the sentence: ‘The artist uses bold colors to _____ her unique style.’";
                QuestionDisplay.newA = "A. Exorcise";
                QuestionDisplay.newB = "B. Empathize";
                QuestionDisplay.newC = "C. Exercise";
                QuestionDisplay.newD = "D. Emphasize";
                actualAnswer = "D";
            }

            QuestionDisplay.pleaseUpdate = false;
        }
    }
}