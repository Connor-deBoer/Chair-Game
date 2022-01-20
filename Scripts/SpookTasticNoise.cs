using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookTasticNoise : MonoBehaviour
{
    public List<AudioClip> spookeyNosie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpookeyNoisePlayer()
    {
        gameObject.GetComponent<AudioSource>().clip = spookeyNosie[Random.Range(0, 15)];
    }
}
