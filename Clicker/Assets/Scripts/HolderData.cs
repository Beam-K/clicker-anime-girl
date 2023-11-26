using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public static class HolderData
{
    private static int _score = 0;
    private static int _clickCost = 1;
    private static int _upgradeCost = 10;
    private static int _costChange = 50;
    
    
    public static int Score { get => _score; private set => _score = value;}
    public static int ClickCost { get => _clickCost; private set => _clickCost = value;}
    public static int UpgradeCost { get => _upgradeCost; private set => _upgradeCost = value;}
    public static int CostChange { get => _costChange; private set => _costChange = value;}
    
  
    
    
    
    
    
    
    
    
    
}

