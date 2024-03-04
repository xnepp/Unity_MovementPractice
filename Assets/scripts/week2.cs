using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
   public GameObject helloText;
   public int somenumber = 10;
   private int speed = 25;
    // Start is called before the first frame update
    void Start()
    {
        //print("hello world, im back");
        //helloText.GetComponent<TextMeshPro>().text = "hello.";
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
    }
}
