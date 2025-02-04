using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int maxScore = 4;

    public static GameManager instance;

    void Awake() {
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore() {
        ++score;
        Debug.Log("Score: "+score);
        if (score >= maxScore) {
            LoadNewScene();
        }
    }
    public void LoadNewScene() {
        SceneManager.LoadScene("VictoryScene");
    }
}
