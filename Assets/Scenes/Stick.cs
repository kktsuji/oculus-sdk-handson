using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (transform.name == "StickR")
        {
            if (collision.gameObject.name == "Snare")
            {
                counter++;
                DebugUIBuilder.instance.AddLabel("Touched: " + collision.gameObject.name + " " + counter.ToString());
                DebugUIBuilder.instance.Show();
            }
            else if (collision.gameObject.name == "StickL")
            {
                DebugUIBuilder.instance.AddLabel("Touched: " + collision.gameObject.name);
                DebugUIBuilder.instance.Show();
            }
        }
    }

}
