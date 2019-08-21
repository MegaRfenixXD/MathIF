using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegurarObjeto : MonoBehaviour
{
    public Transform player;
    public Transform playerCam;
    public float throwForce = 10;
    bool hasPlayer = false;
    bool beingCarried = false;
    public AudioClip[] soundToPlay;
    private AudioSource audio;
    public int dmg;
    private bool touched = false;
    public bool ativaplaca = false;
    public bool ativaplaca4 = false;
    public bool ativaplaca9 = false;
    public bool ativaplaca1 = false;
    public bool ativarbola = false;
    

    void Start()
    {
       
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 1.5f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }
        if (hasPlayer && Input.GetKey(KeyCode.E))
        {
            
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;
        }
        if (beingCarried)
        {
            if (touched)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;
            }
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
                //RandomAudio();
            }
            else if (Input.GetMouseButtonDown(1))
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
            }
        }
    }
    // void RandomAudio()
    // {
    //    if (audio.isPlaying)
    //  {
    //      return;
    //   }
    //   audio.clip = soundToPlay[Random.Range(0, soundToPlay.Length)];
    //   audio.Play();

    // }
    void OnTriggerEnter()
    {
        if (beingCarried)
        {
            touched = true;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Abrir" && this.gameObject.name =="CuboChave" )
        {
            ativaplaca = true;
            Destroy(col.gameObject);

        }

        if (col.gameObject.name == "Balanca4" && this.gameObject.name == "peso4")
        {
            ativaplaca4 = true;
            

        }

        if (col.gameObject.name == "Balanca9" && this.gameObject.name == "peso9")
        {
            ativaplaca9 = true;


        }

        if (col.gameObject.name == "Balanca1" && this.gameObject.name == "peso1")
        {
            ativaplaca1 = true;


        }


        if (col.gameObject.name == "Abrirbola")
        {
            ativarbola = true;
            Destroy(col.gameObject);
          
            

        }



    }
}


