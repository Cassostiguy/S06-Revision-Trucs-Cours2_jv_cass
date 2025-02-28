using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollecteurAvecEvenement : MonoBehaviour
{
    public UnityEvent OnCollecterPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Monnaie"))
        {
            OnCollecterPoint.Invoke();
            Destroy(other.gameObject);
        }
    }
}
//dans lui, si on fait une copie du collecteur(barils), les pointss vont augmenter aussi