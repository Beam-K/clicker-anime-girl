using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradeClick : MonoBehaviour
{
    [SerializeField] private int _upgradeClick = 10;
    
    [SerializeField] private TMP_Text upgradeScoreText;

    
    public void Update()
    {
        upgradeScoreText.text = _upgradeClick.ToString();
    }
    
}
