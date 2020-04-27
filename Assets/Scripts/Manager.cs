using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    public Business[] businesses;
    public GameObject businessTemplate; 

    // Start is called before the first frame update
    void Start()
    {
        foreach (Business business in businesses)
        {
            var image = businessTemplate.GetComponent<RawImage>();
            var nameText = businessTemplate.GetComponent<Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void BuildBusiness(RawImage image, Text name, bool openBool)
    {

        var newImage = businessTemplate.GetComponent<RawImage>();
        newImage = image;

        var thisText = businessTemplate.GetComponent<Text>();
        thisText = name; 
    }
}
