using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPanel : MonoBehaviour {

    public Text points;
    PlayerBehaviour playerBehaviour;

    void Awake()
    {
        Hide();
        playerBehaviour = FindObjectOfType<PlayerBehaviour>();
    }
    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }
    public void RingText()
    {
        points.text = " You have collected " + playerBehaviour.ringCount + " rings.";
    }
}
