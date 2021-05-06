using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mummy : MonoBehaviour
{
    private Transform camTr;
    public float moveSpeed = 0.2f;

    void Start()
    {
        camTr = Camera.main.transform;        
    }

    void Update()
    {
        Debug.Log($"transform = {transform.position.x} {transform.position.y} {transform.position.z}");
        //회전
        Vector3 dir = (camTr.position - transform.position);
        dir.y = 0;
        Quaternion rot = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Slerp(transform.rotation,
                                              rot,
                                              Time.deltaTime * 5.0f);
        //이동
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}
