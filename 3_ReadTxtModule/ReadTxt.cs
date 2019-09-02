using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ReadTxt : MonoBehaviour
{
    [TextArea]
    public string ecriture;

    [UnityEditor.MenuItem("ECRITURE-LECTURE FICHIER TXT/ ecriture")]
     public void WriteText()
    {
        string path = "Assets/Resources/ReadTxtFile.txt";
          
        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(ecriture);
        writer.Close();

        //Re-import the file to update the reference in the editor
        UnityEditor.AssetDatabase.ImportAsset(path);
        var asset = Resources.Load<TextAsset>("ReadTxt");

        //Print the text from the file
        Debug.Log(asset.text);
    }

    [UnityEditor.MenuItem("ECRITURE-LECTURE FICHIER TXT/ lecture")]
     public void ReadText()
    {
        string path = "Assets/Resources/ReadTxtFile.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }

    [UnityEditor.MenuItem("ECRITURE-LECTURE FICHIER TXT/ clean")]
    public void ClearText()
    {
        string path = "Assets/Resources/ReadTxtFile.txt";
        Stream stream = new FileStream(path, FileMode.Truncate);
        StreamWriter writer = new StreamWriter(stream);
        writer.Write("");

    }

}
