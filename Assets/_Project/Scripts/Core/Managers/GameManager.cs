using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private int money;

    public int Money => money;

    private void Awake()
    {
        Instance = this;
    }

    public void AddMoney(int amount)
    {
        money += amount;
        UIManager.Instance.UpdateMoney(money);
    }

    public void RemoveMoney(int amount)
    {
        money -= amount;
        UIManager.Instance.UpdateMoney(money);
    }
}