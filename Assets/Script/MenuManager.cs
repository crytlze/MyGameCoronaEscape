using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject mainmenu;
    public GameObject credit;
    public GameObject pilihlevel;
    public GameObject kalah;
    public void Start()
    {
        mainmenu.SetActive(true);
        credit.SetActive(false);
        pilihlevel.SetActive(false);
        kalah.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PilihLevel(string PilihLevel)
    {
        Application.LoadLevel(PilihLevel);

    }

    public void mulaipilih()
    {
        mainmenu.SetActive(false);
        credit.SetActive(false);
        pilihlevel.SetActive(true);
        kalah.SetActive(false);
    }

    public void CreditsClick()
    {
        mainmenu.SetActive(false);
        credit.SetActive(true);
        pilihlevel.SetActive(false);
        kalah.SetActive(false);
    }

    public void keluarClick()
    {
        Application.Quit();

    }
}
