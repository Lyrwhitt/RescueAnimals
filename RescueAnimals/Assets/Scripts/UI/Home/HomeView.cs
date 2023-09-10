using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeView : MonoBehaviour
{
    public event Action OnGameStartClicked;
    public event Action OnUpgradePanelControl;
    public event Action OnRankPanelControl;

    public GameObject upgradePanel;
    public GameObject rankPanel;

    public void CallGameStartClicked()
    {
        OnGameStartClicked?.Invoke();
    }

    public void UpgradePanelOpen()  // ���� ������ UI �۾��� view���� �����Ѵٰ� �ϱ淡 �ϴ� ���⿡ �־�׽��ϴ�.
    {
        if(rankPanel.activeInHierarchy) rankPanel.SetActive(false);
        upgradePanel.SetActive(true);
    }

    public void UpgradePanelClose()
    {
        upgradePanel.SetActive(false);
    }

    public void RankPanelOpen()
    {
        if (upgradePanel.activeInHierarchy) upgradePanel.SetActive(false);
        rankPanel.SetActive(true);
    }

    public void RankPanelClose()
    {
        rankPanel.SetActive(false);
    }
}
