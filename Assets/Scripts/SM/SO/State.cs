using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="State",menuName ="SM/State",order =0)]
public class State : ScriptableObject
{
    
    public Action[] actions;
    public Transition[] transitions;

    public void UpdateState(StateController controller) {
        DoAction(controller);
        CheckTranision(controller);
    }
    private void DoAction(StateController controller) {
        for (int i = 0; i < actions.Length; i++)
        {
            actions[i].Act(controller);
        }
    }

    private void CheckTranision(StateController controller) {
        bool isStateChanged = false;
        for (int i = 0; i < transitions.Length; i++)
        {
            if (transitions[i].decision.Decide(controller))
            {
                isStateChanged = controller.TranisitionToState(transitions[i].trueState);
            }
            else {
                isStateChanged = controller.TranisitionToState(transitions[i].falseState);
            }
            if (isStateChanged)
                break;
        }
    }
}
