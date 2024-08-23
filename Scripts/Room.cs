using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Room : MonoBehaviour
{
    [SerializeField] private GameObject firstScene;
    [SerializeField] private GameObject winGameObject;
    // Start is called before the first frame update

    

    void Start()
    {
        firstScene.SetActive(true);
    }

    public void win()
    {
        winGameObject.SetActive(true);
    }

    
}
