using UnityEngine;

public abstract class FairyBaseState
{
    public abstract void EnterState(FairyController_FSM fairy);
    public abstract void Update(FairyController_FSM fairy);
}
