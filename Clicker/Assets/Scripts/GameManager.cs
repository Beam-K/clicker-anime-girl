
using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField] private static int _score ; 
    [SerializeField] private static int _clickCost = 1;
    [SerializeField] private UpgradeClick _upgradeClick;

    [SerializeField] private TMP_Text scoreTMPro;

    [SerializeField] private Button Character;

    private void Start()
    {
        Button btn = Character.GetComponent<Button>();
        btn.onClick.AddListener(Click);
        
        ShowScoreTMP();
    }
    private void OnEnable()
    {
        _upgradeClick.OnUpgrade += UpdateValue;
    }

    private void OnDisable()
    {
        _upgradeClick.OnUpgrade -= UpdateValue;
    }

    public void Click()
    {
        _score += _clickCost;
        ShowScoreTMP();
    }

    public void ShowScoreTMP()
    {
        scoreTMPro.text = _score.ToString();
    } 
 public void UpdateValue()
 {
     _score = _upgradeClick.GiveScore();
     _clickCost = _upgradeClick.GiveClickCost();
 }
 
 public int GiveScore()
 {
     return _score;
 }
 
 public int GiveClickCost()
 {
     return _clickCost;
 }
}

