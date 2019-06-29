using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private AnimationController animationController;
    private GamePlayController playController;

    private string playerChoice;

    void Awake()
    {
        animationController = GetComponent<AnimationController>();
        playController = GetComponent<GamePlayController>();
    }

    public void GetChoice()
    {
        string choiceName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        Debug.Log("Player Selected : " + choiceName);

        GameChoice selectedChoice = GameChoice.NONE;

        switch (choiceName)
        {
            case "Rock":
                selectedChoice = GameChoice.ROCK;
                break;

            case "Paper":
                selectedChoice = GameChoice.PAPER;
                break;

            case "scissors":
                selectedChoice = GameChoice.SCISSORS;
                break;
        }

        animationController.PlayerMadeChoice();
    }
}
