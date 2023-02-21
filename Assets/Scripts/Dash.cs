using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{

    public float dashDistance = 5f;
    public float dashTime = 0.5f; 
    public LayerMask dashLayerMask; 


    private bool canDash = true; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && canDash)
        {
            StartCoroutine(DashC());
        }
    }

    IEnumerator DashC()
    {
        canDash = false; 

        float startTime = Time.time; 
        Vector3 dashDirection = transform.right; 

        while (Time.time < startTime + dashTime)
        {
            transform.position += dashDirection * dashDistance / dashTime * Time.deltaTime;

           
            RaycastHit2D hit = Physics2D.Raycast(transform.position, dashDirection, 0.5f, dashLayerMask);
            if (hit.collider != null)
            {
                break;
            }

            yield return null;
        }

        canDash = true; 

        yield return null;
    }
}