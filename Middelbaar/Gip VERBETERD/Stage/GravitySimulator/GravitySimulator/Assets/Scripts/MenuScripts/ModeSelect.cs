using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ModeSelect : MonoBehaviour
{
    public Canvas cnv;
    public StartPanel startPanel;
    public DeadPanel deadPanel;
    public EndPanel endPanel;

    PlayerBehaviour playerBehaviour;
    SteamVR_LaserPointer laserPointer;

    VRUIInput laser;
    //private void Start()
    //{
    //    GetComponent<SteamVR_LaserPointer>().enabled = true;
    //}
    void Start()
    {
        startPanel.Show();
        playerBehaviour = FindObjectOfType<PlayerBehaviour>();
    }
    public void IsClickedStart(string mode)
    {
        startPanel.Hide();
        playerBehaviour.isClickedstart = true;
    }
    public void IsClickedTryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        playerBehaviour.ringCount = 0;
    }
    public void IsClickedCancel()
    {
        Application.Quit();
    }

}