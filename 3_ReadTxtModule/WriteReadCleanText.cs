using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class WriteReadCleanText : MonoBehaviour
{
    [TextArea]
    public string Texte_a_sauvegarder; // ZONE DE TEXTE QUI SERA SAUVEGARDER DANS LE FICHIER TEXTE

   
     public void WriteText() // FONCTION PERMETTANT D'ECRIRE DANS LE FICHIER TEXTE
    {
        string path = "Assets/Resources/ReadTxtFile.txt";
          
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(Texte_a_sauvegarder);
        writer.Close();

        // re importe le fichier pour pouvoir le lire
        UnityEditor.AssetDatabase.ImportAsset(path);
        var asset = Resources.Load<TextAsset>("ReadTxt");

        Debug.Log(asset.text);
    }


     public void ReadText() // FONCTION PERMETTANT DE LIRE LE FICHIER TEXTE
    {
        string path = "Assets/Resources/ReadTxtFile.txt";

        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }

  
    public void ClearText() // FONCTION  PERMETTANT DE CLEAN LE FICHIER TEXTE
    {
        string path = "Assets/Resources/ReadTxtFile.txt";

        Stream stream = new FileStream(path, FileMode.Truncate);
        StreamWriter writer = new StreamWriter(stream);
        writer.Write("");

    }

}
