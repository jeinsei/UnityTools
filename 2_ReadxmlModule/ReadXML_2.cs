using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System.IO;

public class ReadXML_2 : MonoBehaviour // Deuxieme methode de lecture de fichier XML 
{

    private MonsterCollection monsterCollection; // Récupérer le fichier MonsterCollection

    void Start()
    {
        XmlSerializer serial = new XmlSerializer(typeof(MonsterCollection)); //Sérialise et désérialise des objets dans des documents XML ou à partir de documents XML. XmlSerializer permet de contrôler le mode d'encodage des objets en langage XML.
        Stream  stream  = new FileStream(Application.dataPath + "/_SCRIPTS/XML/ReadXmlFile.xml", FileMode.Open); // permet de lire le fichier XML
        monsterCollection = (MonsterCollection)serial.Deserialize(stream); // ce qui est définie dans MonsterCollection est maintenant égal à ce qui est dans le XML 

        Debug.Log(monsterCollection.Monsters[0].Name);
        Debug.Log(monsterCollection.Monsters[1].Defense);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
