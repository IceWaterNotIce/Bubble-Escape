using UnityEngine;

public class GameSceneManager : Singleton<GameSceneManager>
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LevelManager.Instance.StartLevel(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
