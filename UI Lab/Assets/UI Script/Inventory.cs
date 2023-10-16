using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    int max = 8;
    public int money = 0;
    public GameObject buttonPrefab;
    GameObject go;
    Vector3 location;
    Quaternion rotation;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void getMoney()
    {
        if (money == max)
            return;
        else
        {
             money++;
             go = Instantiate(buttonPrefab, GameObject.Find("Inventory").GetComponent<RectTransform>());
             
            
            GameObject.Find("Inventory").GetComponent<RectTransform>().GetPositionAndRotation(out location, out rotation);
            go.GetComponent<RectTransform>().SetPositionAndRotation(location, rotation);
            
        }
    }
    
}