using UnityEngine;

public class Following : IActBehaviour
{
    private float _speed = 10f;
    private GameObject _actor;
    private GameObject _target;

    public Following(GameObject actor, GameObject target)
    {
        _actor = actor;
        _target = target;
    }   

    public void Update(float deltaTime)
    {
        _actor.transform.position = Vector3.MoveTowards(_actor.transform.position, _target.transform.position, deltaTime * _speed);
    }
}
