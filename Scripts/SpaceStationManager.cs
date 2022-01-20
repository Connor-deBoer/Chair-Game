using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SpaceStationManager
{
    /// <summary>
    /// a Method to spin stuff
    /// </summary>
    /// <param name="speed">how fast it goes</param>
    /// <param name="transform">The transform you wanna spin</param>
    /// <param name="direction">the direction you want to spin</param>
    public static void Spin(float speed, Transform transform, Vector3 direction)
    {
        transform.Rotate(direction * speed * Time.deltaTime);
    }

    /// <summary>
    /// a method to open a door
    /// </summary>
    /// <param name="door">the door game object</param>
    /// <param name="BDC">Bottom Dead Center or how far down you want the door to go</param>
    public static void DoorOpen(this Transform door, Vector3 BDC)
    {
        door.localPosition = BDC;
    }

    /// <summary>
    /// a method to close a door
    /// </summary>
    /// <param name="door">the door game object</param>
    /// <param name="TDC">Top Dead Center or where it should return to</param>
    public static void DoorClose(this Transform door, Vector3 TDC)
    {
        door.localPosition = TDC;
    }

    /// <summary>
    /// Plays noise when particle emits
    /// </summary>
    /// <param name="audioSource">the audio source with the sound</param>
    /// <param name="particleSystem">the particle system that emits particles</param>
    public static void SparkNoise(AudioSource audioSource, ParticleSystem particleSystem)
    {
        int currentParticleCount = 0;
        var amount = Mathf.Abs(currentParticleCount - particleSystem.particleCount);

        if(particleSystem.particleCount > currentParticleCount)
        {
            audioSource.Play();
            //Debug.Log("play");
        }
    }
}
