using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameChoice
{
    NONE,
    ROCK,
    PAPER,
    SCISSORS
}

public class GamePlayController : MonoBehaviour
{
    [SerializeField]
    private Sprite rock_sprite, paper_sprite, scissors_sprite;

    [SerializeField]
    private Image playerChoice_img, opponentChoice_img;

    [SerializeField]
    private Text infoText;

    private GameChoice player_choice = GameChoice.NONE, opponent_choice = GameChoice.NONE;

    private AnimationController animationController;

    void Awake()
    {
        animationController = GetComponent<AnimationController>();
    }

    public void SetChoice(GameChoice gameChoice)
    {
        switch(gameChoice)
        {
            case GameChoice.ROCK:
                playerChoice_img.sprite = rock_sprite;
                player_choice = GameChoice.ROCK;
                break;

            case GameChoice.PAPER:
                playerChoice_img.sprite = paper_sprite;
                player_choice = GameChoice.PAPER;
                break;

            case GameChoice.SCISSORS:
                playerChoice_img.sprite = scissors_sprite;
                player_choice = GameChoice.SCISSORS;
                break;
        }
        SetOpponentChoice();
        DetermineWinner();
    }

    void SetOpponentChoice()
    {
        int rnd = Random.Range(0, 3);
        switch(rnd)
        {
            case 0:
                opponent_choice = GameChoice.ROCK;
                opponentChoice_img.sprite = rock_sprite;
                break;

            case 1:
                opponent_choice = GameChoice.PAPER;
                opponentChoice_img.sprite = paper_sprite;
                break;

            case 2:
                opponent_choice = GameChoice.SCISSORS;
                opponentChoice_img.sprite = scissors_sprite;
                break;
        }
    }

    void DetermineWinner()
    {
        if(player_choice==opponent_choice)
        {
            infoText.text = "Match Draw";
            StartCoroutine(DisplayWinnerAndRestart());
            return;
        }

        if (player_choice == GameChoice.PAPER && opponent_choice == GameChoice.ROCK)
        {
            infoText.text = "You Win";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (opponent_choice == GameChoice.PAPER && player_choice == GameChoice.ROCK)
        {
            infoText.text = "You Lose";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (player_choice == GameChoice.ROCK && opponent_choice == GameChoice.SCISSORS)
        {
            infoText.text = "You Win";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (opponent_choice == GameChoice.ROCK && player_choice == GameChoice.SCISSORS)
        {
            infoText.text = "You Lose";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (player_choice == GameChoice.SCISSORS && opponent_choice == GameChoice.PAPER)
        {
            infoText.text = "You Win";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }

        if (opponent_choice == GameChoice.SCISSORS && player_choice == GameChoice.PAPER)
        {
            infoText.text = "You Lose";
            StartCoroutine(DisplayWinnerAndRestart());

            return;
        }
    }

    IEnumerator DisplayWinnerAndRestart()
    {
        yield return new WaitForSeconds(2f);
        infoText.gameObject.SetActive(true);

        yield return new WaitForSeconds(2f);
        infoText.gameObject.SetActive(false);

        animationController.ResetAnimation();
    }
}