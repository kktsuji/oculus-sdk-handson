using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snare : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name == "StickL") || (collision.gameObject.name == "StickR"))
        {
            DebugUIBuilder.instance.AddLabel("Hit! " + transform.name + ": " + collision.gameObject.name);
            DebugUIBuilder.instance.Show();
            audioSource.PlayOneShot(audioSource.clip);
        }
    }
}
