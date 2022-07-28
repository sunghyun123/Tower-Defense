using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    [SerializeField]
    private float maxLevel;   //level 최대치 설정

    private float currentLevel; //level 현재 최대치

    
    private PlayerExp playerExp;

    public float MaxLevel
    {
        get { return maxLevel; }
        set { maxLevel = value; }
    }

    public float CurrentLevel
    {
        get { return currentLevel; }
        set { currentLevel = value; }
    }

    private void Awake()
    {
        currentLevel = 1;
        playerExp = GetComponent<PlayerExp>();
    }

    public void LevelUp()
    {
        if (currentLevel >= maxLevel) return; //최대레벨에 도달 했을경우 

        playerExp.IsLevelUp = false;

        while (true)
        {
            currentLevel++;                                                  //level 증가
            playerExp.CurrentExp = playerExp.CurrentExp - playerExp.MaxExp;  //경험치 감소
            playerExp.MaxExp += 30;                                          //levelup 요구 경험치 증가
            
            if(playerExp.CurrentExp < playerExp.MaxExp) break; //여러번 레벨업 될 가능성 고려
        }
    }
}
