using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Chase Action", menuName = "SM/Actions/ChaseAction", order = 0)]
public class ChaseAction : Action
{
    public override void Act(StateController controller)
    {
        Chase(controller);
    }
    private void Chase(StateController controller) {
        controller.Agent.destination = controller.Target.transform.position ;
        controller.Agent.isStopped = false;
    }
}
