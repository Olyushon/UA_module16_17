using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroling : IRestBehaviour
{
    private float _speed = 10f;
    private Queue<Vector3> _wayPoints = new Queue<Vector3>(new List<Vector3> {
        new Vector3(20, 0, 0),
        new Vector3(0, 0, 20),
        new Vector3(-20, 0, 0),
        new Vector3(0, 0, -20)
    });
    private float _minDistanceToPoint = 0.1f;
    private Vector3 _currentPoint;

    public Patroling()
    {
        SwitchPoint();
    }

    public void Rest(GameObject actor, float deltaTime)
    {
        if (Vector3.Distance(actor.transform.position, _currentPoint) <= _minDistanceToPoint)
        {
            SwitchPoint();
        }
        actor.transform.position = Vector3.MoveTowards(actor.transform.position, _currentPoint, _speed * deltaTime);
    }

    private void SwitchPoint()
    {
        _currentPoint = _wayPoints.Dequeue();
        _wayPoints.Enqueue(_currentPoint);
    }
}
