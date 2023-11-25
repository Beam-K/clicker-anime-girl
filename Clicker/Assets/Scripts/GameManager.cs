using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private int clickCost = 1;

    [SerializeField] private TMP_Text scoreTMPro;


    private void Update()
    {
        scoreTMPro.text = _score.ToString();
    }

    public void Click()
    {
        _score += clickCost;
    }
}

