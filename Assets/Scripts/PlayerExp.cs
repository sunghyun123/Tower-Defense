using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExp : MonoBehaviour
{

    [SerializeField]
    private float maxExp;   //Exp �ִ�ġ ����
    private float currentExp; //Exp ���� �ִ�ġ
    private bool isLevelUp = false; //������� ������ ��������

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

    //exp�� ���� �� ȣ�� �Ǵ� �Լ�
    public void GetExp(float getexp)
    {
        if (getexp <= 0) return;      //������ ������ ����

        if (isLevelUp == true) return;

        currentExp = currentExp + getexp;      // ����ġ �߰�
        

        if(currentExp >= maxExp)       //����ġ�� ���� �������� ������ �����
        {
          
            isLevelUp = true;
            
            playerLevel.LevelUp();
        }
    }

   
    
    
}
