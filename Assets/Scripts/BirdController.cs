using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float force = 50;
    public float velocity = 0.1f;
    public int numberCoin = 3;
    public GameObject UI_Ingame;
    private int direction = 1;

    Rigidbody2D rig;
    UI_Ingame ui_Ingame_script;
    private void Awake()
    {
        rig = gameObject.GetComponent<Rigidbody2D>();
        ui_Ingame_script = UI_Ingame.GetComponent<UI_Ingame>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * direction * velocity * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            rig.AddForce(Vector2.up * force);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            direction = -direction;
            transform.localScale = new Vector3(direction, 1, 1);
        }
        if (other.gameObject.CompareTag("Trap"))
        {
            UI_Ingame.SetActive(true);
            ui_Ingame_script.EndGame(complete: false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            numberCoin--;
            Destroy(other.gameObject);
            if (numberCoin == 0)
            {
                UI_Ingame.SetActive(true);
                ui_Ingame_script.EndGame(complete: true);
            }
        }
        if (other.CompareTag("Trap"))
        {
            UI_Ingame.SetActive(true);
            ui_Ingame_script.EndGame(complete: false);
        }
    }
}
