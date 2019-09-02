using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;

public class ReadXML_1 : MonoBehaviour  //premiere methode pour parcourir un fichier XML, le charger et aller parcourir chaque noeuds
{

    public string XMLpath; //http://test.aurelienlheureux.com/juliennoe/ReadXmlFile.xml // lien internet ou se trouve le XML


    void Awake()
    {

        StartCoroutine("ReadXml"); // Lancement de la coroutine pour récupérer le lien internet

    }


    void Start()
    {
       XmlDocument doc = new XmlDocument(); // chargement du document XML
       
      // doc.Load(Application.dataPath + "/_SCRIPTS/XML/ReadXmlFile.xml"); // chemin ou se trouve le document XML en local

       doc.Load(XMLpath); // chemin ou se trouve le document XML sur internet

        XmlNode root = doc.DocumentElement; // assignation du premier node en root
         
        Debug.Log(root.Name); // vérification du nom du root 
       
       XmlNodeList nodeList = root.SelectNodes("Monsters");  // set du premier node du XML

        Debug.Log(nodeList);
       
       nodeList = nodeList[0].ChildNodes;  // creer une liste pour la sous classe enfant du node

        Debug.Log(nodeList.Count); // compte le nombre de liste dans le xml
        

        Debug.Log(nodeList[0].Attributes["name"].Value);  // va cherche dans la premiere liste l'attribut NAME et sa valeur
        Debug.Log(nodeList[0].SelectSingleNode("Health").InnerText); // va cherche dans la premiere liste l'attribut HEALTH  et sa valeur en texte
        Debug.Log(nodeList[2].Attributes["name"].Value);

    }

    IEnumerator ReadXml() //coroutines pour récupérer le lien URL ou se trouve le fichier XML
    {
        {

            WWW wwwXML = new WWW(XMLpath); // Lecture du lien URL via pathJsonData contenu dans la metaData du marqueur
            yield return wwwXML;
        
            if (wwwXML.error == null) // Vérification du passage des données
            {
                Debug.Log("données parsées");
            }
            else
            {
                Debug.Log("Echec de parsage des données");
            }
        }
    }

}
