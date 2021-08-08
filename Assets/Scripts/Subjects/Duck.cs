using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator.SetBool("isDuck", false);
    }

    public void Play()
    {
        animator.SetBool("isDuck", true);      
    }

    public void NoAnimation()
    {
        animator.SetBool("isDuck", false);      
    } 
}
