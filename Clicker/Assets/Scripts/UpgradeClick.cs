using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class UpgradeClick : MonoBehaviour
{
    [SerializeField] private int _upgradeCost = 10;
    [SerializeField] private GameManager _gameManager;
    private int _score;
    private int _clickCost;
    
    [SerializeField] private TMP_Text upgradeScoreText;

    
    public void ShowUpgradeScoreCost()
    {
        upgradeScoreText.text = _upgradeCost.ToString();
    }
    
    

    public void UpgrateClick()
    {
        _gameManager.GiveScore();
        _score = _gameManager.GiveScore();

        _gameManager.GiveScore();
        _clickCost = _gameManager.GiveScore();
        if (_score >= _upgradeCost)
        {
            _score -= _upgradeCost;
            _upgradeCost += 20;
            _clickCost++;
        }
    }

    public int ReturnScore()
    {
        return _score;
    }
    public int ReturnClickCost()
    {
        return _clickCost;
    }
} 