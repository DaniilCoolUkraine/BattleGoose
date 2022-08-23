using System;
using UnityEngine;
using UnityEngine.UI;

public class UIPoints : MonoBehaviour
{
    public float Points { get; private set; }

    [SerializeField] private Text _score;

    void Update()
    {
        Points += Time.deltaTime;
        _score.text = Mathf.Round(Points).ToString();
    }
}
