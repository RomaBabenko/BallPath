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
        //transform.position += new Vector3(0, 0, speedMov) * Time.deltaTime;
        //transform.Rotate(new Vector3(speedRot, 0, 0));
        //transform.Translate(Vector3.forward * speedMov * Time.deltaTime);
        //transform.position = Vector3.MoveTowards(transform.position, target.position, speedMov * Time.deltaTime);
        //Vector3 movement = new Vector3(0, 0, transform.position.z * speedRot);
        //rigidbody.AddForce(movement);

        rigidbody.AddForce(0, 0, _speedMov);
    }
}
