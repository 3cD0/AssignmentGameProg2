using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontally : MonoBehaviour
{
    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.back * horizontalInput * Time.deltaTime * 50.0f);
    }
}
