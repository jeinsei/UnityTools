using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;

public class ReadXML : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       XmlDocument doc = new XmlDocument();
       
       doc.Load(Application.dataPath + "/_SCRIPTS/ReadXmlFile.xml");
       
       XmlNode root = doc.DocumentElement;

        Debug.Log(root);
       
       XmlNodeList nodeList = root.SelectNodes("Monsters");

        Debug.Log(nodeList);
       
       nodeList = nodeList[0].ChildNodes;  // this creates a list of all MyObjects within MySubClass

        Debug.Log(nodeList.Count); // this shows I have 2 objects within MySubClass (called Monster)

        // loop through each of MyObjects

        Debug.Log(nodeList[0].Attributes["name"].Value); // This Shows MyObject[i] key (name = "foo")
        Debug.Log(nodeList[0].SelectSingleNode("Health").InnerText);





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
