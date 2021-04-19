using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairySilentState : FairyBaseState
{
    private float inputTimer;
    public override void EnterState(FairyController_FSM fairy)
    {
        Debug.Log("silent state");
    }

    public override void Update(FairyController_FSM fairy)
    {
        // transition to teaching state after 10 seconds of inactivity
        inputTimer += Time.deltaTime;

        if (Input.anyKey)
        {
            inputTimer = 0;
        }

        if (inputTimer >= 5f)
        {
            inputTimer = 0;
            fairy.TransitionToState(fairy.GetUserDetailsState);
        }
    }
}
