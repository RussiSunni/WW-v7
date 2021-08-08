using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyTeachingState : FairyBaseState
{
    private bool isUserDetailsComplete = false;

    public override void EnterState(FairyController_FSM fairy)
    {
        //  Debug.Log("teaching state");
        NextExercise(fairy);
    }

    public override void Update(FairyController_FSM fairy)
    {
        //throw new System.NotImplementedException();
    }

    void NextExercise(FairyController_FSM fairy)
    {
        if (!isUserDetailsComplete)
        {
            if (!GameControl.userWordNameList.Contains("HELLO"))
                HelloExercise1();
            else if (GameControl.userDetails.Name == null)
            {
                GameControl.isNameExercise = true;
                NameExercise1();
            }
            else if (GameControl.userDetails.Name != null && GameControl.isNameExercise)
            {
                GameControl.isNameExercise = false;
                NameExercise2();
            }

            // age

        }
        else
        {
            if (!GameControl.userWordNameList.Contains("CAT"))
            {
                CatExercise1();
            }

            else if (!GameControl.userWordNameList.Contains("SALT"))
                SaltExercise1();
        }

        fairy.TransitionToState(fairy.SilentState);
    }

    // Hello Exercise
    void HelloExercise1()
    {
        var soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
        soundManagerScript.playSound(soundManagerScript.helloExercise01);
    }


    // void NextExercise2()
    // {

    // }



    // // Name Exercise
    void NameExercise1()
    {
        var soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
        soundManagerScript.playSound(soundManagerScript.nameExercise01);
    }

    void NameExercise2()
    {
        var soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
        soundManagerScript.playSound(soundManagerScript.nameExercise02);
    }


    // Cat Exercise
    void CatExercise1()
    {
        //  inCatExercise = true;

        var soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
        soundManagerScript.playSound(soundManagerScript.catExercise01);
    }

    // void CatExercise2()
    // {
    //     StartCoroutine((CatExercise02()));
    // }

    // IEnumerator CatExercise02()
    // {
    //     var soundManager = GameObject.Find("SoundManager");
    //     SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();

    //     soundManagerScript.playSound(soundManagerScript.catExercise02);
    //     yield return new WaitForSeconds(1.5f);
    //     soundManagerScript.playSound(soundManagerScript.catExercise03);
    //     yield return new WaitForSeconds(1.5f);
    //     soundManagerScript.playSound(soundManagerScript.catExercise04);
    // }

    void SaltExercise1()
    {
        var soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
        soundManagerScript.playSound(soundManagerScript.saltExercise01);
    }
}
