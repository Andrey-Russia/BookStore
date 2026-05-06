using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    public int reward = 10;

    private void OnMouseDown()
    {
        NpcController npc = GetComponent<NpcController>();

        if (npc != null && npc.isBeggar)
        {
            GameManager.Instance.AddMoney(reward);
            Destroy(gameObject);
        }
    }
}