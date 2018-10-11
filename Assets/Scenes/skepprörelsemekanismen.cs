using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skepprörelsemekanismen : MonoBehaviour {
    public Color Colour;
    public float Speed = 10;
    public SpriteRenderer Rend;
    public int ColourResult = 0;
    public int RotationSpeed = 10;
    public float Number1;
    public float StartTime;
    public float RandomSpeed;
    public char FlipControlls;
    public float Colour1;
    public float Colour2;
    public float Colour3;
    public int PlayerLocation;
    //alla variabler jag använder


    void Start()
    {
        Rend.color = Colour;
        Colour = new Color(1, 1, 1);
        // gör så att när man startar får man en tilldelad färg
        RandomSpeed = Speed + Random.Range(10, 51);
    }
    
		
	
	
	// Update is called once per frame
	void Update ()
    {
        // ser till så att om man åker utanför någon av sidorna så teleporteras man tillbaka till andra sidan
        if (transform.position.x < -95)
        {
            //Om man kommer till -95 x på kordinaterna så teleporteras man till (95x) istället
            transform.position = new Vector3(95, transform.position.y);
        }
        if (transform.position. x > 95)
        {
            //Om man kommer till 95 x på kordinaterna så teleporteras man till (-95 x) istället
            transform.position = new Vector3(-95, transform.position.y);
        }
        if (transform.position. y > 50)
        {
            //Om man kommer till 50 y på kordinaterna så teleporteras man till (-50 y) istället
            transform.position = new Vector3(transform.position.x, -50);
        }
        if (transform.position.y < -50)
        {
            //Om man kommer till -50 y på kordinaterna så teleporteras man till (50 y) istället
            transform.position = new Vector3(transform.position.x, 50);
        }



        //Slumpvist ger spelaren en fart plus den fart (Speed) du blir tilldelad i början (25)
        transform.Translate(0, RandomSpeed * Time.deltaTime, 0);
        //bestämmer den konstanta farten av spelaren

		if (Input.GetKey(KeyCode.D))
        {
            Rend.color = new Color(0f, 1f, 0);
            //Gör så att färgen ändras när knappen D trycks ner
            transform.Rotate(0, 0, RotationSpeed);
            //Roterar Spriten (Höger)
            transform.Translate(RandomSpeed * Time.deltaTime, 0, 0);
            //gör så att spriten rör sig i X axelns riktning (Höger)
        }
        if (Input.GetKey(KeyCode.A))
        {
            Rend.color = new Color(0f, 0f, 1f);
            // gör så att färgen ändras när knappen A trycks ner
            transform.Rotate(0, 0, -RotationSpeed/2);
            //roterar spriten (Vänster)
            transform.Translate((-RandomSpeed * Time.deltaTime)/2 , 0, 0);
            //gör så att spriten rör sig in X axelns riktning (Vänster)
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -RandomSpeed/2 * Time.deltaTime, 0);
            //farten saktas ner 
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, (RandomSpeed * 2) * Time.deltaTime, 0);
            //Farten fördubblas
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
          transform.position = new Vector3 (transform.position.x - 15, transform.position.y );
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
          transform.position = new Vector3 (transform.position.x + 15, transform.position.y) ;
        }


        // Ger spelaren en slumpmässig färg
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Colour1 = Random.Range(0f, 1f);
            // Ger Colour1 ett värde mellan 0 och 1 
            Colour2 = Random.Range(0f, 1f);
            // Ger Colour2 ett värde mellan 0 och 1
            Colour3 = Random.Range(0f, 1f);
            // Ger Colour3 ett värde mellan 0 och 1
            Color ColourResult = new Color(Colour1, Colour2, Colour3);
            // summar ihop alla de decimaltal som man fick av Colour(Siffra)
            Rend.color = ColourResult;
            //Renderar Färgen som man fick slumpmässigt
        }
	}
}
