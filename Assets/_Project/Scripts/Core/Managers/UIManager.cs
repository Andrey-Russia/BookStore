using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public TextMeshProUGUI MoneyText;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateMoney(int value)
    {
        MoneyText.text = value.ToString();
    }
}
