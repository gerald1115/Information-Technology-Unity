using System.Linq; // 確保加入這一行
using UnityEngine;
using UnityEngine.UI; // 確保加入這一行

public class WinAction : MakerAction
{
    [SerializeField] private Room room;

    public override void Do()
    {
        room.win();
    }
}