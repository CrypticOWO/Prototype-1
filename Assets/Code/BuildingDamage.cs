using UnityEngine;

public class BuildingDamage : MonoBehaviour
{
    public int health = 100;
    private Renderer buildingRenderer;

    void Start()
    {
        buildingRenderer = GetComponent<Renderer>();
    }

    public void ApplyDamage(int damageAmount)
    {
        health -= damageAmount;
        Debug.Log("Building hit! Health: " + health);

        // Change the building's material to black when it takes damage
        if (buildingRenderer != null)
        {
            buildingRenderer.material.color = Color.black;
        }
    }
}
