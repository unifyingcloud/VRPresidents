using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class scriptImageController : MonoBehaviour {

    public Renderer image1;
    public Renderer image2;
    public Renderer image3;
    public Renderer image4;
    public Renderer image5;
    public Renderer image6;
    public Renderer image7;
    public Renderer image8;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(LoadImagefromWeb());

    }

    // Update is called once per frame
    void Update()
    {
       


    }
    public void onBackButton()
    {

		Application.Quit ();

        //SceneManager.LoadScene("Entry");

    } 

    IEnumerator LoadImagefromWeb()
    {
        GameObject persistentGameObject = GameObject.Find("objPresidents");

        string Make = "";
             string Model = "US+president";

        if (persistentGameObject != null)
        {
            PresidentsScript persistentScript = persistentGameObject.GetComponent<PresidentsScript>();
            Make = persistentScript.selectedPresident.Replace(" ", "+");

        }

        WWWForm form = new WWWForm();



        var headers = form.headers;
        byte[] rawData = form.data;
        string url = string.Format("https://api.datamarket.azure.com/Bing/Search/v1/Image?Query=%27{0}%20{1}%27", Make, Model);

        headers["Authorization"] = "Basic " + System.Convert.ToBase64String(
   System.Text.Encoding.ASCII.GetBytes("AppId:f0LOoKzvVhYOEcVrdLmYk9qLg0JdwNoYLZpfgVY49pE"));

        // Post a request to an URL with our custom headers
        WWW www = new WWW(url, null, headers);
        yield return www;

        Texture2D texture = new Texture2D(1, 1);

        string resp = www.text;

        System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
        doc.LoadXml(resp);
         

     
        WWW wwwImage1 = new WWW(doc.GetElementsByTagName("d:MediaUrl")[0].InnerXml);
        WWW wwwImage2 = new WWW(doc.GetElementsByTagName("d:MediaUrl")[2].InnerXml);
        WWW wwwImage3 = new WWW(doc.GetElementsByTagName("d:MediaUrl")[3].InnerXml);
         WWW wwwImage4 = new WWW(doc.GetElementsByTagName("d:MediaUrl")[4].InnerXml);
        WWW wwwImage5 = new WWW(doc.GetElementsByTagName("d:MediaUrl")[6].InnerXml);
        WWW wwwImage6 = new WWW(doc.GetElementsByTagName("d:MediaUrl")[8].InnerXml);
        WWW wwwImage7 = new WWW(doc.GetElementsByTagName("d:MediaUrl")[10].InnerXml);
        WWW wwwImage8 = new WWW(doc.GetElementsByTagName("d:MediaUrl")[12].InnerXml);

        // Wait for download to complete
        yield return wwwImage1;
         yield return wwwImage2;
         yield return wwwImage3;
         yield return wwwImage4;
        yield return wwwImage5;
        yield return wwwImage6;
        yield return wwwImage7;
        yield return wwwImage8;
        //yield return www;
        wwwImage1.LoadImageIntoTexture(texture);
         
        image1.material.mainTexture = wwwImage1.texture;
      image2.material.mainTexture = wwwImage2.texture;
      image3.material.mainTexture = wwwImage3.texture;
      image4.material.mainTexture = wwwImage4.texture;

        image5.material.mainTexture = wwwImage5.texture;
        image6.material.mainTexture = wwwImage6.texture;
        image7.material.mainTexture = wwwImage7.texture;
        image8.material.mainTexture = wwwImage8.texture;
    }



}
