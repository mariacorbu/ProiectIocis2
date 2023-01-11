using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DancingPill : MonoBehaviour
{
    private float delta = 0.1f;  // Amount to move left and right from the start point
    private float speed = 3.0f;
    private float direction = 1;
    private Quaternion startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion a = startPos;
        a.x += direction * (delta * Mathf.Sin(Time.time * speed));
        this.transform.rotation = a;
    }
}
