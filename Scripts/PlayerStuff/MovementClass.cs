using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementClass
{
    //varibles that get values when the object is instainteated 
    float topSpeed;
    float hSpeed;
    float vSpeed;
    float fSpeed;
    KeyCode hPlusKey;
    KeyCode hMinusKey;
    KeyCode vPlusKey;
    KeyCode vMinusKey;
    KeyCode fPlusKey;
    KeyCode fMinusKey;
    public Rigidbody rb;
    ForceMode hForceMode;
    ForceMode vForceMode;
    ForceMode fForceMode;
    
    public MovementClass(float topSpeed, Rigidbody rb, ForceMode hForceMode)
    {
        this.topSpeed = topSpeed;
        this.rb = rb;
        this.hForceMode = hForceMode;
    }

    public MovementClass(float hSpeed, float vSpeed, float topSpeed, KeyCode hPlusKey, KeyCode hMinusKey, KeyCode vPlusKey, KeyCode vMinusKey, Rigidbody rb, ForceMode hForceMode, ForceMode vForceMode)
    {
        this.hSpeed = hSpeed;
        this.vSpeed = vSpeed;
        this.topSpeed = topSpeed;
        this.hPlusKey = hPlusKey;
        this.vPlusKey = vPlusKey;
        this.hMinusKey = hMinusKey;
        this.vMinusKey = vMinusKey;
        this.rb = rb;
        this.hForceMode = hForceMode;
        this.vForceMode = vForceMode;
    }

    public MovementClass(float hSpeed, float vSpeed, float fSpeed, float topSpeed, KeyCode hPlusKey, KeyCode hMinusKey, KeyCode vPlusKey, KeyCode vMinusKey, KeyCode fPlusKey, KeyCode fMinusKey, Rigidbody rb, ForceMode hForceMode, ForceMode vForceMode, ForceMode fForceMode)
    {
        this.hSpeed = hSpeed;
        this.vSpeed = vSpeed;
        this.fSpeed = fSpeed;
        this.topSpeed = topSpeed;
        this.hPlusKey = hPlusKey;
        this.vPlusKey = vPlusKey;
        this.fPlusKey = fPlusKey;
        this.hMinusKey = hMinusKey;
        this.vMinusKey = vMinusKey;
        this.fMinusKey = fMinusKey;
        this.rb = rb;
        this.hForceMode = hForceMode;
        this.vForceMode = vForceMode;
        this.fForceMode = fForceMode;
    }
    
    public void MoveInDirection(int caseInt, Vector3 hDir)
    {
        switch (caseInt)
        {
            case 1:
                if (Input.GetKeyDown(hPlusKey))
                {
                    rb.AddForce(hDir * hSpeed, hForceMode);
                }
                if (Input.GetKeyDown(hMinusKey))
                {
                    rb.AddForce(hDir * -hSpeed, hForceMode);
                }

                break;
            case 2:
                if (Input.GetKey(hPlusKey) && Mathf.Abs(rb.velocity.x) < topSpeed)
                {
                    rb.AddForce(hDir * hSpeed, hForceMode);
                }
                if (Input.GetKey(hMinusKey) && Mathf.Abs(rb.velocity.x) < topSpeed)
                {
                    rb.AddForce(hDir * -hSpeed, hForceMode);
                }

                break;
            case 3:
                rb.AddForce(hDir * hSpeed, hForceMode);

                break;
        }
    }

    public void MoveInDirection(int caseInt, Vector3 hDir, Vector3 vDir)
    {
        switch (caseInt)
        {
            case 1:
                if (Input.GetKeyDown(hPlusKey))
                {
                    rb.AddForce(hDir * hSpeed, hForceMode);
                }
                if (Input.GetKeyDown(hMinusKey))
                {
                    rb.AddForce(hDir * -hSpeed, hForceMode);
                }
                if (Input.GetKeyDown(vPlusKey))
                {
                    rb.AddForce(vDir * vSpeed, vForceMode);
                }
                if (Input.GetKeyDown(vMinusKey))
                {
                    rb.AddForce(vDir * -vSpeed, vForceMode);
                }
                
                break;
            case 2:
                if (Input.GetKey(hPlusKey) && Mathf.Abs(rb.velocity.x) < topSpeed)
                {
                    rb.AddForce(hDir * hSpeed, hForceMode);
                }
                if (Input.GetKey(hMinusKey) && Mathf.Abs(rb.velocity.x) < topSpeed)
                {
                    rb.AddForce(hDir * -hSpeed, hForceMode);
                }
                if (Input.GetKey(vPlusKey) && Mathf.Abs(rb.velocity.y) < topSpeed)
                {
                    rb.AddForce(vDir * vSpeed, vForceMode);
                }
                if (Input.GetKey(vMinusKey) && Mathf.Abs(rb.velocity.y) < topSpeed)
                {
                    rb.AddForce(vDir * -vSpeed, vForceMode);
                }

                break;
            case 3:
                if (Input.GetKeyDown(hPlusKey))
                {
                    rb.AddForce(hDir * hSpeed, hForceMode);
                }
                if (Input.GetKeyDown(hMinusKey))
                {
                    rb.AddForce(hDir * -hSpeed, hForceMode);
                }
                if (Input.GetKey(vPlusKey) && Mathf.Abs(rb.velocity.y) < topSpeed)
                {
                    rb.AddForce(vDir * vSpeed, vForceMode);
                }
                if (Input.GetKey(vMinusKey) && Mathf.Abs(rb.velocity.y) < topSpeed)
                {
                    rb.AddForce(vDir * -vSpeed, vForceMode);
                }
                
                break;
            case 4:
                if (Input.GetKey(hPlusKey) && Mathf.Abs(rb.velocity.x) < topSpeed)
                {
                    rb.AddForce(hDir * hSpeed, hForceMode);
                }
                if (Input.GetKey(hMinusKey) && Mathf.Abs(rb.velocity.x) < topSpeed)
                {
                    rb.AddForce(hDir * -hSpeed, hForceMode);
                }
                if (Input.GetKeyDown(vPlusKey))
                {
                    rb.AddForce(vDir * vSpeed, vForceMode);
                }
                if (Input.GetKeyDown(vMinusKey))
                {
                    rb.AddForce(vDir * -vSpeed, vForceMode);
                }
                
                break;
        }
    }

    public void MoveInDirection(int caseInt, Vector3 hDir, Vector3 vDir, Vector3 fDir)
    {
        switch (caseInt)
        {
            case 1:
                if (Input.GetKeyDown(hPlusKey))
                {
                    rb.AddForce(hDir * hSpeed, hForceMode);
                }
                if (Input.GetKeyDown(hMinusKey))
                {
                    rb.AddForce(hDir * -hSpeed, hForceMode);
                }
                if (Input.GetKeyDown(vPlusKey))
                {
                    rb.AddForce(vDir * vSpeed, vForceMode);
                }
                if (Input.GetKeyDown(vMinusKey))
                {
                    rb.AddForce(vDir * -vSpeed, vForceMode);
                }
                if (Input.GetKeyDown(fPlusKey))
                {
                    rb.AddForce(fDir * fSpeed, fForceMode);
                }
                if (Input.GetKeyDown(fMinusKey))
                {
                    rb.AddForce(fDir * -fSpeed, fForceMode);
                }
                
                break;
            case 2:
                if (Input.GetKey(hPlusKey) && Mathf.Abs(rb.velocity.x) < topSpeed)
                {
                    rb.AddForce(hDir * hSpeed, hForceMode);
                }
                if (Input.GetKey(hMinusKey) && Mathf.Abs(rb.velocity.x) < topSpeed)
                {
                    rb.AddForce(hDir * -hSpeed, hForceMode);
                }
                if (Input.GetKeyDown(vPlusKey))
                {
                    rb.AddForce(vDir * vSpeed, vForceMode);
                }
                if (Input.GetKeyDown(vMinusKey))
                {
                    rb.AddForce(vDir * -vSpeed, vForceMode);
                }
                if (Input.GetKeyDown(fPlusKey))
                {
                    rb.AddForce(fDir * fSpeed, fForceMode);
                }
                if (Input.GetKeyDown(fMinusKey))
                {
                    rb.AddForce(fDir * -fSpeed, fForceMode);
                }
                
                break;
            case 3:
                if (Input.GetKeyDown(hPlusKey))
                {
                    rb.AddForce(hDir * hSpeed, hForceMode);
                }
                if (Input.GetKeyDown(hMinusKey))
                {
                    rb.AddForce(hDir * -hSpeed, hForceMode);
                }
                if (Input.GetKey(vPlusKey) && Mathf.Abs(rb.velocity.y) < topSpeed)
                {
                    rb.AddForce(vDir * vSpeed, vForceMode);
                }
                if (Input.GetKey(vMinusKey) && Mathf.Abs(rb.velocity.y) < topSpeed)
                {
                    rb.AddForce(vDir * -vSpeed, vForceMode);
                }
                if (Input.GetKeyDown(fPlusKey))
                {
                    rb.AddForce(fDir * fSpeed, fForceMode);
                }
                if (Input.GetKeyDown(fMinusKey))
                {
                    rb.AddForce(fDir * -fSpeed, fForceMode);
                }
                
                break;
            case 4:
                if (Input.GetKeyDown(hPlusKey))
                {
                    rb.AddForce(hDir * hSpeed, hForceMode);
                }
                if (Input.GetKeyDown(hMinusKey))
                {
                    rb.AddForce(hDir * -hSpeed, hForceMode);
                }
                if (Input.GetKeyDown(vPlusKey))
                {
                    rb.AddForce(vDir * vSpeed, vForceMode);
                }
                if (Input.GetKeyDown(vMinusKey))
                {
                    rb.AddForce(vDir * -vSpeed, vForceMode);
                }
                if (Input.GetKey(fPlusKey) && Mathf.Abs(rb.velocity.z) < topSpeed)
                {
                    rb.AddForce(fDir * fSpeed, fForceMode);
                }
                if (Input.GetKey(fMinusKey) && Mathf.Abs(rb.velocity.z) < topSpeed)
                {
                    rb.AddForce(fDir * -fSpeed, fForceMode);
                }
                
                break;
            case 5:
                if (Input.GetKeyDown(hPlusKey))
                {
                    rb.AddForce(hDir * hSpeed, hForceMode);
                }
                if (Input.GetKeyDown(hMinusKey))
                {
                    rb.AddForce(hDir * -hSpeed, hForceMode);
                }
                if (Input.GetKey(vPlusKey) && Mathf.Abs(rb.velocity.y) < topSpeed)
                {
                    rb.AddForce(vDir * vSpeed, vForceMode);
                }
                if (Input.GetKey(vMinusKey) && Mathf.Abs(rb.velocity.y) < topSpeed)
                {
                    rb.AddForce(vDir * -vSpeed, vForceMode);
                }
                if (Input.GetKey(fPlusKey) && Mathf.Abs(rb.velocity.z) < topSpeed)
                {
                    rb.AddForce(fDir * fSpeed, fForceMode);
                }
                if (Input.GetKey(fMinusKey) && Mathf.Abs(rb.velocity.z) < topSpeed)
                {
                    rb.AddForce(fDir * -fSpeed, fForceMode);
                }
                
                break;
            case 6:
                if (Input.GetKey(hPlusKey) && Mathf.Abs(rb.velocity.x) < topSpeed && Mathf.Abs(rb.velocity.z) < topSpeed)
                {
                    rb.AddForce(hDir * hSpeed, hForceMode);
                }
                if (Input.GetKey(hMinusKey) && Mathf.Abs(rb.velocity.x) < topSpeed && Mathf.Abs(rb.velocity.z) < topSpeed)
                {
                    rb.AddForce(hDir * -hSpeed, hForceMode);
                }
                if (Input.GetKeyDown(vPlusKey))
                {
                    rb.AddForce(vDir * vSpeed, vForceMode);
                }
                if (Input.GetKeyDown(vMinusKey))
                {
                    rb.AddForce(vDir * -vSpeed, vForceMode);
                }
                if (Input.GetKey(fPlusKey) && Mathf.Abs(rb.velocity.z) < topSpeed && Mathf.Abs(rb.velocity.x) < topSpeed)
                {
                    rb.AddForce(fDir * fSpeed, fForceMode);
                }
                if (Input.GetKey(fMinusKey) && Mathf.Abs(rb.velocity.z) < topSpeed && Mathf.Abs(rb.velocity.x) < topSpeed)
                {
                    rb.AddForce(fDir * -fSpeed, fForceMode);
                }
                
                break;
            case 7:
                if (Input.GetKey(hPlusKey) && Mathf.Abs(rb.velocity.x) < topSpeed)
                {
                    rb.AddForce(hDir * hSpeed, hForceMode);
                }
                if (Input.GetKey(hMinusKey) && Mathf.Abs(rb.velocity.x) < topSpeed)
                {
                    rb.AddForce(hDir * -hSpeed, hForceMode);
                }
                if (Input.GetKey(vPlusKey) && Mathf.Abs(rb.velocity.y) < topSpeed)
                {
                    rb.AddForce(vDir * vSpeed, vForceMode);
                }
                if (Input.GetKey(vMinusKey) && Mathf.Abs(rb.velocity.y) < topSpeed)
                {
                    rb.AddForce(vDir * -vSpeed, vForceMode);
                }
                if (Input.GetKeyDown(fPlusKey))
                {
                    rb.AddForce(fDir * fSpeed, fForceMode);
                }
                if (Input.GetKeyDown(fMinusKey))
                {
                    rb.AddForce(fDir * -fSpeed, fForceMode);
                }
                
                break;
            case 8:
                if (Input.GetKey(hPlusKey) && Mathf.Abs(rb.velocity.x) < topSpeed)
                {
                    rb.AddForce(hDir * hSpeed, hForceMode);
                }
                if (Input.GetKey(hMinusKey) && Mathf.Abs(rb.velocity.x) < topSpeed)
                {
                    rb.AddForce(hDir * -hSpeed, hForceMode);
                }
                if (Input.GetKey(vPlusKey) && Mathf.Abs(rb.velocity.y) < topSpeed)
                {
                    rb.AddForce(vDir * vSpeed, vForceMode);
                }
                if (Input.GetKey(vMinusKey) && Mathf.Abs(rb.velocity.y) < topSpeed)
                {
                    rb.AddForce(vDir * -vSpeed, vForceMode);
                }
                if (Input.GetKey(fPlusKey) && Mathf.Abs(rb.velocity.z) < topSpeed)
                {
                    rb.AddForce(fDir * fSpeed, fForceMode);
                }
                if (Input.GetKey(fMinusKey) && Mathf.Abs(rb.velocity.z) < topSpeed)
                {
                    rb.AddForce(fDir * -fSpeed, fForceMode);
                }
                
                break;
        }
    }
}
