using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogAction : MakerAction
{
    [SerializeField] private string _content;

    public override void Do()
    {
        Dialog.Open(_content);
    }
}
