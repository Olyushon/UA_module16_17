using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactableObject : MonoBehaviour
{
    private IRestBehaviour _restBehaviour;
    private IActBehaviour _actBehaviour;
    private GameObject _actionTarget;

    private bool isActivated = false;

    public void Initialize(IRestBehaviour restBehaviour, IActBehaviour actBehaviour)
    {
        _restBehaviour = restBehaviour;
        _actBehaviour = actBehaviour;
    }

    private void Update()
    {
        if (isActivated) {
            if (_actBehaviour != null)
                _actBehaviour.Update(Time.deltaTime);
        }
        else 
        {
            if (_restBehaviour != null)
                _restBehaviour.Update(Time.deltaTime);
        }
    }

    public void Activate()
    {
        isActivated = true;
    }
    public void Deactivate()
    {
        isActivated = false;
    }
}
