using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(3, 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0);
        transform.position = new Vector3(2, 2, 2);
        transform.localScale = new Vector3(2, 2, 2);

    }
}
