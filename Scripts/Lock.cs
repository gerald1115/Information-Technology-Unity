using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Lock : Condition
{
    [SerializeField] private GameObject[] item;
    [SerializeField] private int _answerIdex = 0;
    [SerializeField] private Button _upbutton;
    [SerializeField] private Button _downbutton;

    private int _currentIndex = 0;

    public event Action OnChange;

    void Start()
    {
        _Showitems();

        _upbutton.onClick.AddListener(_ChangePreviousItem);
        _downbutton.onClick.AddListener(_ChangeNextItem);
    }

    private void OnDestroy()
    {
       Disable();
    }

    private void _Showitems()
    {
        for (int i =0; i< item.Length; i++)
        {
            item[i].SetActive(i == _currentIndex);
        }
    }
   
   private void _ChangePreviousItem()
   {
    _currentIndex = ((_currentIndex - 1) + item.Length) % item.Length;
    _Showitems();
    OnChange?.Invoke();
   }

   private void _ChangeNextItem()
   {
    _currentIndex = (_currentIndex + 1) % item.Length;
    _Showitems();
    OnChange?.Invoke();
   }

   public override bool Satisfy()
        => _currentIndex == _answerIdex;

    public void Disable()
    {
        _upbutton.onClick.RemoveListener(_ChangePreviousItem);
        _downbutton.onClick.RemoveListener(_ChangeNextItem);
    }
}
