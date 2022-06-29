using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Reach Decision", menuName = "SM/Decisions/ReachDecision", order = 0)]

public class ReachedDestitions : Decision
{
    public override bool Decide(StateController controller)
    {
        if (controller.Agent.destination == controller.Target.transform.position - Vector3.one * 5)
        {
            controller.Agent.isStopped = true;
            return true;
        }
        return false;
    }
}
