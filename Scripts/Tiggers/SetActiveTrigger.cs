using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetActiveTrigger : MonoBehaviour
{
    [SerializeField] private Condition _condition;
    [SerializeField] private MakerAction[] _satisfiedConditionAction;
    [SerializeField] private MakerAction[] _unsatisfiedConditionAction;

    private void Start()
    {
        if (_condition == null || _condition.Satisfy())
        {
            foreach (var satisfiedConditionAction in _satisfiedConditionAction) // 修正 satisfiedConditioAction 為 satisfiedConditionAction
            {
                satisfiedConditionAction.Do();
            }
        }
        else
        {
            foreach (var unsatisfiedConditionAction in _unsatisfiedConditionAction)
            {
                unsatisfiedConditionAction.Do();
            }
        }
    }
}
