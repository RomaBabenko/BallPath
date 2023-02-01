using UnityEngine;

public class DoorIsOpen : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    [SerializeField] private LevelUp _levelUp;
    [SerializeField] private ParticleSystem _portal;
    [SerializeField] private GameObject _deathScreen;

    private void OnTriggerEnter(Collider collider)
    {
        if (!_deathScreen.activeSelf)
        {
            if (collider.gameObject.tag == "ballBullet")
            {
                _portal.Play();
                _levelUp.NextLevelScreen();
                _anim.SetBool("isOpen", true);
            }
        }
    }
}