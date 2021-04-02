using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fairy : MonoBehaviour
{
    public Animator animator;
    private float inputTimer;
    private int counter;
    public Text fairyText;

    public static bool inCatExercise;
    private bool catExercise01, catExercise02;

    private void Start()
    {
        animator.SetBool("isJump", false);
        animator.SetBool("isHello", false);
        animator.SetBool("isSit", false);

        inputTimer = 0;


    }

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

    }

    public void Animation(string word)
    {
        animator.SetBool(word, true);
        GameControl.currentWords.Clear();
    }


    // AI
    void Update()
    {
        inputTimer += Time.deltaTime;

        if (Input.anyKey)
        {
            inputTimer = 0;
            counter = 0;
        }

        if (inputTimer >= 10f)
        {
            if (counter == 0)
            {
                var soundManager = GameObject.Find("SoundManager");
                SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
                // "Hey"
                soundManagerScript.playSound(soundManagerScript.wordSoundList[12]);

                // "What is your name?" maybe she is not looking
                //  soundManagerScript.playSound(soundManagerScript.nameExercise);

                inputTimer = 0;
                counter++;
            }
            else if (counter == 1)
            {
                CatExercise1();
                inputTimer = 0;
                counter++;
            }
            else if (counter == 2)
            {
                counter++;
            }
            else if (counter == 3)
            {
                CatExercise2();
            }
        }
    }


    // Name Exercise
    // void NameExercise()
    // {
    //     var soundManager = GameObject.Find("SoundManager");
    //     SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();

    //     fairyText.text = "What is your name?";
    // }


    // Cat Exercise
    void CatExercise1()
    {
        inCatExercise = true;

        var soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();

        if (!catExercise01)
        {
            //fairyText.text = "I've lost my cat, have you seen him?";
            soundManagerScript.playSound(soundManagerScript.catExercise01);
            catExercise01 = true;
        }
    }

    void CatExercise2()
    {
        if (!catExercise02)
        {
            StartCoroutine((CatExercise02()));
            catExercise02 = true;
        }
    }

    IEnumerator CatExercise02()
    {
        var soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();

        soundManagerScript.playSound(soundManagerScript.catExercise02);
        yield return new WaitForSeconds(1.5f);
        soundManagerScript.playSound(soundManagerScript.catExercise03);
        yield return new WaitForSeconds(1.5f);
        soundManagerScript.playSound(soundManagerScript.catExercise04);
    }
}
