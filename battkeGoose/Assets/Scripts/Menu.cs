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
    [SerializeField] private bool isClosed = true;
    [SerializeField] private GameObject _vibrationButton;
    [SerializeField] private GameObject _soundButton;
    
    [Header("Vibration options")]
    [SerializeField] private bool isVibration = true;
    
    [Header("Sound options")]
    [SerializeField] private bool isSound = true;

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
        if (isClosed)
        {
            PlayOpenAnimation();
            isClosed = false;
        }
        else
        {
            PlayCloseAnimation();
            isClosed = true;
        }
    }

    public void SwitchVibration()
    {
        if (isVibration)
        {
            TurnOffVibration();
            isVibration = false;
        }
        else
        {
            TurnOnVibration();
            isVibration = true;
        }
    }
    public void SwitchSound()
    {
        if (isSound)
        {
            TurnOffSound();
            isSound = false;
        }
        else
        {
            TurnOnSound();
            isSound = true;
        }
    }
    public void Restart(){}

    #region utilities

    //play or stop game
    private void SwitchGameState(bool state)
    {
        _startMenu.gameObject.SetActive(!state);
        _hud.gameObject.SetActive(state);
        _spawners.gameObject.SetActive(state);
        _defender.gameObject.GetComponent<Player>().enabled = state;
        
        gameObject.GetComponent<MoveBackground>().enabled = state;
        gameObject.GetComponent<UIPoints>().enabled = state;
    }

    //play animation to close or open options
    private void PlayOpenAnimation()
    {
        _vibrationButton.GetComponent<Animation>().Play("OpenVibration");
        _soundButton.GetComponent<Animation>().Play("OpenSound");
    }
    private void PlayCloseAnimation()
    {
        _vibrationButton.GetComponent<Animation>().Play("CloseVibration");
        _soundButton.GetComponent<Animation>().Play("CloseSound");
    }

    //turn on & turn off vibration
    private void TurnOffVibration()
    {
        Debug.Log("Vibration off");
        //Debug.Log("Sound off");
    }
    private void TurnOnVibration()
    {
        Debug.Log("Vibration on");
        //Debug.Log("Sound on");
    }
    
    //turn on & turn off sound
    private void TurnOffSound()
    {
        Debug.Log("Sound off");
    }
    private void TurnOnSound()
    {
        Debug.Log("Sound on");
    }
    
    #endregion
}
