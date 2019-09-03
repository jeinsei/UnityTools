using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class ReadLocalJson : MonoBehaviour // LECTURE D'UN JSON EN LOCAL
{
    public string path; // CHEMIN JSON
    public string jsonString; // MONTRE FICHIER JSON
    public Button colorButton; // BOUTON MODIFIE GRACE AU JSON
  
    [System.Serializable]
    public class Members // DEFINITION DE LA CLASSE POUR LIEN AVEC LE JSON
    {
        public string Layers;
        public byte R;
        public byte G;
        public byte B;
        public string name;
        public string squadName;
        public string homeTown;
       

    }

    void Start()
    {
        jsonString = File.ReadAllText(Application.dataPath + "/Resources/ReadLocalJson2.json"); // LECTURE DU FICHIER JSON
        Members Lines = JsonUtility.FromJson<Members>(jsonString); // CONVERSION DU FICHIER JSON
        Debug.Log(Lines.B);
        Debug.Log(Lines.G);
        Debug.Log(Lines.R);
        Debug.Log(Lines.squadName);

        colorButton.GetComponent<Image>().color = new Color32(Lines.B,Lines.G, Lines.R, 255); // INTEGRATION DES DONNEES JSON
        colorButton.GetComponentInChildren<Text>().text = Lines.homeTown; // INTEGRATION DES DONNEES JSON

    }
}
