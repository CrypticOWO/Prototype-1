using UnityEngine;

public class BuildingDamage : MonoBehaviour
{
    public float health = 100;
    private Renderer buildingRenderer;

    void Start()
    {
        buildingRenderer = GetComponent<Renderer>();
    }

    public void ApplyDamage(float damageAmount)
    {
        health -= damageAmount;
        Debug.Log("Building hit! Health: " + health);

        // Change the building's material to black when it takes damage
        if (health <= 0)
        {
            if (buildingRenderer != null)
            {
                buildingRenderer.material.color = Color.black;
            }
        }
    }
}
