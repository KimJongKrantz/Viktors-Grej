using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporteringsMekanism : MonoBehaviour
{
    public GameObject Spelaren;
    // ser till så att man kan tilldela ett spelobjekt till denna skripten (jag tillgav skriptet till spelobjektet "Spelaren"

    //Spawn punkter i spelet (ner)
    public float PlaceX;
    public float PlaceY;
    // ger Variablerna namn
    void Start ()
    {
        PlaceX = Random.Range(-30, 30);
        // ser till PlaceX får ett värde mellan -30 och 30
        PlaceY = Random.Range(-30, 30);
        // ser till PlaceY får ett värde mellan -30 och 30
        Spelaren.transform.position = new Vector3(PlaceX, PlaceY, 0);
        // gör så att Spelobjektet anvisat till detta skript automatiskt teleporteras mellan X och Y
    }
	

}
