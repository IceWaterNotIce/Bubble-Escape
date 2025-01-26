using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbySceneManager : Singleton<LobbySceneManager>
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Debug.Log("Start Game");
        SceneManager.LoadScene("GameScene");
    }
}
