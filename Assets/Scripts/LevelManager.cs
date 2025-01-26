
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

class LevelManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int level = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public async void Win()
    {
        Debug.Log("Win");

        // show ui
        // show win screen
        level++;
        await StartLevel(level);
    }

    public async Task StartLevel(int level)
    {
        // reset item to default
        if (level > 1)
        {
            await SceneManager.UnloadSceneAsync("Level" + (level - 1));
        }
    
        // load level
        SceneManager.LoadScene("Level" + level, LoadSceneMode.Additive);

        // if load scene not success, return to lobby]
        await Task.Delay(1000);
        if (SceneManager.GetSceneByName("Level" + level).isLoaded == false)
        {
            SceneManager.LoadScene("Lobby");
        }
    }
}