using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Networking;

public class FairyGetUserDetailsState : FairyBaseState
{
    private bool isUserDetailsComplete = false;

    public override void EnterState(FairyController_FSM fairy)
    {
        //   Debug.Log("get user details state");
        NextExercise(fairy);
    }

    public override void Update(FairyController_FSM fairy)
    {
        //throw new System.NotImplementedException();
    }

    void NextExercise(FairyController_FSM fairy)
    {
        if (!GameControl.userWordNameList.Contains("HELLO")) // && !GameControl.userWordNameList.Contains("HI"))
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
        else if (GameControl.userDetails.Age == null)
        {
            GameControl.isAgeExercise = true;
            AgeExercise1();
        }
        else if (GameControl.userDetails.Age != null && GameControl.isAgeExercise)
        {
            GameControl.isAgeExercise = false;
            AgeExercise2();
        }
        else if (GameControl.userDetails.Age != null && !GameControl.isAgeExercise)
        {
      //      Fairy.haveUserDetails = true;
        }

        var ds = new DataService("DictionaryLookups.db");

        fairy.TransitionToState(fairy.SilentState);
    }

    // Hello Exercise
    void HelloExercise1()
    {
        var soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
        soundManagerScript.playSound(soundManagerScript.helloExercise01);
    }

    // Name Exercise
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

        //  Debug.Log(GameControl.userDetails.Name);

        var ds = new DataService("DictionaryLookups.db");
        ds.CreateUser(GameControl.userDetails.Name);
    }

    void AgeExercise1()
    {
        var soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
        soundManagerScript.playSound(soundManagerScript.ageExercise01);
    }

    void AgeExercise2()
    {
        var soundManager = GameObject.Find("SoundManager");
        SoundManager soundManagerScript = soundManager.GetComponent<SoundManager>();
        soundManagerScript.playSound(soundManagerScript.ageExercise02);

        Debug.Log(GameControl.userDetails.Age);

        var ds = new DataService("DictionaryLookups.db");
        ds.UpdateUserAge(GameControl.userDetails.Name, GameControl.userDetails.Age);
    }



}