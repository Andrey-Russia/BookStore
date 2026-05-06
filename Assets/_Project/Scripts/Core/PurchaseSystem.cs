using UnityEngine;

public class PurchaseSystem : MonoBehaviour
{
    public static PurchaseSystem Instance;

    public int bookPrice = 5;

    private void Awake()
    {
        Instance = this;
    }

    public void TryBuy(NpcController npc)
    {
        if (npc.isBeggar)
            return;

        if (InventorySystem.Instance.HasBooks())
        {
            InventorySystem.Instance.RemoveBook();
            GameManager.Instance.AddMoney(bookPrice);
        }
    }
}