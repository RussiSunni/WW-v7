using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FairyTeachingLevel1State : FairyBaseState
{
    private bool isUserDetailsComplete = false;

    public override void EnterState(FairyController_FSM fairy)
    {
        Debug.Log("teaching level 1 state");
        NextExercise(fairy);
    }

    public override void Update(FairyController_FSM fairy)
    {
        //throw new System.NotImplementedException();
    }

    void NextExercise(FairyController_FSM fairy)
    {
        if (!GameControl.userWordNameList.Contains("CAT"))
        {
            CatExercise1();
        }

        else if (!GameControl.userWordNameList.Contains("SALT"))
            SaltExercise1();

        fairy.TransitionToState(fairy.SilentState);
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