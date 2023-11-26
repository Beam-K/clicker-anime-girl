using UnityEngine;
using TMPro;
using UnityEngine.Serialization;


public class GameManager : MonoBehaviour
{
    [SerializeField] private int _score ; 
    [SerializeField] private int _clickCost = 1;
    [SerializeField] private GameManager _gameManager;

    [SerializeField] private TMP_Text scoreTMPro;
 
 public void Click()
    {
        _score += _clickCost;
        scoreTMPro.text = _score.ToString();
        
    }

 public int GiveScore()
 {
     return _score;
 }

 public int ReturnScore()
 {
     _gameManager.ReturnScore();
     _score = _gameManager.ReturnScore();
     return _score;
 }
 
 public int ReturnClickCost()
 {
     _gameManager.ReturnScore();
     _clickCost = _gameManager.ReturnScore();
     return _clickCost;

 }
 public int GiveClickCost()
 {
     return _clickCost;
 }
}

