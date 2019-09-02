using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadJson : MonoBehaviour
{
    #region VARIABLES

    public string pathJsonData;


    [Header("Liens de debug pour le fichier Json")]
    [Space(20)]
    public string textUrlJson; // stockage du string URL via le Json pour le text
    public string buttonUrlJson; // stockage du string URL via le Json pour le lien du button web
    public string imageUrlJson; // stockage du string URL via le Json pour l'image 2D
    public string videoUrlJson; // stockage du string URL via le Json pour la vidéo
    public string audioClipJson; // stockage du string URL via le Json pour l'audio
    public static string model3dJson; // Variable pour stocker le lien URL du model 3D via le Json
    public static string nameOfAssetBundle; // Variable public pour définir par un champ texte le nom du bundle de l'objet 3D


    [System.Serializable]
    public class jsonData //DECLARATION DES EQUIVALENCES PRESENTES DANS LE JSON EN C#//
    {
        public string textURL;
        public string buttonURL;
        public string imageURL;
        public string videoURL;
        public string audioURL;
        public string modelURL;
        public string bundleName;

    }

    public void Awake()
    {
        pathJsonData = "http://test.aurelienlheureux.com/juliennoe/jsonData.json";
    }


    private void Update() //LANCEMENT DE LA FONCTION UDPATE A CHAQUE FRAME//
    {

        StartCoroutine("linkDataJson");
    }

    #endregion

    #region LANCEMENT DE LA COROUTINE POUR MAPPER LES INFORMATIONS DU JSON AU C#


    IEnumerator linkDataJson()

    {

        Debug.Log("je suis dans la coroutine LinkDataJson");

        WWW wwwPathJson = new WWW(pathJsonData); // Lecture du lien URL via pathJsonData contenu dans la metaData du marqueur
        yield return wwwPathJson;
        jsonData JsonBridge = JsonUtility.FromJson<jsonData>(wwwPathJson.text); // Association du dictionnaire "JsonBridge" avec le Json afin de faire la passerelle entre le C# et le Json

        if (wwwPathJson.error == null) // Vérification du passage des données
        {
            Debug.Log("données parsées");
        }
        else
        {
            Debug.Log("Echec de parsage des données");

        }


        //COMMUNICATION ENTRE LES VALEURS DU JSON ET LES VALEURS STRING EN C#//
        textUrlJson = (JsonBridge.textURL);
        buttonUrlJson = (JsonBridge.buttonURL);
        imageUrlJson = (JsonBridge.imageURL);
        videoUrlJson = (JsonBridge.videoURL);
        audioClipJson = (JsonBridge.audioURL);
        model3dJson = (JsonBridge.modelURL);
        nameOfAssetBundle = "suite";



    }
}

#endregion