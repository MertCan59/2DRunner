using UnityEngine;
using UnityEngine.SceneManagement;

public class InitialGame : MonoBehaviour
{
    // I just tired to use Input System so i decided to do that way
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
