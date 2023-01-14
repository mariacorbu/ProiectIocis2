using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDetalii : MonoBehaviour
{
    private Camera camera;
    public AudioSource detaliiEsofag1, detaliiEsofag2, detaliiEsofag3, detaliiEsofag4;
    public AudioSource detaliiStomac1, detaliiStomac2, detaliiStomac3, detaliiStomac4, detaliiStomac5, detaliiStomac6, detaliiStomac7;
    public AudioSource detaliiDuoden1, detaliiDuoden2, detaliiDuoden3;
    public AudioSource detaliiIntestinSubtire1, detaliiIntestinSubtire2, detaliiIntestinSubtire3, detaliiIntestinSubtire4, detaliiIntestinSubtire5, detaliiIntestinSubtire6, detaliiIntestinSubtire7, detaliiIntestinSubtire8, detaliiIntestinSubtire9;
    public AudioSource detaliiIleon1, detaliiIleon2, detaliiIleon3;
    public AudioSource detaliiIntestinGros1, detaliiIntestinGros2, detaliiIntestinGros3, detaliiIntestinGros4, detaliiIntestinGros5;
    public AudioSource detaliiRect1;

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

                //DUODEN
                if (nume_obiect.Equals("DetaliiDuoden1"))
                    detaliiDuoden1.Play();
                else if (nume_obiect.Equals("DetaliiDuoden2"))
                    detaliiDuoden2.Play();
                else if (nume_obiect.Equals("DetaliiDuoden3"))
                    detaliiDuoden3.Play();

                //INTESTIN SUBTIRE
                if (nume_obiect.Equals("DetaliiIntestinSubtire1"))
                    detaliiIntestinSubtire1.Play();
                else if (nume_obiect.Equals("DetaliiIntestinSubtire2"))
                    detaliiIntestinSubtire2.Play();
                else if (nume_obiect.Equals("DetaliiIntestinSubtire3"))
                    detaliiIntestinSubtire3.Play();
                else if (nume_obiect.Equals("DetaliiIntestinSubtire4"))
                    detaliiIntestinSubtire4.Play();
                else if (nume_obiect.Equals("DetaliiIntestinSubtire5"))
                    detaliiIntestinSubtire5.Play();
                else if (nume_obiect.Equals("DetaliiIntestinSubtire6"))
                    detaliiIntestinSubtire6.Play();
                else if (nume_obiect.Equals("DetaliiIntestinSubtire7"))
                    detaliiIntestinSubtire7.Play();
                else if (nume_obiect.Equals("DetaliiIntestinSubtire8"))
                    detaliiIntestinSubtire8.Play();
                else if (nume_obiect.Equals("DetaliiIntestinSubtire9"))
                    detaliiIntestinSubtire9.Play();

                //ILEON
                if (nume_obiect.Equals("DetaliiIleon1"))
                    detaliiIleon1.Play();
                else if (nume_obiect.Equals("DetaliiIleon2"))
                    detaliiIleon2.Play();
                else if (nume_obiect.Equals("DetaliiIleon3"))
                    detaliiIleon3.Play();

                //INTESTIN GROS
                if (nume_obiect.Equals("DetaliiIntestinGros1"))
                    detaliiIntestinGros1.Play();
                else if (nume_obiect.Equals("DetaliiIntestinGros2"))
                    detaliiIntestinGros2.Play();
                else if (nume_obiect.Equals("DetaliiIntestinGros3"))
                    detaliiIntestinGros3.Play();
                else if (nume_obiect.Equals("DetaliiIntestinGros4"))
                    detaliiIntestinGros4.Play();
                else if (nume_obiect.Equals("DetaliiIntestinGros5"))
                    detaliiIntestinGros5.Play();

                //RECT
                if (nume_obiect.Equals("DetaliiRect1"))
                    detaliiRect1.Play();
            }
        }
    }
}
