using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroling : IBehaviour
{
    private float _speed = 10f;
    private GameObject _actor;
    private Queue<Vector3> _wayPoints;
    private float _minDistanceToPoint = 0.1f;
    private Vector3 _currentPoint;

    public Patroling(GameObject actor, List<Transform> wayPoints)
    {
        _actor = actor;
        _wayPoints = new Queue<Vector3>();

        foreach (Transform point in wayPoints)
            _wayPoints.Enqueue(point.position);
            
        SwitchPoint();
    }

    public void Update(float deltaTime)
    {
        if (Vector3.Distance(_actor.transform.position, _currentPoint) <= _minDistanceToPoint)
        {
            SwitchPoint();
        }
        
        _actor.transform.position = Vector3.MoveTowards(_actor.transform.position, _currentPoint, _speed * deltaTime);
    }

    private void SwitchPoint()
    {
        _currentPoint = _wayPoints.Dequeue();
        _wayPoints.Enqueue(_currentPoint);
    }
}
