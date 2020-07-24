using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public GameObject BassDrum;
    private int counter = 0;
    private AudioSource audioSource;
    // private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        BassDrum = BassDrum.GetComponent<GameObject>();
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
            }
            else if (collision.gameObject.name == "Snare")
            {
                // counter++;
                // DebugUIBuilder.instance.AddLabel("Hit!: " + collision.gameObject.name + " " + counter.ToString());
                // DebugUIBuilder.instance.Show();
            }
        }
        
        var activeController = OVRInput.GetActiveController();
        OVRInput.SetControllerVibration (1, 1, OVRInput.Controller.LTouch);
        // OVRInput.SetControllerVibration (1, 1, activeController);


        // OVRInput.SetControllerVibration (1, 1, OVRInput.Controller.RTouch);
        // yield return new WaitForSeconds(0.2f);
        // OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
        // Vivration();
    }

    IEnumerator Vivration()
    {
        var activeController = OVRInput.GetActiveController();
        OVRInput.SetControllerVibration (1, 1, activeController);
        // OVRInput.SetControllerVibration (1, 1, OVRInput.Controller.RTouch);
        
        yield return new WaitForSeconds(0.2f);
        OVRInput.SetControllerVibration(0, 0, activeController);
        // OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
    }

}
