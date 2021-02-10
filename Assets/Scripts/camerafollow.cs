using UnityEngine;

public class camerafollow : MonoBehaviour
{    // Update is called once per frame
    public Transform player;
    public Vector3 offstet;
    void Update()
    {
        transform.position = player.position + offstet;

    }
}
