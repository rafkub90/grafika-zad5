using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour
{

    private Animator _animator = null;
    public CapsuleCollider player = null;
    private GameObject[] playerTag;

    // Use this for initialization
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {

        _animator.SetBool("isClosed", false);
        Debug.Log("OPEN");

    }
    void OnTriggerExit(Collider collider)
    {
        _animator.SetBool("isClosed", true);
        Debug.Log("Close");


    }
}
