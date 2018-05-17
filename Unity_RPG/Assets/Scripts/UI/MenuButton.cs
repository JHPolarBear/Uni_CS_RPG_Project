using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour {

    Button m_MenuButton;

    

	// Use this for initialization
	void Start () {
        m_MenuButton = GetComponent<Button>();

        //Attach Onclick Listener to the Button
        m_MenuButton.onClick.AddListener(OnMenuBtnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMenuBtnClick()
    {

    }
}
