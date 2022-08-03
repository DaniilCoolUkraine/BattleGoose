using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _startMenu;
    [SerializeField] private GameObject _hud;
    [SerializeField] private GameObject _spawners;
    [SerializeField] private GameObject _defender;

    public void Play()
    {
        SwitchGameState(true);
    }
    public void OpenMarket(){}
    public void Options(){}
    public void SwitchVibration(){}
    public void SwitchSound(){}
    public void Restart(){}

    private void SwitchGameState(bool state)
    {
        _startMenu.gameObject.SetActive(!state);
        _hud.gameObject.SetActive(state);
        _spawners.gameObject.SetActive(state);
        _defender.gameObject.GetComponent<Player>().enabled = state;
        
        gameObject.GetComponent<MoveBackground>().enabled = state;
        gameObject.GetComponent<UIPoints>().enabled = state;
    }
}
