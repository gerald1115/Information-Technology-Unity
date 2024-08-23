using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI; // 確保你引入了UI命名空間

public class ChangeSceneAction : MakerAction
{
    [SerializeField] private GameObject _currentSceneGameObject;
    [SerializeField] private GameObject _nextSceneGameObject;

    
    public override void Do()
    {
        _currentSceneGameObject.SetActive(false);
        _nextSceneGameObject.SetActive(true);
    }
}
