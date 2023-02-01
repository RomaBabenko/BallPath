using UnityEngine;

public class DecreasePlayerBall : MonoBehaviour
{
    [SerializeField] private float _speedDecrease;
    [SerializeField] private int _healthPlayer;
    [SerializeField] private GameOver _gameOver;
    [SerializeField] private Transform _shotPoint;
    [SerializeField] private ParticleSystem _explosion, _explosion2;

    private void Update()
    {
        if (GameObject.FindWithTag("ballBullet").transform.position.z == _shotPoint.position.z)
        {
            if (Input.GetMouseButton(0))
            {
                Decrease();
                _healthPlayer--;

                if (_healthPlayer <= 0)
                {
                    PlayerDestroyed();
                    Destroy(gameObject);
                    _gameOver.GameOverScreen();
                }
            }
        }
    }

    private void Decrease()
    {
        transform.localScale -= new Vector3(_speedDecrease, _speedDecrease, _speedDecrease) * Time.deltaTime;
    }

    private void PlayerDestroyed()
    {
        _explosion.Play();
        _explosion2.Play();
    }
}
