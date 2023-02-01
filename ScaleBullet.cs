using UnityEngine;

public class ScaleBullet : MonoBehaviour
{
    [SerializeField] private float _speedScale;
    [SerializeField] private Transform _shotPoint;

    private void Update()
    {
        if (transform.position.z == _shotPoint.position.z)
        {
            if (Input.GetMouseButton(0))
            {
                Scale();
            }
        }
    }
    
    private void Scale()
    {
        transform.localScale += new Vector3(_speedScale, _speedScale, _speedScale) * Time.deltaTime;
    }
}
