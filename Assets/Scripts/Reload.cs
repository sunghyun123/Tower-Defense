using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    public GameObject[] TowerArray;
    [SerializeField]
    private PlayerGold playerGold;
    [SerializeField]
    private SystemTextViewer systemTextViewer;
    int count;
    public int RerollCost;
    public void ReLoad()
    {

        if (RerollCost > playerGold.CurrentGold) // 리롤 비용이 플레이어 현재 소지금 보다 많을 시
        {
            systemTextViewer.PrintText(SystemType.Money);
            return;
        }

        int n = -1;
        for (int i = 0; i < TowerArray.Length; i++)
        {
            if (TowerArray[i].gameObject.activeSelf == true)
            {
                TowerArray[i].gameObject.SetActive(false);
            }
        }
        while (count < 2)
        {
            for (int i = 0; i < 2; i++)
            {
                if (count > 1) break;
                int num = Random.Range(0, 4);
                if (num != n)
                {
                    TowerArray[num].gameObject.SetActive(true);
                    count++;
                }

                n = num;
            }
        }
        count = 0;
        playerGold.CurrentGold -= RerollCost;
    }


}
