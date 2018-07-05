using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {

    public GameObject wall;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("OnButton");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                wall.gameObject.SetActive(false);
            }
        }
    }
}
