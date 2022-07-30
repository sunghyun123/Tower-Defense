using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTowerPanel : MonoBehaviour
{
    public GameObject Reload;
    private void Awake()
    {
        OffTPanel();

    }
    public void OffTPanel()
    {
        gameObject.SetActive(false);
    }
    public void OnTPanel()// �� ������Ʈ PanelReload -> Reload -> Button
    {
        gameObject.SetActive(true);
        Reload.GetComponent<Reload>().ReLoad();
    }    
}

