using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {

    public static GameOverManager instance;

    private GameObject gameOverPanel;
    private Animator gameOverAnim;

    private Button playAgainBtn, backBtn;

    //private Text finalScore;

    void Awake()
    {
        MakeInstance();
        IntitializeVariables();
    }

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void GameOverShowPanel()
    {
        Debug.Log("GameOverManager");
        gameOverPanel.SetActive(true);
        //gameOverAnim.Play("FadeIn");
    }

    void IntitializeVariables()
    {
        gameOverPanel = GameObject.Find("t");
        //gameOverAnim = gameOverPanel.GetComponent <Animator> ();

        playAgainBtn = GameObject.Find("Restart Button").GetComponent<Button>();
        backBtn = GameObject.Find("Back Button").GetComponent<Button>();

        playAgainBtn.onClick.AddListener(() => PlayAgain());
        backBtn.onClick.AddListener(() => BacktoMenu());

        //finalScore = GameObject.Find("Final Score").GetComponent<Text>();

        gameOverPanel.SetActive(false);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
