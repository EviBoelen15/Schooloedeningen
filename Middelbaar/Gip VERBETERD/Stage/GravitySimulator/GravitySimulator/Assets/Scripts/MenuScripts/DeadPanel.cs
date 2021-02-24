using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPanel : MonoBehaviour {

    void Awake()
    {
        Hide();
    }
    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
