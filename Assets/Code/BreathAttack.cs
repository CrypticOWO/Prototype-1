using UnityEngine;

public class BreathAttack : MonoBehaviour
{
    public GameObject Player;
    public ParticleSystem FireBreathPreFab;

    void Update()
    {
        //follow player movement
        transform.position = Player.transform.position + new Vector3(0,-1,3);

        //rotate to mouse movement
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,angle);

        if (Input.GetKey(KeyCode.P))
        {
            FireBreathPreFab.Play();
            Debug.Log("Fire");
        }
        else if (!Input.GetKey(KeyCode.P))
        {
            //FireBreathPreFab.Stop();
            Debug.Log("Off");
        }
    }
}
