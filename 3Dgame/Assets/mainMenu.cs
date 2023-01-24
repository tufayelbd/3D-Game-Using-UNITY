using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    public void PlayGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

    }
    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();


    }
    public void developMenu() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    
    }
    // Update is called once per frame
    void Update()
    {

    }

}