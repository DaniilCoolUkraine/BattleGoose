using System;
using UnityEngine;

public class LevelPosition : MonoBehaviour
{
    public bool SetInPlace
    {
        get;
        set;
    }

    public Vector2 FirstPosition { get; set; }
    public Vector2 FinalPosition { get; set; }
    
    public Vector2 AnchoredPosition
    {
        get
        {
            return gameObject.GetComponent<RectTransform>().anchoredPosition;
        }
        set
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = value;
        }
    }
    public Vector2 Size
    {
        get
        {
            return gameObject.GetComponent<RectTransform>().sizeDelta;
        }
    }

    private ChangeLevels gameController;
    
    private void Awake()
    {
        gameController = GameObject.FindWithTag("GameController").GetComponent<ChangeLevels>();
    }

    private void Start()
    {
        SetInPlace = true;
        FirstPosition = AnchoredPosition;
    }
    
    public void MoveToScreen(float _speed)
    {
        if (RoughlyEqual(AnchoredPosition, FinalPosition))
        {
            SetInPlace = true;
            gameController.changedState = false;
            
            AnchoredPosition = FinalPosition;
            FirstPosition = AnchoredPosition;
            return;
        }
        
        AnchoredPosition -= new Vector2(0, Size.y) * Time.deltaTime * _speed;

        float downBorder = 350 - Size.y + 1;
        if (AnchoredPosition.y <= downBorder)
        {
            SetInPlace = true;
            gameController.changedState = false;
            
            AnchoredPosition = FinalPosition;
            FirstPosition = AnchoredPosition;
        }
    }

    private bool RoughlyEqual(Vector2 first, Vector2 second)
    {
        float difference = first.y - second.y;
        if (difference <= 0.5 && difference >= 0)
            return true;
        return false;
    }

}
