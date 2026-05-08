using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public static InventorySystem Instance;

    [SerializeField] private int mangaCount = 20;
    [SerializeField] private int newspaperCount = 50;

    private void Awake()
    {
        Instance = this;
    }

    public bool HasBook(BookType type)
    {
        switch (type)
        {
            case BookType.Manga:
                return mangaCount > 0;

            case BookType.Newspaper:
                return newspaperCount > 0;

            default:
                return false;
        }
    }

    public void RemoveBook(BookType type)
    {
        switch (type)
        {
            case BookType.Manga:
                mangaCount--;
                break;

            case BookType.Newspaper:
                newspaperCount--;
                break;
        }
    }
}