using UnityEngine;

public class Configuration : MonoBehaviour
{
    [SerializeField] private RestStrategies _restStrategy;
    [SerializeField] private ActStrategies _actStrategy;

    public RestStrategies RestStrategy => _restStrategy;
    public ActStrategies ActStrategy => _actStrategy;
}
