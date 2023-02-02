using UnityEngine;

public class LevelUpScreen : MonoBehaviour
{
    [SerializeField] private GameObject _progressScreen;

    public void NextLevelScreen()
    {
        Invoke("LevelPassed", 2f);
    }

    private void LevelPassed()
    {
        _progressScreen.SetActive(true);
    }
}
