using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JeuV2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _etiquettePoints;
    

    public int pointsJeu = 0;
  

    void Start()
    {
        InvokeRepeating("AugmenterTemps", 0f, 1f);
        pointsJeu = 0;
    }

    public void AugmenterPoints()
    {
        // Augmenter les points du jeu
        pointsJeu++;
        // Actualiser l'UI
        _etiquettePoints.text = "$" + pointsJeu.ToString();
        //_etiquettePoints.text = "T: " + tempsJeu.ToString();
    }

  
}
