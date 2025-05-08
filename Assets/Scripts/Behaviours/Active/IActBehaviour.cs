using UnityEngine;

public interface IActBehaviour
{
    void Act(GameObject actor, GameObject target, float deltaTime);
}
