using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandCard : MonoBehaviour {

    public GameObject prefab;
    private Collider[] cols;

    // Use this for initialization
    void Start () {

        // prefab
        prefab = Resources.Load<GameObject>("Card3");
        for (int i = 1; i < 8; i++)
        {

            GameObject obj = Instantiate(prefab, this.transform.position, Quaternion.identity, this.transform);
            var cardTitle = obj.transform.GetChild(0);
            //var cardTitle = obj.transform.Find("CardTitle");
            cardTitle.GetComponent<Text>().text = "変更したタイトル" + i;

            var elementImge = obj.transform.GetChild(1);
            elementImge.GetComponent<Image>().sprite = Resources.Load<Sprite>("sprites/attack_sample");
            //var sprite = Resources.Load<Sprite>("sprites/attack_sample");

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
