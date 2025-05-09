using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactableObject : MonoBehaviour
{
    private IBehaviour _restBehaviour;
    private IBehaviour _actBehaviour;
    private GameObject _actionTarget;

    private IBehaviour _currentBehaviour;

    public void Initialize(IBehaviour restBehaviour, IBehaviour actBehaviour)
    {
        _restBehaviour = restBehaviour;
        _actBehaviour = actBehaviour;

        _currentBehaviour = _restBehaviour;
    }

    private void Update()
    {
        if (_currentBehaviour != null)
            _currentBehaviour.Update(Time.deltaTime);
    }

    public void Activate()
    {
        _currentBehaviour = _actBehaviour;
    }
    public void Deactivate()
    {
        _currentBehaviour = _restBehaviour;
    }
}
