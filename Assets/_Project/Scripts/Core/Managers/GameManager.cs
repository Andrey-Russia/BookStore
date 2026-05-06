using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int Money = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void AddMoney(int amount)
    {
        Money += amount;
        UIManager.Instance.UpdateMoney(Money);
    }
}
