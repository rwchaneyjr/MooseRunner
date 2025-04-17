using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Animation : MonoBehaviour
{
    public GameObject player;
    public GameObject BigBird;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
      //  animator = GetComponent<Animator>();

    }
 

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("flying", true);
        BigBird.transform.Translate(Vector3.forward * .02f);
       // BigBird.transform.localScale = new Vector3(50 + Asteroid.i*3 , 50 + Asteroid.i*3 , 50 + Asteroid.i*3 );
      //  transform.position = new Vector3(transform.position.x, (-14.5f) + Asteroid.i / 5f, transform.position.z);

    }
}
