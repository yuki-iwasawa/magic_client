using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandCard : MonoBehaviour {

    public GameObject prefab;

    // Use this for initialization
    void Start () {

        // prefab
        prefab = Resources.Load<GameObject>("Card3");
        for (int i = 1; i < 8; i++)
        {
            //var test = prefab.gameObject.GetComponent<GameObject>();()
            GameObject obj = Instantiate(prefab, this.transform.position, Quaternion.identity, this.transform);
            //obj.FindChild("CardTitle").gameObject.GetComponent<Text>().text = "abcdefghi";
            //obj.transform.GetComponent<CardTitle>
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
