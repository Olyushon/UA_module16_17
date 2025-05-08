using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactableObject : MonoBehaviour
{
    private IRestBehaviour _restBehaviour;
    private IActBehaviour _actBehaviour;
    private GameObject _actionTarget;

    private bool isActivated = false;

    public void Initialize(Configuration configuration, GameObject actionTarget)
    {
        _restBehaviour = configuration.GetRestBehaviour();
        _actBehaviour = configuration.GetActBehaviour();
        _actionTarget = actionTarget;
    }

    private void Update()
    {
        if (isActivated)
            Act();
        else
            Rest();
    }

    private void Rest()
    {
        if (_restBehaviour != null)
            _restBehaviour.Rest(gameObject, Time.deltaTime);
    }
    private void Act()
    {
        if (_actBehaviour != null)
            _actBehaviour.Act(gameObject, _actionTarget, Time.deltaTime);
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
