using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMakerAction 
{
    void Do();
}

public abstract class MakerAction : MonoBehaviour, IMakerAction
{
    public abstract void Do();
}
