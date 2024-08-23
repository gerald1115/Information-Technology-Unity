using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class AndCondition : Condition
{
    [SerializeField] private Condition[] _conditions;

    public override bool Satisfy()
        => _conditions.All(Condition => Condition.Satisfy());
    
}
