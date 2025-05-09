using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactableObjectSpawner : MonoBehaviour
{
    [SerializeField] private ReactableObject _reactableObjectPrefab;
    [SerializeField] private GameObject _actionTarget;
    [SerializeField] private List<Configuration> _spawnPoints;
    [SerializeField] private List<Transform> _patrolPoints;

    private void Awake()
    {
        foreach (Configuration spawnPoint in _spawnPoints)
        {
            Configuration configuration = spawnPoint.GetComponent<Configuration>();

            if (configuration != null)
            {
                ReactableObject reactableObject = Instantiate(_reactableObjectPrefab, spawnPoint.transform.position, Quaternion.identity);
                
                IBehaviour restBehaviour = GetRestBehaviour(configuration.RestStrategy, reactableObject.gameObject);
                IBehaviour actBehaviour = GetActBehaviour(configuration.ActStrategy, reactableObject.gameObject);
                
                reactableObject.Initialize(restBehaviour, actBehaviour);
            }
        }
    }

    private IBehaviour GetRestBehaviour(RestStrategies restStrategy, GameObject actor)
    {
        switch (restStrategy)
        {
            case RestStrategies.Stay:
                return new Staying();

            case RestStrategies.Patrol:
                return new Patroling(actor, _patrolPoints);
            
            case RestStrategies.RandomWalk:
                return new RandomWalking(actor);
            
            default:
                return null;
        }
    }
    private IBehaviour GetActBehaviour(ActStrategies actStrategy, GameObject actor)
    {
        switch (actStrategy)
        {
            case ActStrategies.Follow:
                return new Following(actor, _actionTarget);
            
            case ActStrategies.RunAway:
                return new RunningAway(actor, _actionTarget);
            
            case ActStrategies.Die:
                return new Dying(actor);
            
            default:
                return null;
        }
    }
}
