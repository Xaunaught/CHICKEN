using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody rbody;
    Animator anim;
    //public GameObject camParent;
    //public GameObject camAim;
    //public GameObject playerModel;

    float horizontalInput;
    float verticalInput;
    public float speed;

    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        anim.SetBool("isRunning", true);
    }
    void Update()
    {
//        GetInputs();
//
//        //camParent.transform.Rotate(Vector3.up * (horizontalInput * ((speed * 5) * Time.deltaTime)), Space.World);
//        //var targetRot = Quaternion.LookRotation(camAim.transform.position - playerModel.transform.position);
//        rbody.transform.Rotate(Vector3.up * -horizontalInput);
//
//        rbody.transform.Translate(transform.forward * (verticalInput * (speed * Time.deltaTime)));
//
//        if (verticalInput > Mathf.Abs(0.01f))
//        {
//            anim.SetBool("isRunning", true);
//        }
//        else
//            anim.SetBool("isRunning", false);
    }

    void GetInputs()
    {
//        horizontalInput = Input.GetAxis("Horizontal");
//        verticalInput = Input.GetAxis("Vertical");
    }
}
