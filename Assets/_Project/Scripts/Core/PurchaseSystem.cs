using UnityEngine;

public class PurchaseSystem : MonoBehaviour
{
    public static PurchaseSystem Instance;

    [SerializeField] private int regularBookPrice = 5;
    [SerializeField] private int hikikomoriBookPrice = 10;

    private void Awake()
    {
        Instance = this;
    }

    public void TryBuy(NPCController npc)
    {
        if (npc.Type == NPCType.Beggar)
            return;

        int price = GetBookPrice(npc.Type);

        GameManager.Instance.AddMoney(price);
    }

    private int GetBookPrice(NPCType type)
    {
        switch (type)
        {
            case NPCType.Hikikomori:
                return hikikomoriBookPrice;

            default:
                return regularBookPrice;
        }
    }
}