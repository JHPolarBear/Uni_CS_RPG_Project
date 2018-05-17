using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControler : MonoBehaviour {

    //Main Menu Panel Button
    [SerializeField]
    private Button m_MainMenuBtn;


    //Main List Panel Button
    [SerializeField]
    private Button m_MainListExitBtn;

    // Use this for initialization
    void Start() {

        //Main menu button
        if (m_MainMenuBtn)
        {
            m_MainMenuBtn.onClick.AddListener(MainMenuBtnOnClick);
        }


        //Main List Exit Button
        if(m_MainListExitBtn)
        {
            m_MainListExitBtn.onClick.AddListener(MainListExitBtnOnClick);
        }

    }

    // Update is called once per frame
    void Update() {

    }

    void MainMenuBtnOnClick()
    {
        Debug.Log("Main Menu Clicked");
    }

    void MainListExitBtnOnClick()
    {
        Debug.Log("Main List Exit Clicked");
    }

}
