using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Octavia;

public class ButtonManager: MonoBehaviour {
    public UIManager ui;
    public Canvas canvasMenu;
    public Canvas canvasNew;
    public Canvas canvasLoad;
    public Canvas canvasOption;

    Game game;
    Difficulty difficulty;
    string bandName;
    StyleBand styleBand;

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

    public void NextCanvasButton(Canvas nextCanvas)
    {
        canvasMenu.enabled = false;
        nextCanvas.enabled = true;
    }

    public void BackCanvasButton(Canvas presentCanvas)
    {
        presentCanvas.enabled = false;
        canvasMenu.enabled = true;
    }

    public void NewGame()
    {
        game = new Game(difficulty, styleBand, bandName);
        Application.LoadLevel("KyCity");
    }
}
