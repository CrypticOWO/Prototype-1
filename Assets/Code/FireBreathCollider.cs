using UnityEngine;

public class FireBreathCollidera : MonoBehaviour
{
    public ParticleSystem fireEffect;

    void Start()
    {
        var collisionModule = fireEffect.collision;
        collisionModule.enabled = true;
        collisionModule.type = ParticleSystemCollisionType.World;
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Building"))
        {
            Debug.Log("Fire particle hit building!");

            // Apply damage to the building
            BuildingDamage building = other.GetComponent<BuildingDamage>();
            if (building != null)
            {
                building.ApplyDamage(2f);
            }
        }
    }
}
