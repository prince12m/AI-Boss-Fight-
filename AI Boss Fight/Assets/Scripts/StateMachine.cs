/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;*/

public class StateMachine
{
    public StateMachine currentstate;

    
     * public void Initialzize(StateMachine startingState)
    {
        currentstate = startingState;
        startingState.Enter();
    }

    public void ChangeState(StateMachine newState)
    {
        currentstate.Exit();

        currentstate = newState;
        newState.Enter();
    }

}/**/
