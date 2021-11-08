using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour
{
    public Animator animator;
    public bool isScoped = false;
    public GameObject scopeOverlay;
    public GameObject sniperCamera;
    //public Camera mainCamera;

    //public float scopedFOV = 5f;
    private float normalFOV;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            isScoped = !isScoped;
            animator.SetBool("Scoped", isScoped);
        }

        if (isScoped)
        {
            StartCoroutine(OnScoped());
            //mainCamera.fieldOfView = 1f;
        }
        else
        {
            OnUnScoped();
            //mainCamera.fieldOfView = 60f;
        }
    }

    void OnUnScoped()
    {
        scopeOverlay.SetActive(false);
        sniperCamera.SetActive(true);
    }

    IEnumerator OnScoped()
    {
        yield return new WaitForSeconds(.15f);
        scopeOverlay.SetActive(true);
        sniperCamera.SetActive(false);

    }
}
