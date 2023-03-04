using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    public float speed, jumpForce;
    Rigidbody rb;
    [SerializeField] bool canJump = true;
    public float HP = 20f;
    public int sceneIndex = 0;

    private Vector3 velocity;

    public Animator Animation;

    private void Start()
    {
        Animation = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float rotation = Input.GetAxis("Mouse X");
        velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        velocity.y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);
        transform.Translate(velocity.x, 0f, velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            canJump = false;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        if (HP <= 0)
        {
            Diedtest();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Animation.SetBool("Attack", true);
        }
        else
        {
            Animation.SetBool("Attack", false);
        }
    }

    public void Diedtest()
    {
        SceneManager.LoadScene(sceneIndex);
    }

    private void OnCollisionEnter(Collision collision)
    {
        canJump = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DamageTest"))
        {
            Debug.Log(other.CompareTag("DamageTest"));
            HP--;
        }
    }
}