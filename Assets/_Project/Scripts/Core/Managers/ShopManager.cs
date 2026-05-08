using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public static ShopManager Instance;

    [SerializeField] private Transform shopPoint;

    public Transform ShopPoint => shopPoint;

    private void Awake()
    {
        Instance = this;
    }
}