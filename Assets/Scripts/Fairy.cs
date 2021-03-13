using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fairy : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator.SetBool("isJump", false);
        animator.SetBool("isHello", false);
        animator.SetBool("isSit", false);

    }

    public void NoAnimation()
    {
        animator.SetBool("isJump", false);
        animator.SetBool("isHello", false);
        animator.SetBool("isSit", false);
    }

    public void Animation(string word)
    {
        animator.SetBool(word, true);
        GameControl.currentWords.Clear();
    }
}