using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PresidentsScript : MonoBehaviour {

    public Dropdown dd;
    public Button btnGo;

    public GameObject presidents;
    public string selectedPresident;
    // Use this for initialization
    void start()
    {


    }

    
	// Update is called once per frame
	void Update () {


        if (dd != null)
        {
            if (dd.options.Count == 0)
            {
                List<string> lst = new List<string>();
                lst.Add(" George Washington   ");
                lst.Add(" John Adams ");
                lst.Add(" Thomas Jefferson ");
                lst.Add(" James Madison ");
                lst.Add(" James Monroe ");
                lst.Add(" John Quincy Adams ");
                lst.Add(" Andrew Jackson ");
                lst.Add(" Martin Van Buren ");
                lst.Add(" William Henry Harrison ");
                lst.Add(" John Tyler ");
                lst.Add(" James Knox Polk ");
                lst.Add(" Zachary Taylor ");
                lst.Add(" Millard Fillmore ");
                lst.Add(" Franklin Pierce ");
                lst.Add(" James Buchanan ");
                lst.Add(" Abraham Lincoln ");
                lst.Add(" Andrew Johnson ");
                lst.Add(" Ulysses S Grant ");
                lst.Add(" Rutherford B Hayes ");
                lst.Add(" James Garfield ");
                lst.Add(" Chester Arthur ");
                lst.Add(" Grover Cleveland ");
                lst.Add(" Benjamin Harrison ");
                lst.Add(" Grover Cleveland ");
                lst.Add(" William McKinley ");
                lst.Add(" Theodore Roosevelt ");
                lst.Add(" William Howard Taft ");
                lst.Add(" Woodrow Wilson ");
                lst.Add(" Warren Harding ");
                lst.Add(" Calvin Coolidge ");
                lst.Add(" Herbert Hoover ");
                lst.Add(" Franklin D Roosevelt ");
                lst.Add(" Harry S Truman ");
                lst.Add(" Dwight D Eisenhower ");
                lst.Add(" John F Kennedy ");
                lst.Add(" Lyndon Johnson ");
                lst.Add(" Richard Nixon ");
                lst.Add(" Gerald Ford ");
                lst.Add(" James Carter ");
                lst.Add(" Ronald Reagan ");
                lst.Add(" George H W Bush ");
                lst.Add(" William J Clinton ");
                lst.Add(" George W Bush ");
                lst.Add(" Barack H Obama ");

                dd.AddOptions(lst);
            }
        }

    }


    public void buttonGoClick()
    {

        GameObject persistentGameObject = GameObject.Find("objPresidents");

    

        if (persistentGameObject != null)
        {
            PresidentsScript persistentScript = persistentGameObject.GetComponent<PresidentsScript>();
              persistentScript.selectedPresident= dd.captionText.text; 

        }
        else
        { 
        selectedPresident = dd.captionText.text;


       
    }

        SceneManager.LoadScene("PictureLoader");
    }

}
