using UnityEngine;

public class ReactableObjectActivator : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ReactableObject reactableObject = other.GetComponent<ReactableObject>();

        if (reactableObject != null)
            reactableObject.Activate();
    }   
    private void OnTriggerExit(Collider other)
    {
        ReactableObject reactableObject = other.GetComponent<ReactableObject>();

        if (reactableObject != null)
            reactableObject.Deactivate();
    }
}
