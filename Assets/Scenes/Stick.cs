using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    private int counter = 0;
    private AudioSource audioSource;
    // private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (transform.name == "StickR")
        {
            if (collision.gameObject.name == "StickL")
            {
                DebugUIBuilder.instance.AddLabel("Hit! " + transform.name + ": " + collision.gameObject.name);
                DebugUIBuilder.instance.Show();
                // audioSource.clip = stick4;
                // audioSource.Play ();
                audioSource.PlayOneShot(audioSource.clip);
            }
            else if (collision.gameObject.name == "Snare")
            {
                // counter++;
                // DebugUIBuilder.instance.AddLabel("Hit!: " + collision.gameObject.name + " " + counter.ToString());
                // DebugUIBuilder.instance.Show();
            }
        }
    }

}
