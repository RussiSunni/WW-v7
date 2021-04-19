using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyController_FSM : MonoBehaviour
{
    private FairyBaseState currentState;
    public readonly FairySilentState SilentState = new FairySilentState();
    // public readonly FairyTeachingState TeachingState = new FairyTeachingState();
    public readonly FairyGetUserDetailsState GetUserDetailsState = new FairyGetUserDetailsState();
    public readonly FairyTeachingLevel1State TeachingLevel1State = new FairyTeachingLevel1State();

    private void Start()
    {
        TransitionToState(SilentState);
    }
    void Update()
    {
        currentState.Update(this);
    }

    public void TransitionToState(FairyBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }


}

