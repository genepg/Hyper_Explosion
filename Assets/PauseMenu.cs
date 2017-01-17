using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class PauseMenu : MonoBehaviour
{
    public static PauseMenu Instance;
    public GameObject GameOverTitle;
    public GameObject PauseUI;
    public GameObject resume;
    public GameObject endscore;
    public GameObject main;
    public GameObject restart;
    public GameObject finish;
    private bool paused = false;

    // Use this for initialization
    void Start()
    {
        Instance = this; //指定Instance這個程式
        GameOverTitle.SetActive(false);
        PauseUI.SetActive(false);
        finish.SetActive(false);

    }

    // Update is called once per frame
     void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            paused = !paused;
        }
        if (paused)
        {
            Camera.main.GetComponent<AudioSource>().Pause();
            PauseUI.SetActive(true);
            Time.timeScale = 0;


        }
        if (!paused)
        {
            Camera.main.GetComponent<AudioSource>().UnPause();
            PauseUI.SetActive(false);
            Time.timeScale = 1;

        }
    }
    public void Resume()
    {
        paused = false;
    }
    public void LoadSceneNum(int num)
    {

        paused = false;
        if (num < 0 || num >= SceneManager.sceneCountInBuildSettings)
        {
            Debug.LogWarning("Can't load scene num " + num + ", SceneManager only has " + SceneManager.sceneCountInBuildSettings + "scenes in Buildsettings!");
            return;
        }
        LoadingScreenManager.LoadScene(num);
    }
    public void GameOver()
    {

        paused = true;
        GameOverTitle.SetActive(true);
        PauseUI.SetActive(false);
        resume.SetActive(false);
        main.SetActive(true);
        restart.SetActive(true);
        finish.SetActive(false);
    }
    public void Endscore()
    {
       
        paused = true;
        GameOverTitle.SetActive(false);
        PauseUI.SetActive(false);
        resume.SetActive(false);
        main.SetActive(true);
        restart.SetActive(true);
        finish.SetActive(true);
    }

}
