using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator.SetBool("isCat", false);
    }

    public void NoAnimation()
    {
        animator.SetBool("isCat", false);
        animator.SetBool("isDog", false);

    }

    public void Animation(string word)
    {
        animator.SetBool(word, true);
        GameControl.currentWords.Clear();
    }
}
