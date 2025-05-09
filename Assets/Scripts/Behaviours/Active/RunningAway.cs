using UnityEngine;

public class RunningAway : IBehaviour
{
    private float _speed = 10f;
    private GameObject _actor;
    private GameObject _target; 

    public RunningAway(GameObject actor, GameObject target)
    {
        _actor = actor;
        _target = target;
    }
    
    public void Update(float deltaTime)
    {
        Vector3 direction = (_actor.transform.position - _target.transform.position).normalized;
        Vector3 targetPosition = _actor.transform.position + direction * _speed;
        
        _actor.transform.position = Vector3.MoveTowards(_actor.transform.position, targetPosition, deltaTime * _speed);
    }
}
