using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiHat : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isOpen = false;
    public AudioClip ohh;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        isOpen = OVRInput.Get(OVRInput.RawButton.LHandTrigger);
    }

    void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.name == "StickL") || (collision.gameObject.name == "StickR"))
        {
            if (OVRInput.Get(OVRInput.RawButton.LHandTrigger))
            {
                DebugUIBuilder.instance.AddLabel("Pushed! LHandTrigger");
                DebugUIBuilder.instance.Show();
                audioSource.Stop();
                audioSource.PlayOneShot(ohh);
            }
            else
            {
                DebugUIBuilder.instance.AddLabel("Hit! " + transform.name + ": " + collision.gameObject.name);
                DebugUIBuilder.instance.AddLabel("test");
                DebugUIBuilder.instance.Show();
                audioSource.Stop();
                audioSource.PlayOneShot(audioSource.clip);
            }
        }
    }
}
