using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAction : MakerAction
{
    [SerializeField] private Condition _condition;
    [SerializeField] private MakerAction[] _satisfiedConditionAction;
    [SerializeField] private MakerAction[] _unsatisfiedConditionAction;


    public override void Do()
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
