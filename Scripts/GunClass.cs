using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunClass
{
    private GameObject[] _bullets;
    private Transform _magazinePos;
    private Transform _gunTip;
    private float _speed;
    private int _magazine;

    private int _bullet = 0;
    public GunClass(GameObject[] bullets, Transform magazinePos, Transform gunTip, float speed, int magazine)
    {
        _bullets = bullets;
        _magazinePos = magazinePos;
        _gunTip = gunTip;
        _speed = speed;
        _magazine = magazine;
    }

    public void Shoot()
    {
        Fire(_bullet);
        if (_bullet <= _magazine)
        {
            _bullet++;
        }
        else
        {
            _bullet = 0;
        }
    }

    void Fire(int bullet)
    {
        _bullets[bullet].transform.position = _magazinePos.position;
        _bullets[bullet].SetActive(true);
        Vector3 dir = _gunTip.position - _magazinePos.position;
        _bullets[bullet].GetComponent<Rigidbody>().AddForce(dir * _speed, ForceMode.Impulse);
    }
}
