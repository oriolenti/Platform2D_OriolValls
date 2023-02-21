using UnityEngine;
using UnityEngine.SceneManagement;

public class EndProc : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("EndOfIncident");
        }
    }
}