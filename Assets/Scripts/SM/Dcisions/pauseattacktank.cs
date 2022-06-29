using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Complete
{ 
[CreateAssetMenu(fileName = "pause attack tank", menuName = "SM/Actions/pauseattacktank", order = 0)]
public class pauseattacktank : Action
{
    public override void Act(StateController controller)
    {
            controller.fired();

    }

}
}