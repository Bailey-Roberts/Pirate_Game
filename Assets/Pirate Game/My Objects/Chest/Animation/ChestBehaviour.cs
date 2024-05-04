using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChestBehaviour : MonoBehaviour
{
    public Animator animator;
    public AudioClip chestOpening;
    private bool opened = false;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            // play animation
            animator.SetTrigger("Open");
            if (!opened)
            {
                gameObject.GetComponent<AudioSource>().PlayOneShot(chestOpening);
                opened = true;
            }
        }
    }
}
