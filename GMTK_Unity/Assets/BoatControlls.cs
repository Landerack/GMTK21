using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatControlls : MonoBehaviour
{
    [SerializeField] private GameObject Force1;
    [SerializeField] private GameObject Force2;
    [SerializeField] private GameObject Force3;
    public Rigidbody RB;
    [SerializeField] private float moveforce = 50f;
    [SerializeField] private float Rotateforce = 1f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            //force 1
            Debug.Log("adding Force1");
            RB.AddTorque(transform.up * Rotateforce * 75);

            Vector3 direction = this.transform.position - Force3.transform.position;
            RB.AddForceAtPosition(direction.normalized * moveforce, transform.position, ForceMode.Impulse);
        }

        if (Input.GetKeyDown("j"))
        {
            RB.AddTorque(transform.up * Rotateforce * -75);

            Vector3 direction = this.transform.position - Force3.transform.position;
            RB.AddForceAtPosition(direction.normalized * moveforce, transform.position, ForceMode.Impulse);
        }
    }
}
