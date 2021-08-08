using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairySilentState : FairyBaseState
{
    private float inputTimer;
    public override void EnterState(FairyController_FSM fairy)
    {
        //  Debug.Log("silent state");
    }

// not using the AI for now.

    public override void Update(FairyController_FSM fairy)
    {
    //     // transition to teaching state after 10 seconds of inactivity
    //     inputTimer += Time.deltaTime;

    //     if (Input.anyKey)
    //     {
    //         inputTimer = 0;
    //     }

    //     if (inputTimer >= 5f)
    //     {
    //         inputTimer = 0;
    //         if (!Fairy.haveUserDetails)
    //             fairy.TransitionToState(fairy.GetUserDetailsState);
    //         else
    //             fairy.TransitionToState(fairy.TeachingLevel1State);
    //     }
     }
}
