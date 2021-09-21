using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Behaviour : MonoBehaviour
{
    private int NextSceneIndex;
    private int PreviousSceneIndex;

    void Start()
    {
        NextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        PreviousSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
    }

    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnNextButtonPressed()
    {

        SceneManager.LoadScene(NextSceneIndex);
    }

    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene(PreviousSceneIndex);
    }
}
