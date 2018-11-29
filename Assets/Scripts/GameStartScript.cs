using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class GameStartScript : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        //StartCoroutine(Upload());
    }

    //IEnumerator Upload()
    //{
    //    List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
    //    formData.Add(new MultipartFormDataSection("field1=foo&field2=bar"));
    //    formData.Add(new MultipartFormFileSection("my file data", "myfile.txt"));

    //    UnityWebRequest www = UnityWebRequest.Post("http://localhost:3000/", formData);
    //    yield return www.SendWebRequest();

    //    if (www.isNetworkError || www.isHttpError)
    //    {
    //        Debug.Log(www.error);
    //    }
    //    else
    //    {
    //        Debug.Log("Form upload complete!");
    //    }
    //}
	
	// Update is called once per frame
	void Update () 
    {
		
	}
}
