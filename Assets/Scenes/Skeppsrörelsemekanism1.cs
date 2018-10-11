using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeppsrörelsemekanism1 : MonoBehaviour
{
    public Color Colour;
    public float Speed = 10;
    public SpriteRenderer Rend;
    public int DiceRollColour = 0;
    public int RotationSpeed = 10;
    public float Number1;
    public float StartTime;
    public bool OutsideMap;
    public float RandomSpeed;
    //alla variabler jag använder


    void Start()
    {
        RandomSpeed = Speed + Random.Range(10, 51);
        Rend.color = Colour;
        Colour = new Color(0, 1, 0);
        // gör så att när man startar får man en tilldelad färg



    }




    // Update is called once per frame
    void Update()
    {
        // ser till så att om man åker utanför någon av sidorna så teleporteras man tillbaka till andra sidan
        if (transform.position.x < -95)
        {
            //Om man kommer till -95 x på kordinaterna så teleporteras man till (95 x 0x) istället
            transform.position = new Vector3(95, 0);
        }
        if (transform.position.x > 95)
        {
            //Om man kommer till 95 x på kordinaterna så teleporteras man till (-95 x 0y) istället
            transform.position = new Vector3(-95, 0);
        }
        if (transform.position.y > 50)
        {
            //Om man kommer till 50 y på kordinaterna så teleporteras man till (-50 y 0x) istället
            transform.position = new Vector3(0, -50);
        }
        if (transform.position.y < -50)
        {
            //Om man kommer till -50 y på kordinaterna så teleporteras man till (50 y 0x) istället
            transform.position = new Vector3(0, 50);
        }



        //Slumpvist ger spelaren en fart plus den fart (Speed) du blir tilldelad i början (25)
        transform.Translate(0, RandomSpeed * Time.deltaTime, 0);
        //bestämmer den konstanta farten av spelaren

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Rend.color = new Color(0f, 1f, 0);
            //Gör så att färgen ändras när knappen D trycks ner
            transform.Rotate(0, 0, RotationSpeed);
            //Roterar Spriten (Höger)
            transform.Translate(RandomSpeed * Time.deltaTime, 0, 0);
            //gör så att spriten rör sig i X axelns riktning (Höger)
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rend.color = new Color(0f, 0f, 1f);
            // gör så att färgen ändras när knappen A trycks ner
            transform.Rotate(0, 0, -RotationSpeed / 2);
            //roterar spriten (Vänster)
            transform.Translate((-RandomSpeed * Time.deltaTime) / 2, 0, 0);
            //gör så att spriten rör sig in X axelns riktning (Vänster)
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -RandomSpeed / 2 * Time.deltaTime, 0);
            //farten saktas ner 
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DiceRollColour = Random.Range(1, 4);
            //gör så att man får ett slumpvalt nummer mellan 1 och 3 om man trycker på mellanslagsknappens
            if (DiceRollColour == 1)
            {
                Rend.color = new Color(0.33f, 0.33f, 1);
            }
            //Gör så att om man får 1 så blir det till färgen som är skriven
            else if (DiceRollColour == 2)
            {
                Rend.color = new Color(1, 1, 0);
            }
            //ändrar färgen om man får två
            else if (DiceRollColour == 3)
            {
                Rend.color = new Color(1f, 0f, 0.33f);
            }
            //ändrar färgen om man får 3



        }



    }
}


