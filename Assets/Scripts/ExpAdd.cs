using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpAdd : MonoBehaviour
{
    [SerializeField]
    private PlayerExp playerExp;
    [SerializeField]
    private PlayerGold playerGold;
    [SerializeField]
    private PlayerLevel playerLevel;
    
    [SerializeField]
    private float exp = 30;
    [SerializeField]
    private int gold = 30;
    [SerializeField]
    private SystemTextViewer  systemTextViewer;


    


    public void clickExpButton()
    {
        if (playerLevel.CurrentLevel >= playerLevel.MaxLevel)
        {
            systemTextViewer.PrintText(SystemType.MaxLevel);
            return;        //�÷��̾ ������ �Ǹ� ���� ���ϰ� ��
        }
        if (playerGold.CurrentGold < gold)
        {
            systemTextViewer.PrintText(SystemType.Money);                    //�� ���ٰ� ���
            return;                                                          //�������� ���� ����
        }
        playerExp.GetExp(exp);
        playerGold.CurrentGold -= gold;

    }
}
