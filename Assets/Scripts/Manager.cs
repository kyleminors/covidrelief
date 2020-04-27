using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    public Business[] businesses;
    public GameObject businessTemplate;
    public RawImage newBusinessImage;
    public Text titleInput;
    public 


    // Start is called before the first frame update
    void Start()
    {
        foreach (Business business in businesses)
        {
           
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void BuildBusiness()
    {

        var newImage = businessTemplate.GetComponent<RawImage>();
        var thisText = businessTemplate.GetComponent<Text>();



    }
}
