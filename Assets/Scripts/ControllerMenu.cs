using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Net.Mime.MediaTypeNames;
using System.Collections;

public class ControladorMenuPrincipal : MonoBehaviour
{
    public void CargarEscena(string Escena)
    {
        SceneManager.LoadScene(Escena);
    }

    public void Gimnasio()
    {
        SceneManager.LoadScene("Gimnasio");
    }
}