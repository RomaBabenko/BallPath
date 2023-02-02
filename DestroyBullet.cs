using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    private Object _explosion, _explosion2;

    private void Start()
    {
        _explosion = Resources.Load("explosion");
        _explosion2 = Resources.Load("explosion2");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "pillar")
        {
                CreateParticles();
                Destroy(gameObject);
        }

        if (collision.gameObject.name == "Door")
        {
            Destroy(gameObject);
        }
    }

    private void CreateParticles()
    {
        Instantiate(_explosion, transform.position, transform.rotation);
        Instantiate(_explosion2, transform.position, transform.rotation);
    }
}
