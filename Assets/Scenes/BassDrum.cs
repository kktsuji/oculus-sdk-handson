using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BassDrum : MonoBehaviour
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
        if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger))
        {
            DebugUIBuilder.instance.AddLabel("Pushed! RHandTrigger");
            DebugUIBuilder.instance.Show();
            audioSource.Play();
        }
    }
}
