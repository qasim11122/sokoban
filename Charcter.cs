using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Charcter : MonoBehaviour
{
    // Start is called before the first frame update
 
    [SerializeField] float moveSpeed = 0.01f;
 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAmountHorizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(moveAmountHorizontal ,0, 0);
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
  
        


    }
}
