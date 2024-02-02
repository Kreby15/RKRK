using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactkey;
    //public UnityEvent interactaction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange) {
            if(Input.GetKeyDown(interactkey)) {
                SceneManager.LoadScene("k", LoadSceneMode.Single);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player")) {
            isInRange = true;
            Debug.Log("Player now in range, you can press E");
        }
    }
    private void OnTriggerExit2D(Collider2D collision) {
        isInRange = false;
        Debug.Log("Player now is not in range, you cant press E");
    }
}
