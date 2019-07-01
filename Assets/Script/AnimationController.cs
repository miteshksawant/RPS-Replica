using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField]
    private Animator PlayerChoiceAnimation, ChoiceAnimation;

    public void ResetAnimation()
    {
        PlayerChoiceAnimation.Play("ShowHandler");
        ChoiceAnimation.Play("RemoveChoice");
    }

    public void PlayerMadeChoice()
    {
        PlayerChoiceAnimation.Play("RemoveHandler");
        ChoiceAnimation.Play("Show Choice");
    }
}