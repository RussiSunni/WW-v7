using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fairy : MonoBehaviour
{
    public Animator animator;
    private float inputTimer;
    public Text fairyText;
    public static bool inCatExercise;

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
        }

        if (inputTimer >= 5f)
        {
            inputTimer = 0;
            NextExercise();
        }

        print(inputTimer);
    }

    void NextExercise()
    {
        for (int i = 0; i < GameControl.userWordsList.Count + 1; i++)
        {
            if (!GameControl.userWordNameList.Contains("CAT"))
                CatExercise1();
            else if (!GameControl.userWordNameList.Contains("SALT"))
                SaltExercise1();
        }
    }


    // Cat Exercise
    void CatExercise1()
    {
        inCatExercise = true;

        var soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
        soundManagerScript.playSound(soundManagerScript.catExercise01);
    }

    void CatExercise2()
    {
        StartCoroutine((CatExercise02()));
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

    void SaltExercise1()
    {
        var soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
        soundManagerScript.playSound(soundManagerScript.saltExercise01);
    }
}
