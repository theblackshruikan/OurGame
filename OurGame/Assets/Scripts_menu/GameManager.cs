using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public UIManager ui;
    public Canvas canvasMenu;
    public Canvas canvasNew;
    public Canvas canvasLoad;
    public Canvas canvasOption;

    // Use this for initialization
    void Start () {
        canvasMenu = GameObject.Find("Canvas_Main_Menu").GetComponent<Canvas>();
        canvasNew = GameObject.Find("Canvas_New_Game").GetComponent<Canvas>();
        canvasLoad = GameObject.Find("Canvas_Load_Game").GetComponent<Canvas>();
        canvasOption = GameObject.Find("Canvas_Option").GetComponent<Canvas>();
        ui = GetComponent<UIManager>();

        DisableCanvas();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        canvasMenu.enabled = false;
        canvasNew.enabled = true;
    }

    public void LoadGame()
    {
        canvasLoad.enabled = true;
        canvasMenu.enabled = false;

    }

    public void DeleteGame()
    {
        canvasLoad.enabled = true;
        canvasMenu.enabled = false;

    }

    public void Option()
    {
        canvasOption.enabled = true;
        canvasMenu.enabled = false;

    }

    public void Exit()
    {
        Application.Quit();
    }

    void DisableCanvas()
    {
        canvasNew.enabled = false;
        canvasLoad.enabled = false;
        canvasOption.enabled = false;
    }
}
