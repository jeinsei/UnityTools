using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

public class MonsterCollection // Définie le root du fichier XML (même nom)
{
    public Monster[] Monsters; // Définie un tableau équivalent au premier Node du XML

}

public class Monster // Définie une classe stockant les clés et valeurs du XML
{
    [XmlAttribute("name")]
    public string Name;

    public int Health;

    public int Attack;

    public int Defense;
}
