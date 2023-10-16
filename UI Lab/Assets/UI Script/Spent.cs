using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spend : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void spendMoney()
    {
        PlayerController player = GameObject.Find("Capsule").GetComponent<PlayerController>();
        player.score++;
        GameObject.Find("Inventory").GetComponent<Inventory>().money--;

        Destroy(this.gameObject);
    }
}