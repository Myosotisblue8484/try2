using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Async_Loader : MonoBehaviour
{

    [SerializeField] private float loadingTime;
    
    
    void Start()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        string targetScene = PassLevelData.instance.SceneToLoad;
            
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(targetScene);
        asyncLoad.allowSceneActivation = false;
        
        float timer = 0f;

        while (timer < loadingTime)
        {
            timer += Time.deltaTime;
            
            
            yield return null;
        }
        
        asyncLoad.allowSceneActivation = true;
    }
}
