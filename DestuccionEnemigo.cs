using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DestuccionEnemigo : MonoBehaviour
{
    
    XRSimpleInteractable interactable;
    // Start is called before the first frame update
    private AudioSource poof;
    public ParticleSystem smokeEffect;
    public AudioClip EfectoSonido;

    void Start()
    {
        poof = GetComponent<AudioSource>();
        interactable = GetComponent<XRSimpleInteractable>();
        interactable.activated.AddListener(DestroyCube);        
    }
    
    void DestroyCube(ActivateEventArgs arg0)
    {
        poof.PlayOneShot(EfectoSonido, 1F);
        Instantiate(smokeEffect, transform.position, transform.rotation ) ;
        this.gameObject.SetActive(false);
    }
}
