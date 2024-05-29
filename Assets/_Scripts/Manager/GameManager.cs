using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int _score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }
    
    void Start()
    {
        NewGame();
    }
    public void NewGame()
    {
        SceneManager.LoadScene("GameScene");
        _score = 0;
    }

    public int AddScore(int score)
    {
        _score += score;
        return _score;
    }
}
