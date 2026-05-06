using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public static InventorySystem Instance;

    public int books = 50;

    private void Awake()
    {
        Instance = this;
    }

    public bool HasBooks()
    {
        return books > 0;
    }

    public void RemoveBook()
    {
        books--;
    }
}