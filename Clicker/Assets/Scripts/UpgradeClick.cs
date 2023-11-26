using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeClick : MonoBehaviour
{
    [SerializeField] private static int _upgradeCost = 10;
    [SerializeField] private GameManager _gameManager;
    private int _score;
    private int _clickCost;
    
    [SerializeField] private TMP_Text upgradeScoreText;

    public event Action OnUpgrade;
     
    [SerializeField] private Button UpgradeClickCost;

    private void Start()
    {
        Button btn = UpgradeClickCost.GetComponent<Button>();
        btn.onClick.AddListener(UpgrateClick);
        
       
  
    }
    public void ShowUpgradeScoreCost()
    {
        upgradeScoreText.text = _upgradeCost.ToString();
    }

    public void UpgrateClick()
    {
        _score = _gameManager.GiveScore();
        _clickCost = _gameManager.GiveClickCost();
        
        if (_score >= _upgradeCost)
        {
            _score -= _upgradeCost;
            _upgradeCost += 20;
            _clickCost++;
            ShowUpgradeScoreCost();
            OnUpgrade?.Invoke();
            _gameManager.ShowScoreTMP();
        }
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