using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTest : MonoBehaviour
{
    private GunClass _pistol;

    public GameObject[] bullets;
    public Transform magPos, gunTip;
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _pistol = new GunClass(bullets, magPos, gunTip, bulletSpeed, bullets.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _pistol.Shoot();
        }
    }
}
