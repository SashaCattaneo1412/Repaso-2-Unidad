using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateDeactivate : MonoBehaviour
{
    public GameObject inpuField;
  
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivateAndDeactivate()
    {
        //if (inpuField.activeInHierarchy)
        //{
        //    inpuField.SetActive(false);

        //}
        //else
        //{
        //    inpuField.SetActive(true);
        //
        inpuField.SetActive(!inpuField.activeInHierarchy);
       
    }
}
