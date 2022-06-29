using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Target Alive Decision", menuName = "SM/Decisions/TargetAliveDecision", order = 0)]

public class TargetAliveDecision : Decision
{

    public override bool Decide(StateController controller)
    {
        bool isAlive = IsTargetAlive(controller);
        return isAlive;
    }

    private bool IsTargetAlive(StateController controller)
    {

        if (Vector3.Distance(controller.transform.position, controller.Target.transform.position) > 10)
            return controller.IsTargetAlive();
        else
            return !controller.IsTargetAlive();
    }


}
