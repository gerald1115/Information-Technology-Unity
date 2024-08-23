using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class OwnitemsCondition : Condition
{
    [SerializeField] private string[] _shouldOwnedItemsIds;
    [SerializeField] private Backpack _backpack;

    public override bool Satisfy()
        => _shouldOwnedItemsIds.All(_backpack.Hasitem);
}
