using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // 確保你有引用UnityEngine.UI

public class TakeitemButton : MakerAction
{
   
    [SerializeField] private string itemId;
    [SerializeField] private GameObject itemGameObject;
    [SerializeField] private Backpack _backpack;


    private void Start()
    {
        if (_backpack.Hasitem(itemId) && itemGameObject != null)
        {
            itemGameObject.SetActive(false);
            return;
        }
    }
    
    public override void Do()
    {
        _backpack.GetItem(itemId);
        if( itemGameObject != null)
            itemGameObject.SetActive(false);
    }
}