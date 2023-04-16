using UnityEngine;

public class spikemovement : MonoBehaviour
{
    public float speed = 1f;

    private float LeftEdge ;

    void Start() {
        LeftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x -1f ;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime ;

        if (transform.position.x < LeftEdge){
            Destroy(gameObject);
        }
    }


}
