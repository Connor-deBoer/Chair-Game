using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySparkNoise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpaceStationManager.SparkNoise(gameObject.GetComponent<AudioSource>(), gameObject.GetComponent<ParticleSystem>());
    }
}
