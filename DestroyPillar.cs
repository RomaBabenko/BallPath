using UnityEngine;

public class DestroyPillar : MonoBehaviour
{
    private MeshRenderer _meshRenderer;
    [SerializeField] private Material[] _hitMaterial;
    private Object _explosionPillar, _explosionPillar2;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _explosionPillar = Resources.Load("explosionPillar");
        _explosionPillar2 = Resources.Load("explosionPillar2");
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "ballBullet")
        {
            ColorChange();
            Invoke("CreateParticles", 0.7f);
            Destroy(gameObject, 0.7f);
        }
    }

    private void ColorChange()
    {
        _meshRenderer.materials = _hitMaterial ;
    }

    private void CreateParticles()
    {
        Instantiate(_explosionPillar, transform.position, transform.rotation);
        Instantiate(_explosionPillar2, transform.position, transform.rotation);
    }
}
