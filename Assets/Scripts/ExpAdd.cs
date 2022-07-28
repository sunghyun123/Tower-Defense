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
            return;        //플레이어가 만랩이 되면 접근 못하게 함
        }
        if (playerGold.CurrentGold < gold)
        {
            systemTextViewer.PrintText(SystemType.Money);                    //돈 없다고 출력
            return;                                                          //돈없으면 접근 못함
        }
        playerExp.GetExp(exp);
        playerGold.CurrentGold -= gold;

    }
}
