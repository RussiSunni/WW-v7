using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fairy : MonoBehaviour
{

    // state machine
    // concrete states -------------

    // 1. dictionary

    // 2. intro / learn about student

    // 3. level one

    // 4. level two etc


    public Animator animator;
    public Text fairyText;
    public static bool haveUserDetails, inCatExercise;

    public void NoAnimation()
    {
        animator.SetBool("isJump", false);
        animator.SetBool("isHello", false);
        animator.SetBool("isSit", false);
        animator.SetBool("isBus", false);
        animator.SetBool("isTail", false);
        animator.SetBool("isQueen", false);
        animator.SetBool("isNight", false);
        animator.SetBool("isSalt", false);
        animator.SetBool("isUpset", false);
        animator.SetBool("isHi", false);
        animator.SetBool("isUmbrella", false);
        animator.SetBool("isBlond", false);
        animator.SetBool("isTurn", false);
    }

    public void Animation(string word)
    {
        animator.SetBool(word, true);
        GameControl.currentWords.Clear();
    }

}
