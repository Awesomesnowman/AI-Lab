using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int score = 0;
    public Vector2 lastDirection;
    public Rigidbody myRig;
    public float speed = 6.0f;
    Vector3 spawn;
    public float jumpSpeed = 8.0f;
    public Vector3 speedMod = new Vector3(0.0f, 0.0f, 0.0f);
    public int hp = 10;
    public int mhp = 10;
    public GameObject hpBar;
    public RectTransform hpTran;
    private float maxWidth;

    public GameObject scoreText;
    GameObject inv;
    // Start is called before the first frame update
    void Start()
    {
        inv = GameObject.Find("Inventory");
        hpTran = hpBar.GetComponent<RectTransform>();
        maxWidth = hpTran.rect.width;
        myRig = GetComponent<Rigidbody>();
        if (myRig == null)
            throw new System.Exception("Player controller needs rigidbody");
        /*
        myTarget = GameObject.FindGameObjectWithTag("Finish");
        Rigidbody targRB = myTarget.GetComponent<Rigidbody>();
        if (targRB != null)
        {
            targRB.velocity = new Vector3(0, 1, 0);
        }
        else
        {
            Debug.Log("Target had no rigidbody");
            
        }*/
    }


    public void onMove(InputAction.CallbackContext ev)
    {

        if (ev.performed)
        {
            lastDirection = ev.ReadValue<Vector2>();

        }
        if (ev.canceled)
        {
            lastDirection = Vector2.zero;

        }
    }
    // Update is called once per frame
    void Update()
    {

        Vector3 targetV = new Vector3(lastDirection.x, 0, lastDirection.y).normalized * speed;
        //myRig.velocity = Vector3.MoveTowards(myRig.velocity, targetV, 3*Time.deltaTime);
        //myRig.velocity = Vector3.Lerp(myRig.velocity, targetV, .1f);
        myRig.angularVelocity = new Vector3(0, lastDirection.x, 0) * speed;
        myRig.velocity = -1 * transform.right * speed * lastDirection.y + new Vector3(0, myRig.velocity.y, 0) + speedMod;

        hpTran.localScale = new Vector3(hp / (float)mhp, 1, 1);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Red")
        {

            Destroy(collision.gameObject);
            hp--;

        }

        if (collision.gameObject.tag == "Money")
        {
            inv.GetComponent<Inventory>().getMoney();
            if (inv.GetComponent<Inventory>().money < 8)
                Destroy(collision.gameObject);

        }
    }

}
