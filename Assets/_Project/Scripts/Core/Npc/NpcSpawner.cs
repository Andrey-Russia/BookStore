using UnityEngine;

public class NpcSpawner : MonoBehaviour
{
    public GameObject[] NpcPerfabs;
    public Transform SpawnPoint;
    public float SpawnDelay = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnNPC), 1f, SpawnDelay);
    }

    void SpawnNPC()
    {
        int rand = Random.Range(0, NpcPerfabs.Length);
        Instantiate(NpcPerfabs[rand], SpawnPoint.position, Quaternion.identity);
    }
}
