using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_trigger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string collisonTag;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == collisonTag) { 
            Destroy(this.gameObject);
            SceneManager.LoadScene("loss");
        }
        if(collision.tag == "win")
        {
            Debug.Log("win");
            SceneManager.LoadScene("win");
        }
    }
}
