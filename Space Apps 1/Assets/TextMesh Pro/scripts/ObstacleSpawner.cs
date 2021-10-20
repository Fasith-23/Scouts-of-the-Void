using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    public float spawntimer = 1;
    private float timer = 0;
    void Update()
    {
        if (timer > spawntimer)
        {
            int rand = Random.Range(0, obstaclePrefab.Length);
            GameObject obs = Instantiate(obstaclePrefab[rand]);
            obs.transform.position = transform.position + new Vector3(0, 0, 0);
            float u= Random.Range(-10,10);
            float v= Random.Range(-10,10);
            obs.GetComponent<Rigidbody>().velocity = new Vector3(u, v, 0);
            Destroy(obs, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
