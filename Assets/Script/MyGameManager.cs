using UnityEngine;
using UnityEngine.SceneManagement;

public class MyGameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject completelevelUI;
    public void Completelevel()
    {
        completelevelUI.SetActive(true);
    }
	public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over !!");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
