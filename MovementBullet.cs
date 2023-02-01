using System.Collections;
using UnityEngine;

public class MovementBullet : MonoBehaviour
{
    [SerializeField] private float _speedMov;
    Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!Input.GetMouseButton(0))
        {
            MovementForward();
        }
    }

    private void MovementForward()
    {
        rigidbody.AddForce(0, 0, _speedMov);
    }
}
