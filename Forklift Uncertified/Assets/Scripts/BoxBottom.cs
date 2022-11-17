using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBottom : MonoBehaviour
{

    public Rigidbody2D fork;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), fork.GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
