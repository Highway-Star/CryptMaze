using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool TreasureTaken;
    [SerializeField]
    public Transform player;

    public static GameManager instance;

    [SerializeField]
    public GameObject ui_GameOverPage;

    [HideInInspector]
    public bool isGameOver = false;

    public void GameOver()
    {
        //Player Enemy Collision
        isGameOver = true;
        //ui_GameOverPage.SetActive(true);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
        //DontDestroyOnLoad(gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
