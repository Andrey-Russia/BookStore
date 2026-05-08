using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    [SerializeField] private int upgradeCost = 100;
    [SerializeField] private float attractionBonus = 0.1f;

    [SerializeField] private Button upgradeButton;

    public int UpgradeCost => upgradeCost;
    public float AttractionBonus => attractionBonus;

    public void BuyUpgrade()
    {
        if (GameManager.Instance.Money < upgradeCost)
            return;

        GameManager.Instance.RemoveMoney(upgradeCost);

        AttractionSystem.Instance.AddBonus(attractionBonus);

        upgradeButton.interactable = false;
    }
}