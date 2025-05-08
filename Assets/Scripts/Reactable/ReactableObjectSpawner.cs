using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactableObjectSpawner : MonoBehaviour
{
    [SerializeField] private ReactableObject _reactableObjectPrefab;
    [SerializeField] private GameObject _actionTarget;
    [SerializeField] private List<Configuration> _spawnPoints;

    private void Awake()
    {
        foreach (Configuration spawnPoint in _spawnPoints)
        {
            Configuration configuration = spawnPoint.GetComponent<Configuration>();

            if (configuration != null)
            {
                ReactableObject reactableObject = Instantiate(_reactableObjectPrefab, spawnPoint.transform.position, Quaternion.identity);
                reactableObject.Initialize(configuration, _actionTarget);
            }
        }
    }
}
