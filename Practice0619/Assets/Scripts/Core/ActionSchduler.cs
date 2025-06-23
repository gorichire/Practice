using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class ActionSchduler : MonoBehaviour
    {
        MonoBehaviour currentAction;
        public void StartAction(MonoBehaviour Action)
        {
            if (currentAction == Action) return;
            if(currentAction != null)
            {
                print("cancelling" + currentAction);
            }
            currentAction = Action;
        }
    }
}
