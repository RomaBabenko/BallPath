using UnityEngine;

public class LevelUp : MonoBehaviour
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
