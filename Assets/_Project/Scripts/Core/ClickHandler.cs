using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    [Header("Beggar Reward")]
    [SerializeField] private int reward = 10;

    private NPCController npcController;

    private void Awake()
    {
        npcController = GetComponent<NPCController>();
    }

    private void OnMouseDown()
    {
        if (npcController == null)
            return;

        if (npcController.Type != NPCType.Beggar)
            return;

        GameManager.Instance.AddMoney(reward);

        Destroy(gameObject);
    }
}