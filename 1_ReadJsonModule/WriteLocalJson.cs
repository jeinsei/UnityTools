using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson; //importer litJosn
using System.IO; // importer System IO

 
public class CharacterClass // définition d'une classe intégrant les futurs éléments à intégrer dans le JSON
{
    public int id;
    public string name;
    public int health;
    public bool agressive;
    public int[] stats;

        public CharacterClass ( int id, string name, int health, bool agressive, int [] stats) // L'on passe les variables en argument afin de pouvoir les modifiers plus facilement
    {
        this.id = id; // Cet id est egal au id de la class...
        this.name = name;
        this.health = health;
        this.agressive = agressive;
        this.stats = stats;
    }

}

public class WriteLocalJson : MonoBehaviour
{
    // Definition des variables publiques qui seront intégrée dans les arguements de la Class CharacterClass
    public int _intID; 
    public  string _stringName;
    public int _intHealth;
    public bool _boolAgressive;
    public int[] _intStats;

    public CharacterClass player;  // importation et définition de la class CharacterClass ici renommé player
    JsonData playerJson; // permet de lire le json


    public void StockJson()
    {
        player = new CharacterClass(_intID, _stringName, _intHealth, _boolAgressive, _intStats); // réécriture du CharacterClass avec les nouveaux éléments défini
        playerJson = JsonMapper.ToJson(player);  // Mapping du Json
        Debug.Log(playerJson);
        File.WriteAllText(Application.dataPath + "/Resources/player.json", playerJson.ToString()); // Ecriture des données dans le JSON

    }
}
