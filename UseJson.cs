using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseJson : MonoBehaviour
{
    public Text text;
   // public ReadJson readJson;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        ReadText();
    }

    private void ReadText()
    {
        text.text = GetComponent<ReadJson>().textUrlJson;
      //  text.text = readJson.textUrlJson;

    }
}
