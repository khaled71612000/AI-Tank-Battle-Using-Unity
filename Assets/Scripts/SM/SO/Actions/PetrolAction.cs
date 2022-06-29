using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Petrol Action",menuName ="SM/Actions/PetrolAction",order =0)]
public class PetrolAction : Action
{
    public override void Act(StateController controller)
    {
        Petrol(controller);
    }
    private void Petrol(StateController controller) {
        controller.Agent.destination = controller.PointsList[controller.CurrentPointIndex].position;
        controller.Agent.isStopped = false;
        if (controller.Agent.remainingDistance <= controller.Agent.stoppingDistance && !controller.Agent.pathPending) {
            controller.CurrentPointIndex = ++controller.CurrentPointIndex % controller.PointsList.Count;
        }
    }
}
