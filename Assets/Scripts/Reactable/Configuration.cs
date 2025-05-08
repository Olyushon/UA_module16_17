using UnityEngine;

public class Configuration : MonoBehaviour
{
    [SerializeField] private RestStrategies _restStrategy;
    [SerializeField] private ActStrategies _actStrategy;

    public IRestBehaviour GetRestBehaviour()
    {
        switch (_restStrategy)
        {
            case RestStrategies.Stay:
                return new Staying();
            case RestStrategies.Patrol:
                return new Patroling();
            case RestStrategies.RandomWalk:
                return new RandomWalking();
            default:
                return null;
        }
    }
    public IActBehaviour GetActBehaviour()
    {
        switch (_actStrategy)
        {
            case ActStrategies.Follow:
                return new Following();
            case ActStrategies.RunAway:
                return new RunningAway();
            case ActStrategies.Die:
                return new Dying();
            default:
                return null;
        }
    }
    
}
