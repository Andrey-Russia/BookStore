using UnityEngine;

public class NpcController : MonoBehaviour
{
    public float speed = 2f;
    public bool isBeggar = false;

    private bool isGoingToShop = false;

    private void Start()
    {
        isGoingToShop = Random.value < AttractionSystem.Instance.GetAttractionChance();
    }

    private void Update()
    {
        Move();

        if (isGoingToShop && Vector2.Distance(transform.position, Vector2.zero) < 0.5f)
        {
            PurchaseSystem.Instance.TryBuy(this);
            Destroy(gameObject);
        }

        if (transform.position.x > 10f)
        {
            Destroy(gameObject);
        }
    }

    void Move()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
