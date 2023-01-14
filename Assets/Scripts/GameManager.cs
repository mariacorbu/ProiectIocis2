using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public Question[] questions;
    private static List<Question> unansweredQuestions;
    private Question currentQuestion;
    private int correctAnswers = 0;
    private int wrongAnswers = 0;

    [SerializeField]
    private Text factText;
    [SerializeField]
    private Text trueAnswerText;
    [SerializeField]
    private Text falseAnswerText;
    [SerializeField]
    private Text final;
    private float timeBetweenQuestions = 1f;

    [SerializeField]
    private Animator animator;

    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }
        GetQuestion();

    }

    void GetQuestion() {
        animator.SetTrigger("NoAnswer");
        if (unansweredQuestions != null && unansweredQuestions.Count != 0)
        {
            

            int questionIndex = 0;
            currentQuestion = unansweredQuestions[questionIndex];

            factText.text = currentQuestion.fact;
            if (currentQuestion.isTrue)
            {
                correctAnswers++;
                trueAnswerText.text = "CORECT!";
                falseAnswerText.text = "GREȘIT!";
            }
            else
            {
                trueAnswerText.text = "GREȘIT!";
                falseAnswerText.text = "CORECT!";
            }

        }
        else
        {
            wrongAnswers = 12 - correctAnswers;
            animator.SetTrigger("Final");
            final.text = "FINAL TEST \n\n Raspunsuri corecte: " + correctAnswers + " \n Raspunsuri gresite: " + wrongAnswers;

        }

    }

    IEnumerator TransitionToNextQuestion() 
    {
        unansweredQuestions.Remove(currentQuestion);
        yield return new WaitForSeconds(timeBetweenQuestions);
        GetQuestion();
    }

    public void UserSelectTrue()
    {
        animator.SetTrigger("True"); 
        StartCoroutine(TransitionToNextQuestion());
    }
    public void UserSelectFalse ()
    {
        animator.SetTrigger("False");
        StartCoroutine(TransitionToNextQuestion());

    }


}
