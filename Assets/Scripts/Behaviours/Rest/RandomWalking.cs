using UnityEngine;

public class RandomWalking : IRestBehaviour
{
    private float _speed = 10f;
    private float _timeStep = 1f;
    private float _minPosition = -40f;
    private float _maxPosition = 40f;
    private Vector3 _targetPoint;
    private float _time = 0f;

    public RandomWalking()
    {
        _targetPoint = GetRandomPoint();
    }

    public void Rest(GameObject actor, float deltaTime)
    {
        _time += deltaTime;

        if (_time >= _timeStep)
        {
            _targetPoint = GetRandomPoint();
            _time = 0f;
        }

        actor.transform.position = Vector3.MoveTowards(actor.transform.position, _targetPoint, _speed * deltaTime);
    }

    private Vector3 GetRandomPoint()
    {
        return new Vector3(Random.Range(_minPosition, _maxPosition), 0, Random.Range(_minPosition, _maxPosition));
    }
}
