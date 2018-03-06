using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int speed = 5;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
    }
}