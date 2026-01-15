using UnityEngine;

public class PassLevelData : MonoBehaviour
{
    public static PassLevelData instance;
    public string SceneToLoad;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
        instance = this;
        
        DontDestroyOnLoad(gameObject);
    }
}
