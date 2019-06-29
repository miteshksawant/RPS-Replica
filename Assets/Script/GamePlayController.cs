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

    }
}