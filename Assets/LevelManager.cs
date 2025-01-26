
using UnityEngine;
using UnityEngine.SceneManagement;

class LevelManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Win()
    {
        Debug.Log("Win");

        // show ui

    }

    public void StartLevel(int level)
    {
        // reset item to default
        if (level > 1)
        {
            SceneManager.UnloadSceneAsync("Level" + (level - 1));
        }
    
        // load level
        SceneManager.LoadScene("Level" + level, LoadSceneMode.Additive);
    }
}