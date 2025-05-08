using UnityEngine;

public class RandomWalking : IRestBehaviour
{
    private float _speed = 10f;
    private GameObject _actor;
    private float _timeStep = 1f;
    private float _minPosition = -40f;
    private float _maxPosition = 40f;
    private Vector3 _targetPoint;
    private float _time = 0f;

    public RandomWalking(GameObject actor)
    {
        _actor = actor;
        _targetPoint = GetRandomPoint();
    }

    public void Update(float deltaTime)
    {
        _time += deltaTime;

        if (_time >= _timeStep)
        {
            _targetPoint = GetRandomPoint();
            _time = 0f;
        }

        _actor.transform.position = Vector3.MoveTowards(_actor.transform.position, _targetPoint, _speed * deltaTime);
    }

    private Vector3 GetRandomPoint()
    {
        return new Vector3(Random.Range(_minPosition, _maxPosition), 0, Random.Range(_minPosition, _maxPosition));
    }
}
