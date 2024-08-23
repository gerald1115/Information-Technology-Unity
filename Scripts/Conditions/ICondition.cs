using UnityEngine;

public interface ICondition
{
    bool Satisfy();
}

public abstract class Condition : MonoBehaviour, ICondition
{
    public abstract bool Satisfy();
}
