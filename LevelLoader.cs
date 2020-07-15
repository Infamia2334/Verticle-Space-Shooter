using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float deathDelay = 2f;

    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGameMain()
    {
        SceneManager.LoadScene("Game");
        FindObjectOfType<GameSession>().Reset();
    }

    public void LoadGameOver()
    {
        StartCoroutine(PlayerDeathDelay());
        
    }

    IEnumerator PlayerDeathDelay()
    {
        yield return new WaitForSeconds(deathDelay);
        SceneManager.LoadScene("Game Over");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
