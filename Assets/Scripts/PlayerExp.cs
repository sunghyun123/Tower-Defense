using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExp : MonoBehaviour
{

    [SerializeField]
    private float maxExp;   //Exp 최대치 설정
    private float currentExp; //Exp 현재 최대치
    private bool isLevelUp = false; //래밸업이 가능한 상태인지

    private int avc;// jjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjj
    
    private PlayerLevel playerLevel;

    public float MaxExp
    {
        get { return maxExp; }
        set { maxExp = value; }
    }

    public float CurrentExp
    {
        get { return currentExp; } set { currentExp = value; } 
    }

    public bool IsLevelUp
    {
         get { return isLevelUp; } set { isLevelUp = value; }
    }


    private void Awake()
    {
        currentExp = 0;
        playerLevel = GetComponent<PlayerLevel>();
    }

    //exp를 얻을 때 호출 되는 함수
    public void GetExp(float getexp)
    {
        if (getexp <= 0) return;      //음수가 들어오면 리턴

        if (isLevelUp == true) return;

        currentExp = currentExp + getexp;      // 경험치 추가
        

        if(currentExp >= maxExp)       //경험치가 일정 게이지를 넘으면 레밸업
        {
          
            isLevelUp = true;
            
            playerLevel.LevelUp();
        }
    }

   
    
    
}
