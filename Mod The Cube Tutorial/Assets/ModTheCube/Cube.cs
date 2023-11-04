using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;


    void Start()
    {
        //transform.position = new Vector3(3, 4, 1);

        //transform.localScale = Vector3.one * Random.Range(0.5f, 3.0f);
        
        //Material material = Renderer.material;
        
        //material.color = new Color(8.5f, 6.0f, 0.9f, 0.05f);

        //material.color.
    }
    
    void Update()
    {
        Material material = Renderer.material;

        material.color = new Color(
            (Mathf.PingPong(Time.time * 0.6f, 15.0f - 6.0f) + 6.0f),
            (Mathf.PingPong(Time.time * 0.2f, 1.0f - 0.5f) + 0.5f),
            (Mathf.PingPong(Time.time * 0.6f, 8.0f - 0.1f) + 0.1f),
            (Mathf.PingPong(Time.time * 0.2f, 2.0f - 0.1f) + 0.1f));

        transform.position = new Vector3(
            Mathf.PingPong(Time.time * 0.2f, 7.0f - 1.0f) + 1.0f,
            4,
            Mathf.PingPong(Time.time * 0.2f, 7.0f - 1.0f) * 1.0f);

        transform.localScale = Vector3.one * (Mathf.PingPong(Time.time * 0.3f, 3.0f - 0.5f) + 0.5f);

        transform.Rotate(10.0f * Time.deltaTime, -20.0f * Time.deltaTime, 5.0f * Time.deltaTime);
    }
}
