using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "hold tank", menuName = "SM/Actions/TaankHold", order = 0)]

public class HoldTank : Action
{
    public override void Act(StateController controller)
    {
        if(controller.Agent.destination == controller.Target.transform.position )
        {
        controller.Agent.isStopped = true;
        }
    }
}
