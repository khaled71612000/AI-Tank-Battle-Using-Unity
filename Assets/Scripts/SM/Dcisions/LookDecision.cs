using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Look Decision", menuName = "SM/Decisions/LookDecision", order = 0)]
public class LookDecision : Decision
{
    public override bool Decide(StateController controller)
    {
        bool targetOnSpot = Look(controller);
        Debug.Log(targetOnSpot);
        return targetOnSpot;
    }

    private bool Look(StateController controller) {
        RaycastHit hit;
        Debug.DrawRay(controller.Eye.position, controller.Eye.forward * controller.EyeRange, Color.green);
        if (Physics.SphereCast(controller.Eye.position, 5, controller.Eye.forward, out hit, controller.EyeRange)) {
            Debug.LogError(hit.collider.gameObject.name);
            if (controller.Target == hit.collider.gameObject)
                return true;
        }
        return false;
    }
}
