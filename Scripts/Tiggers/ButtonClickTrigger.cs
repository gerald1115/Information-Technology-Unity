using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickTrigger : MonoBehaviour
{
    [SerializeField] private Button _button; // 修正 _botton 為 _button
    [SerializeField] private Condition _condition;
    [SerializeField] private MakerAction[] _satisfiedConditionAction;
    [SerializeField] private MakerAction[] _unsatisfiedConditionAction;

    private void Start()
    {
        _button.onClick.AddListener(_Trigger);
    }

    private void OnDestroy() // 修正 Destroy 為 OnDestroy
    {
        _button.onClick.RemoveListener(_Trigger); // 修正 RemoveListener 拼寫
    }

    private void _Trigger()
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
