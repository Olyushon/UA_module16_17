using UnityEngine;

public class MoveController : MonoBehaviour
{
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    private float _speed = 30f;
    private float _rotationSpeed = 100f;

    private float _xInput;
    private float _yInput;
    private float _deadZone = 0.1f;

    private void Update()
    {
        _xInput = Input.GetAxisRaw(Horizontal);
        _yInput = Input.GetAxisRaw(Vertical);

        if (Mathf.Abs(_xInput) > _deadZone)
            transform.Rotate(transform.up, _rotationSpeed * _xInput * Time.deltaTime, Space.World);

        if (Mathf.Abs(_yInput) > _deadZone)
            transform.Translate(transform.forward * _speed * _yInput * Time.deltaTime, Space.World);
    }
}
