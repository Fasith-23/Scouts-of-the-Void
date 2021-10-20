
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float zset;
    // Update is called once per frame
    void Update()
    {
        zset = player.position.z + offset.z;
        transform.position = new Vector3(transform.position.x, transform.position.y, zset);
    }
}
