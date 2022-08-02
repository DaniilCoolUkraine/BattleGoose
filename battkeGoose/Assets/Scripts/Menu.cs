using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _startMenu;

    public void Play()
    {
        _startMenu.gameObject.SetActive(false);
    }
    public void OpenMarket(){}
    public void Options(){}
    public void SwitchVibration(){}
    public void SwitchSound(){}
    public void Restart(){}
}
