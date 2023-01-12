using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorPill : MonoBehaviour
{

    void FixedUpdate()
    {
        float z = transform.position.z;

        if (0 < z && z < 57)
        {
            this.GetComponent<MeshRenderer>().material.color = new Color32(0, 153, 51, 1);
        }
        else if (57 < z && z < 114)
        {
            this.GetComponent<MeshRenderer>().material.color = new Color32(102, 255, 102, 1);
        }
        else if (114 < z && z < 128)
        {
            this.GetComponent<MeshRenderer>().material.color = new Color32(204, 255, 102, 1);
        }
        else if (128 < z && z < 159)
        {
            this.GetComponent<MeshRenderer>().material.color = new Color32(255, 204, 0, 1);
        }
        else if (159 < z && z < 162)
        {
            this.GetComponent<MeshRenderer>().material.color = new Color32(204, 153, 0, 1);
        }
        else if (162 < z && z < 189)
        {
            this.GetComponent<MeshRenderer>().material.color = new Color32(153, 102, 51, 1);
        }
        else if (189 < z)
        {
            this.GetComponent<MeshRenderer>().material.color = new Color32(102, 51, 0, 1);
        }
        else
        {
            this.GetComponent<MeshRenderer>().material.color = Color.white;
        }

    }
}
