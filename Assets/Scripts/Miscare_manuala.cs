using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class Miscare_manuala : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime);
            this.transform.Translate(0f, 0f, 1f * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime);
            this.transform.Translate(0f, 0f, 1f * -speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(Vector3.up, -1);
            this.transform.Translate(1f * -speed * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(Vector3.up, 1);
            this.transform.Translate(1f * speed * Time.deltaTime, 0f, 0f);
        }
    }
}
