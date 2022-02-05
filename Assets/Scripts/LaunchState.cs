using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchState : StateMachineBehaviour
{
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        EventManager.TriggerRocketmanLaunched();
    }
}
