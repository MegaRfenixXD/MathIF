using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcionarObjetos : MonoBehaviour
{
    private Animator placa;

    public SegurarObjeto ativar,ativar2,ativar3,ativar4,ativar5;



    void Start()
    {
        ativar = GameObject.Find("CuboChave").GetComponent<SegurarObjeto>();
        ativar2 = GameObject.Find("BolaChave").GetComponent<SegurarObjeto>();
        ativar3 = GameObject.Find("peso4").GetComponent<SegurarObjeto>();
        ativar4 = GameObject.Find("peso9").GetComponent<SegurarObjeto>();
        ativar5 = GameObject.Find("peso1").GetComponent<SegurarObjeto>();

        placa = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        parede();
        Ponte();
        placasbalanca();
    }

    public void parede()
    {
        if (ativar.ativaplaca == true)
        {
            placa.SetBool("Abrir", true);
        }

       
    }
    public void Ponte()
    {
        if (ativar2.ativarbola == true)
        {
            placa.SetBool("Abrir2", true);
        }
    }

    public void placasbalanca()
    {
        if (ativar3.ativaplaca4 == true)
        {
            placa.SetBool("Abrir3", true);
        }

        if (ativar4.ativaplaca9 == true)
        {
            placa.SetBool("Abrir4", true);
        }

        if (ativar5.ativaplaca1 == true)
        {
            placa.SetBool("Abrir5", true);
        }


    }


}
