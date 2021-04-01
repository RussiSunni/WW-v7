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
    private bool inCatExercise, catExercise01, catExercise02;

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
                soundManagerScript.playSound(soundManagerScript.wordSoundList[12]);

                inputTimer = 0;
                counter++;

                print(counter);
            }
            else if (counter == 1)
            {
                catExercise1();
                inputTimer = 0;
                counter++;
            }
            else if (counter == 2)
            {
                counter++;
            }
            else if (counter == 3)
            {
                catExercise2();
            }
        }
    }


    void catExercise1()
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

    void catExercise2()
    {
        var soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();

        if (!catExercise02)
        {
            //fairyText.text = "'C' 'A' 'T'";
            soundManagerScript.playSound(soundManagerScript.catExercise02);
            catExercise02 = true;
        }
    }
}
