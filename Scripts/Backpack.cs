using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    private HashSet<string> ownItems = new HashSet<string>();

    public void GetItem(string itemId)
    {
        ownItems.Add(itemId);
    }

    public void UseItem(string itemId)
    {
        ownItems.Remove(itemId);
    }

    public bool Hasitem(string itemId)
        => ownItems.Contains(itemId);


}
