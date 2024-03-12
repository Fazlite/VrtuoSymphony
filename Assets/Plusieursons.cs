 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plusieursons : MonoBehaviour
{
    public AudioSource Guitare;
    public AudioSource Piano;

    // Start is called before the first frame update
    void Start()
    {
        Guitare = gameObject.AddComponent<AudioSource>();
        Piano = gameObject.AddComponent<AudioSource>();

        Piano.playOnAwake = false;
        Guitare.playOnAwake = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
