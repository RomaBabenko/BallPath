using UnityEngine;

public class CreateBullet : MonoBehaviour
{
    [SerializeField] private Transform _shotPoint;
    [SerializeField] private GameObject _ballPrefab;
    private GameObject _bullet;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreatingBulletBall();
        }
    }

    private void CreatingBulletBall()
    {
        if (_bullet)
        {
            return;
        }
        _bullet = Instantiate(_ballPrefab, _shotPoint.position, _shotPoint.rotation);
    }
}
