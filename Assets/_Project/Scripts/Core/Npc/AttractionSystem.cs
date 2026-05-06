using UnityEngine;

public class AttractionSystem : MonoBehaviour
{
    public static AttractionSystem Instance;

    public float baseChance = 0.3f;
    private float bonus = 0f;

    private void Awake()
    {
        Instance = this;
    }

    public float GetAttractionChance()
    {
        return baseChance + bonus;
    }

    public void AddBonus(float value)
    {
        bonus += value;
    }
}
