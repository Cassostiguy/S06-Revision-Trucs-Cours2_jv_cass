using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationAvecDelai : MonoBehaviour
{
    [SerializeField ] private GameObject _objetACreer;
    [SerializeField] private GameObject _objetPlacemenent;
    private int _monnaies;

    void Start()
    {
        _monnaies = 0;
        // Éxecute la méthode CreerObjet après un délai de 5s
        //Invoke("CreerObjet", 5f);
        // Éxecute la méthode CreerObjet après un délai initiale de 3s et à chaque 1s après
        InvokeRepeating("CreerObjet", 3f, 1f);
        // Cancelle tous les Invoke() actifs
       // CancelInvoke();
    }

    private void Update()
    {
         
    }
    void CreerObjet()
    {

       if (_monnaies ==10) //on peut le mettre soit au debut de creerObjet ou a la fin ou dans update mais priorise ds creer objet. On met return seulement au debut par contre. eneleve si on met a la fin
        {
            CancelInvoke();
            return;
        }
        _monnaies += 1;

        // Instancie un nouveau objet et garde une référence à lui
        GameObject nouvelleCopie = Instantiate(_objetACreer, _objetPlacemenent.transform.position, _objetPlacemenent.transform.rotation);

        // Prends une référence a le Rigidbody attaché au nouveau objet
        Rigidbody _rbNouvelleCopie = nouvelleCopie.GetComponent<Rigidbody>();

        // Applique une force de translation initiale aléatoire
        _rbNouvelleCopie.AddRelativeForce(0, 2f + Random.value, 0, ForceMode.Impulse);

        // Applique une force de rotation initiale aléatoire
        _rbNouvelleCopie.AddRelativeTorque(0f, Random.value, Random.value, ForceMode.Impulse);

        
    }


}
