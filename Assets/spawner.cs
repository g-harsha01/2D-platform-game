using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject Prefab;
    public float Spawnrate = 1f;
    public float minrate = -1f;
    public float maxrate = 1f;

    private void OnEnable(){
        InvokeRepeating("spawn",Spawnrate,Spawnrate);
    }
    private void OnDisable() {
        CancelInvoke("spawn");    
    }

    private void spawn(){
        GameObject spike = Instantiate(Prefab, transform.position, Quaternion.identity);
        spike.transform.position += Vector3.right*Random.Range(minrate,maxrate);
    }



}
