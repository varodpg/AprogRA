using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambiarEscena : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button PlayButton;
    public Button OptionsButton;
    public Button HowPlayButton;
    public Button Back;
    public Button BackLevels, BackHow;
    public Button Levels;
    public Canvas CanvasMenu, CanvasOptions, CanvasHowPlay, CanvasLevels;
 

    void Start()
    {
        PlayButton.onClick.AddListener(StartLevel);
        OptionsButton.onClick.AddListener(Options);
        HowPlayButton.onClick.AddListener(HowPlay);
        Back.onClick.AddListener(GoBack);
        BackHow.onClick.AddListener(GoBack);
        Levels.onClick.AddListener(GoLevels);
        BackLevels.onClick.AddListener(GoBackLevels);
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
    public void StartLevel()
    {
        SceneManager.LoadScene("Level1");
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
}