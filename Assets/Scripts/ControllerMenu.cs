using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;

public class ControllerMenu : MonoBehaviour
{
    public void ElegirEscena()
    {
        SceneManager.LoadScene("Game");
    }

    public void Gimnasio()
    {
        SceneManager.LoadScene("Gimnasio");
    }

    public void Exit()
    {
        #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }
}