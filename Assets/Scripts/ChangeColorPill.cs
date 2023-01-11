using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorPill : MonoBehaviour
{

    private Transform esofag, stomac, duoden, intestin_subtire, ileon, intestin_gros, anus;

    private int pos = 5;



    void FixedUpdate()
    {
        esofag = GameObject.FindWithTag("Esofag").transform;
        stomac = GameObject.FindWithTag("Stomac").transform;
        duoden = GameObject.FindWithTag("Duoden").transform;
        intestin_subtire = GameObject.FindWithTag("IntestinSubtire").transform;
        ileon = GameObject.FindWithTag("Ileon").transform;
        intestin_gros = GameObject.FindWithTag("IntestinGros").transform;
        anus = GameObject.FindWithTag("Anus").transform;

        if (Vector2.Distance(esofag.position, transform.position) < pos)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.green;
            Debug.Log(Vector2.Distance(esofag.position, transform.position).ToString() + " -> " + esofag.name);
        }
        else if(Vector2.Distance(stomac.position, transform.position) < pos)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log(Vector2.Distance(stomac.position, transform.position).ToString() + " -> " + stomac.name);
        }
        else if (Vector2.Distance(duoden.position, transform.position) < pos)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.blue;
            Debug.Log(Vector2.Distance(duoden.position, transform.position).ToString() + " -> " + duoden.name);
        }
        else if (Vector2.Distance(intestin_subtire.position, transform.position) < pos)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.magenta;
            Debug.Log(Vector2.Distance(intestin_subtire.position, transform.position).ToString() + " -> " + intestin_subtire.name);
        }
        else if (Vector2.Distance(ileon.position, transform.position) < pos)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.black;
            Debug.Log(Vector2.Distance(ileon.position, transform.position).ToString() + " -> " + ileon.name);
        }
        else if (Vector2.Distance(intestin_gros.position, transform.position) < pos)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.yellow;
            Debug.Log(Vector2.Distance(intestin_gros.position, transform.position).ToString() + " -> " + intestin_gros.name);
        }
        else if (Vector2.Distance(anus.position, transform.position) < pos)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.grey;
            Debug.Log(Vector2.Distance(anus.position, transform.position).ToString() + " -> " + anus.name); 
        }
        else
        {
            this.GetComponent<MeshRenderer>().material.color = Color.white;
        }

    }
}
