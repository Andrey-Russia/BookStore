using UnityEngine;

public class NPCController : MonoBehaviour
{
    [Header("NPC Settings")]
    [SerializeField] private NPCType type;

    [SerializeField] private float moveSpeed = 2f;

    [Header("Shop Settings")]
    [SerializeField] private float attractionChance = 0.5f;

    [SerializeField] private float stopDistance = 0.2f;

    private Transform shopTarget;

    private bool goingToShop;
    private bool returningToRoute;

    public NPCType Type => type;

    private void Start()
    {
        DecideDestination();

        Destroy(gameObject, 10f);
    }

    private void Update()
    {
        Move();
    }

    private void DecideDestination()
    {
        float randomValue = Random.value;

        if (randomValue <= attractionChance)
        {
            goingToShop = true;

            if (ShopManager.Instance != null)
            {
                shopTarget = ShopManager.Instance.ShopPoint;
            }
        }
    }

    private void Move()
    {
        if (goingToShop && shopTarget != null)
        {
            MoveToShop();
        }
        else if (returningToRoute)
        {
            ReturnToRoute();
        }
        else
        {
            MoveForward();
        }
    }

    private void MoveToShop()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            shopTarget.position,
            moveSpeed * Time.deltaTime
        );

        float distance = Vector2.Distance(transform.position, shopTarget.position);

        if (distance <= stopDistance)
        {
            PurchaseSystem.Instance.TryBuy(this);

            goingToShop = false;
            returningToRoute = true;
        }
    }

    private void ReturnToRoute()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

        if (transform.position.y <= 0.1f)
        {
            returningToRoute = false;
        }
    }

    private void MoveForward()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
}