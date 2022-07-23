using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    [SerializeField]
    private float maxLevel;   //level �ִ�ġ ����

    private float currentLevel; //level ���� �ִ�ġ

    
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
        if (currentLevel >= maxLevel) return; //�ִ뷹���� ���� ������� 

        playerExp.IsLevelUp = false;

        while (true)
        {
            currentLevel++;                                                  //level ����
            playerExp.CurrentExp = playerExp.CurrentExp - playerExp.MaxExp;  //����ġ ����
            playerExp.MaxExp += 30;                                          //levelup �䱸 ����ġ ����
            
            if(playerExp.CurrentExp < playerExp.MaxExp) break; //������ ������ �� ���ɼ� ���
        }
    }
}
