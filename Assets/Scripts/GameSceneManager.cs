using UnityEngine;

public class GameSceneManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LevelManager levelManager = FindFirstObjectByType<LevelManager>();
        levelManager.StartLevel(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
