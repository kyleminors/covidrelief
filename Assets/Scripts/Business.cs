using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Business : ScriptableObject
{

    public RawImage profileImage;
    public string name;
    public bool isOpen;

    public Product[] products; 
   
}

public class Product : ScriptableObject
{

    public RawImage profileImage;
    public string name;
    public int price; 

}