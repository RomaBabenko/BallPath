using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private GameObject _deathScreen;

    public void GameOverScreen()
    {
        if (!_deathScreen.activeSelf)
        {
                Invoke("End", 1f);
        }
    }

    private void End()
    {
        _deathScreen.SetActive(true);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
