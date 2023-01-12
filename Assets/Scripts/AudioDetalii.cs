using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDetalii : MonoBehaviour
{
    private Camera camera;
    public AudioSource detaliiEsofag1, detaliiEsofag2, detaliiEsofag3, detaliiEsofag4;
    public AudioSource detaliiStomac1, detaliiStomac2, detaliiStomac3, detaliiStomac4, detaliiStomac5, detaliiStomac6, detaliiStomac7;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        string nume_obiect;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                nume_obiect = hit.collider.name;
                //ESOFAG
                if(nume_obiect.Equals("DetaliiEsofag1"))
                    detaliiEsofag1.Play();
                else if(nume_obiect.Equals("DetaliiEsofag2"))
                    detaliiEsofag2.Play();
                else if (nume_obiect.Equals("DetaliiEsofag3"))
                    detaliiEsofag3.Play();
                else if (nume_obiect.Equals("DetaliiEsofag4"))
                    detaliiEsofag4.Play();

                //STOMAC
                if (nume_obiect.Equals("DetaliiStomac1"))
                    detaliiStomac1.Play();
                else if (nume_obiect.Equals("DetaliiStomac2"))
                    detaliiStomac2.Play();
                else if (nume_obiect.Equals("DetaliiStomac3"))
                    detaliiStomac3.Play();
                else if (nume_obiect.Equals("DetaliiStomac4"))
                    detaliiStomac4.Play();
                else if (nume_obiect.Equals("DetaliiStomac5"))
                    detaliiStomac5.Play();
                else if (nume_obiect.Equals("DetaliiStomac6"))
                    detaliiStomac6.Play();
                else if (nume_obiect.Equals("DetaliiStomac7"))
                    detaliiStomac7.Play();
            }
        }
    }
}
