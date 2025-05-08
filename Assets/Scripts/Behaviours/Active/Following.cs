using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following : IActBehaviour
{
    private float _speed = 10f;

    public void Act(GameObject actor, GameObject target, float deltaTime)
    {
        actor.transform.position = Vector3.MoveTowards(actor.transform.position, target.transform.position, deltaTime * _speed);
    }
}
