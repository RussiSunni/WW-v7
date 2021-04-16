using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyController_FSM : MonoBehaviour
{
    private FairyBaseState currentState;
    public readonly FairySilentState SilentState = new FairySilentState();
    public readonly FairyTeachingState TeachingState = new FairyTeachingState();

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

