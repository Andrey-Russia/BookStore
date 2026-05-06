using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public int upgradeCost = 100;
    public float attractionBonus = 0.1f;

    public void BuyUpgrade()
    {
        if (GameManager.Instance.Money >= upgradeCost)
        {
            GameManager.Instance.Money -= upgradeCost;
            UIManager.Instance.UpdateMoney(GameManager.Instance.Money);

            AttractionSystem.Instance.AddBonus(attractionBonus);
        }
    }
}