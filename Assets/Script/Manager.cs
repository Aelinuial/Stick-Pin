using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    private bool isGameOver = false;
    public Spawner spawner;
    public Rotater rotater;

	// Use this for initialization
	void Start () {
        Screen.SetResolution(450, 750, false);
    }
	
    public void GameOver()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            spawner.enabled = false;
            rotater.enabled = false;
            GetComponent<Animator>().SetTrigger("Gameover");
            Debug.Log("Game Over");
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
