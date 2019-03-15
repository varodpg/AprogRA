using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambiarEscena : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button Level1, Level2, Level3, Level4, Level5;
    public Button OptionsButton;
    public Button HowPlayButton;
    public Button Back;
    public Button ExitButton, LinkButton;
    public Button BackLevels, BackHow;
    public Button Levels;
    public Canvas CanvasMenu, CanvasOptions, CanvasHowPlay, CanvasLevels;
 

    void Start()
    {
        Level1.onClick.AddListener(StartLevel1);
        Level2.onClick.AddListener(StartLevel1);
        Level3.onClick.AddListener(StartLevel1);
        Level4.onClick.AddListener(StartLevel1);
        Level5.onClick.AddListener(StartLevel1);
        OptionsButton.onClick.AddListener(Options);
        HowPlayButton.onClick.AddListener(HowPlay);
        Back.onClick.AddListener(GoBack);
        BackHow.onClick.AddListener(GoBack);
        Levels.onClick.AddListener(GoLevels);
        BackLevels.onClick.AddListener(GoBackLevels);
        ExitButton.onClick.AddListener(Exit);
        LinkButton.onClick.AddListener(GoURL);
        CanvasMenu.GetComponent<Canvas>().enabled = true;
        CanvasOptions.GetComponent<Canvas>().enabled = false;
        CanvasHowPlay.GetComponent<Canvas>().enabled = false;
        CanvasLevels.GetComponent<Canvas>().enabled = false;
    }
    public void GoLevels()
    {
        CanvasLevels.GetComponent<Canvas>().enabled = true;
        CanvasMenu.GetComponent<Canvas>().enabled = false;
        CanvasOptions.GetComponent<Canvas>().enabled = false;
        CanvasHowPlay.GetComponent<Canvas>().enabled = false;
    }
    public void StartLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void StartLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void StartLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void StartLevel4()
    {
        SceneManager.LoadScene("Level4");
    }
    public void StartLevel5()
    {
        SceneManager.LoadScene("Level5");
    }
    public void Options()
    {
        CanvasOptions.GetComponent<Canvas>().enabled = true;
        CanvasMenu.GetComponent<Canvas>().enabled = false;
        CanvasHowPlay.GetComponent<Canvas>().enabled = false;
    }
    public void HowPlay()
    {
        CanvasMenu.GetComponent<Canvas>().enabled = false;
        CanvasOptions.GetComponent<Canvas>().enabled = false;
        CanvasHowPlay.GetComponent<Canvas>().enabled = true;
    }
    public void GoBack()
    {
        CanvasOptions.GetComponent<Canvas>().enabled = false;
        CanvasMenu.GetComponent<Canvas>().enabled = true;
        CanvasHowPlay.GetComponent<Canvas>().enabled = false;
    }

    public void GoBackLevels()
    {
        CanvasLevels.GetComponent<Canvas>().enabled = false;
        CanvasMenu.GetComponent<Canvas>().enabled = true;
        CanvasHowPlay.GetComponent<Canvas>().enabled = false;
    }
    
    public void Exit()
    {
        Application.Quit();
    }

    public void GoURL()
    {
        Application.OpenURL("https://mega.nz/#F!2ZUG2K7T!B9mD6kKFWM_YhdeTSLegoQ");
    }
}