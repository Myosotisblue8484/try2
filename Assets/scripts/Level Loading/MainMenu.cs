using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] public string nextLevelName;

  public void PlayGame()
    {
        PassLevelData.instance.SceneToLoad = nextLevelName;

        SceneManager.LoadSceneAsync(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
