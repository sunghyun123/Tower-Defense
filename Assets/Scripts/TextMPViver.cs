using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextMPViver : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textPlayerHP;
    [SerializeField]
    private TextMeshProUGUI textPlayerGold;
    [SerializeField]
    private TextMeshProUGUI textWave;
    [SerializeField]
    private TextMeshProUGUI textEnemyCount;
    [SerializeField]
    private TextMeshProUGUI textPlayerExp;
    [SerializeField]
    private TextMeshProUGUI textPlayerLevel;
    [SerializeField]
    private PlayerHP playerHP;
    [SerializeField]
    private PlayerGold playerGold;
    [SerializeField]
    private WaveSystem waveSystem;
    [SerializeField]
    private EnemySpawner enemySpawner;
    [SerializeField]
    private PlayerExp playerExp;
    [SerializeField]
    private PlayerLevel playerLevel;

    // Update is called once per frame
    private void Update()
    {
        textPlayerHP.text = playerHP.CurrentHP + "/" + playerHP.MaxHP;
        textPlayerGold.text = playerGold.CurrentGold.ToString();

        textWave.text = waveSystem.CurrentWave + "/" + waveSystem.MaxWave;
        textEnemyCount.text = enemySpawner.CurremtEnemyCount + "/" + enemySpawner.MaxEnemyCount;


        if (playerLevel.CurrentLevel < playerLevel.MaxLevel)
        {
            textPlayerLevel.text = "LV : " + playerLevel.CurrentLevel;
            textPlayerExp.text = "Exp : " + playerExp.CurrentExp + " / " + playerExp.MaxExp;
        }
        else
        {
            textPlayerLevel.text = "LV : MAX";
            textPlayerExp.text = "Exp : 0 / 0";
        }
       
    }
}
