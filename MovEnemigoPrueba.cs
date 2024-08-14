using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEnemigoPrueba : MonoBehaviour
{
    public float velocity = 0f;
    public float distancia =  0.1f;
    public Transform[] patrol;
    int target = 0;
    

    // Update is called once per frame
    void Update()
    {
        
        if(movetarget())
        {
            target = nextTarget();
        }
        
        
    }

    private bool movetarget()
    {
        Vector3 distanciavector = patrol[target].position - transform.position;
        if(distanciavector.magnitude < distancia)
        {
            return true;
        }

        Vector3 velocidadvector = distanciavector.normalized;
        transform.position += velocidadvector * velocity * Time.deltaTime;

        return false;
    }

    private int nextTarget()
    {
        target++;
        if(target >= patrol.Length)
        {
            target = 0;
        }
        return target;
    }
}
