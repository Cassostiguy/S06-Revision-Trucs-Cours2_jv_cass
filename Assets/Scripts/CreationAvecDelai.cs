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
        // �xecute la m�thode CreerObjet apr�s un d�lai de 5s
        //Invoke("CreerObjet", 5f);
        // �xecute la m�thode CreerObjet apr�s un d�lai initiale de 3s et � chaque 1s apr�s
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

        // Instancie un nouveau objet et garde une r�f�rence � lui
        GameObject nouvelleCopie = Instantiate(_objetACreer, _objetPlacemenent.transform.position, _objetPlacemenent.transform.rotation);

        // Prends une r�f�rence a le Rigidbody attach� au nouveau objet
        Rigidbody _rbNouvelleCopie = nouvelleCopie.GetComponent<Rigidbody>();

        // Applique une force de translation initiale al�atoire
        _rbNouvelleCopie.AddRelativeForce(0, 2f + Random.value, 0, ForceMode.Impulse);

        // Applique une force de rotation initiale al�atoire
        _rbNouvelleCopie.AddRelativeTorque(0f, Random.value, Random.value, ForceMode.Impulse);

        
    }


}
