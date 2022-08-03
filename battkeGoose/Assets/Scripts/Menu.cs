using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    
    [Header("Play items")]
    [SerializeField] private GameObject _startMenu;
    [SerializeField] private GameObject _hud;
    [SerializeField] private GameObject _spawners;
    [SerializeField] private GameObject _defender;

    [Header("Marketplace items")]
    [SerializeField] private GameObject _marketplace;
    
    [Header("Options items")]
    [SerializeField] private GameObject _vibrationButton;
    [SerializeField] private GameObject _soundButton;
    
    public void Play()
    {
        SwitchGameState(true);
    }
    public void OpenMarket()
    {
        _marketplace.gameObject.SetActive(true);
    }
    public void CloseMarket()
    {
        _marketplace.gameObject.SetActive(false);
    }
    public void Options()
    {
        PlayOptionsAnimation();
    }
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

    private void PlayOptionsAnimation()
    {
        _vibrationButton.GetComponent<Animation>().Play();
        _soundButton.GetComponent<Animation>().Play();
    }
    
}
