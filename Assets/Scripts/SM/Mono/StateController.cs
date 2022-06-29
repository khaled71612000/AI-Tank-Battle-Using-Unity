using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform eye;
    [SerializeField] State currentState;
    [SerializeField] GameObject target;
    [SerializeField] float eyeRange;
    [SerializeField] List<Transform> pointsList;

    private int currentPointIndex;

    public NavMeshAgent Agent { get => agent; set => agent = value; }
    public List<Transform> PointsList { get => pointsList; set => pointsList = value; }
    public int CurrentPointIndex { get => currentPointIndex; set => currentPointIndex = value; }
    public GameObject Target { get => target; set => target = value; }
    public Transform Eye { get => eye; set => eye = value; }
    public float EyeRange { get => eyeRange; set => eyeRange = value; }
    bool isFired;

    void Start()
    {
        
    }
    public bool IsTargetAlive()
    {
        return target.activeSelf;
    }
    public void fired()
    {
        if (isFired)
            return;
       GetComponent<Complete.TankShooting>().Fire();
        isFired = true;
    }
    public bool TranisitionToState(State nextState) {

        if (nextState != currentState)
        {
            currentState = nextState;
            return true;
        }
        return false;
        
    }
    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

}
