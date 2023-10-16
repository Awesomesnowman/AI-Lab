using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Script : MonoBehaviour
{
    public Canvas CanvasObject;
    public Canvas Credit;
    public Canvas Direction;
    // Start is called before the first frame update
    void Start()
    {
        CanvasObject = GetComponent<Canvas>();
        Credit = GameObject.Find("Credit").GetComponent<Canvas>();
        Direction = GameObject.Find("Direction").GetComponent<Canvas>();
        Credit.GetComponent<Canvas>().enabled = false;
        Direction.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonStart()
    {
        SceneManager.LoadScene("Start");
    }

    public void buttonDirection()
    {
        CanvasObject.GetComponent<Canvas>().enabled = false;
        Direction.GetComponent<Canvas>().enabled = true;
    }

    public void buttonCredit()
    {
        CanvasObject.GetComponent<Canvas>().enabled = false;
        Credit.GetComponent<Canvas>().enabled = true;
    }

    public void checkBox(bool isCheck)
    {
        Debug.Log("The check box is " + isCheck);
    }

    public void sliderChange(float num)
    {
        Debug.Log("The slider is " + num);
    }

    public void stringEdit(string e)
    {
        Debug.Log("The current string is " + e);
    }

    public void stringFinish(string e)
    {
        Debug.Log("The finished string is " + e);
    }

    public void dropChange(int choice)
    {
        Debug.Log("The index is " + choice);
    }
    
    public void exitCredit()
    {
        CanvasObject.GetComponent<Canvas>().enabled = true;
        Credit.GetComponent<Canvas>().enabled = false;
    }

    public void exitDirection()
    {
        CanvasObject.GetComponent<Canvas>().enabled = true;
        Direction.GetComponent<Canvas>().enabled = false;
    }
}
