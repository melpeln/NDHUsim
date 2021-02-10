using UnityEngine;
using UnityEngine.SceneManagement;

public class playercollision : MonoBehaviour
{
    public playermove movement;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag=="Obstacle")
        {
            movement.enabled = false;
            SceneManager.LoadScene("Test1");
        }
    }
}
