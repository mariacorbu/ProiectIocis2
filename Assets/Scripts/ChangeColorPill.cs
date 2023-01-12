using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorAndSoundPill : MonoBehaviour
{
    public AudioSource audioEsofag, audioStomac, audioDuoden, audioIntestinSubtire, audioIleon, audioIntestinGros, audioRect;

    void FixedUpdate()
    {
        float z = transform.position.z;
       // Debug.Log(z);
        if (4 < z && z < 57)
        {
            this.GetComponent<MeshRenderer>().material.color = new Color32(0, 153, 51, 1);
            if(4 < z && z < 8) audioEsofag.Play();
        }
        else if (57 < z && z < 114)
        {
            this.GetComponent<MeshRenderer>().material.color = new Color32(102, 255, 102, 1);
            if (57 < z && z < 61) audioStomac.Play();
        }
        else if (114 < z && z < 128)
        {
            this.GetComponent<MeshRenderer>().material.color = new Color32(204, 255, 102, 1);
            if (114 < z && z < 117) audioDuoden.Play();
        }
        else if (128 < z && z < 159)
        {
            this.GetComponent<MeshRenderer>().material.color = new Color32(255, 204, 0, 1);
            if (128 < z && z < 131) audioIntestinSubtire.Play();
        }
        else if (159 < z && z < 162)
        {
            this.GetComponent<MeshRenderer>().material.color = new Color32(204, 153, 0, 1);
            if (158 < z && z < 160) audioIleon.Play();
        }
        else if (162 < z && z < 189)
        {
            this.GetComponent<MeshRenderer>().material.color = new Color32(153, 102, 51, 1);
            if (162 < z && z < 165) audioIntestinGros.Play();
        }
        else if (189 < z)
        {
            this.GetComponent<MeshRenderer>().material.color = new Color32(102, 51, 0, 1);
            if (189 < z && z < 192) audioRect.Play();
        }
        else
        {
            this.GetComponent<MeshRenderer>().material.color = Color.white;
        }

    }
}
