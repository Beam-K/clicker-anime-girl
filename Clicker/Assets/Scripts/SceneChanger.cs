using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;
    
    private static int _score;
    private static int _costChange = 50;
    
    [SerializeField] private Button LevelUp;

    private void Start()
    {
        Button btn = LevelUp.GetComponent<Button>();
        btn.onClick.AddListener(ChangeScene);
        
        _costChange = HolderData.CostChange;
    }
    
    private void ChangeScene()
    {
        _score = _gameManager.GiveScore();

        if (_score >= _costChange)
        {
            var index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index + 1);
        }
        else
        {
            Debug.Log("нет деняг");
        }
    }
}

