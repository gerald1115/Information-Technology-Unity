using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    [SerializeField] private Button _backgrounButton;
    [SerializeField] private Text _text;

    public static void Open(string content)
    {
        var dialog = Instantiate(Resources.Load<Dialog>("Dialog"));
        dialog.Show(content);
    }

    public void Show(string content)
    {
        _text.text = content;
        _backgrounButton.onClick.AddListener(_Close);
    }

    public void _Close()
    {
        _backgrounButton.onClick.RemoveListener(_Close);
        Destroy(gameObject);
    }
}


