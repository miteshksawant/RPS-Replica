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

        GameChoice selectedChoice = GameChoice.NONE;

        switch (choiceName)
        {
            case "Rock":
                break;

            case "Paper":
                break;

            case "scissors":
                break;
        }
    }
}
