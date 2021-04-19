using UnityEngine;

public abstract class FairyBaseState
{
    public Animator animator;

    public abstract void EnterState(FairyController_FSM fairy);
    public abstract void Update(FairyController_FSM fairy);
}
