using UnityEngine;

public class RunningAway : IActBehaviour
{
    private float _speed = 10f;

    public void Act(GameObject actor, GameObject target, float deltaTime)
    {
        Vector3 direction = (actor.transform.position - target.transform.position).normalized;
        Vector3 targetPosition = actor.transform.position + direction * _speed;
        actor.transform.position = Vector3.MoveTowards(actor.transform.position, targetPosition, deltaTime * _speed);
    }
}
