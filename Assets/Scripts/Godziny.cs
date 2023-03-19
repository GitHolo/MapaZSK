using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Godziny : MonoBehaviour
{
    [SerializeField] public int Lekcja0;
    [SerializeField] public int Lekcja1;
    [SerializeField] public int Lekcja2;
    [SerializeField] public int Lekcja3;
    [SerializeField] public int Lekcja4;
    [SerializeField] public int Lekcja5;
    [SerializeField] public int Lekcja6;
    [SerializeField] public int Lekcja7;
    [SerializeField] public int Lekcja8;
    [SerializeField] public int Lekcja9;
    [SerializeField] public int Lekcja10;

    

    private GameObject tekst0;
    private GameObject tekst1;
    private GameObject tekst2;
    private GameObject tekst3;
    private GameObject tekst4;
    private GameObject tekst5;
    private GameObject tekst6;
    private GameObject tekst7;
    private GameObject tekst8;
    private GameObject tekst9;
    private GameObject tekst10;

    [SerializeField] private GameObject godz0;
    [SerializeField] private GameObject godz1;
    [SerializeField] private GameObject godz2;
    [SerializeField] private GameObject godz3;
    [SerializeField] private GameObject godz4;
    [SerializeField] private GameObject godz5;
    [SerializeField] private GameObject godz6;
    [SerializeField] private GameObject godz7;
    [SerializeField] private GameObject godz8;
    [SerializeField] private GameObject godz9;
    [SerializeField] private GameObject godz10;
  
    string[] Lekcje = new string[] { "ASSO", "Biologia", "Chemia", "Doradztwo zawodowe", "Fizyka", "Geografia", "Historia", "J.Angielski", "Informatyka", "J.Ang. Zaw.", "J.Niemiecki", "J.Polski", "Matematyka", "MIELSK", "PP", "PASSO", "PMIELSK", "Praktyka Zawodowa", "WF", "ZZW", "ZRZ", ""};
    /*
     * 0="ASSO", 
     * 1="Biologia", 
     * 2="Chemia", 
     * 3="Doradztwo zawodowe", 
     * 4="Fizyka", "Geografia", 
     * 5="Historia", 
     * 6="J.Angielski", 
     * 7="Informatyka", 
     * 8="J.Angielski Zawodowy", 
     * 9="J.Niemiecki", 
     * 10="J.Polski", 
     * 11="Matematyka", 
     * 12="MIELSK", 
     * 13="PP", 
     * 14="PASSO", 
     * 15="PMIELSK", 
     * 16="Praktyka Zawodowa", 
     * 17="WF", 
     * 18="ZZW", 
     * 19="ZRZ",
     * 20=""
     */
    Dictionary<int, Color> lekcjaColors = new Dictionary<int, Color>();
    private void Awake()
    {
        lekcjaColors.Add(0, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(1, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(2, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(3, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(4, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(5, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(6, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(7, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(8, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(9, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(10, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(11, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(12, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(13, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(14, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(15, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(16, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(17, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(18, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(19, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
        lekcjaColors.Add(20, new Color(Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, Random.Range(50f, 170f) / 255f, 1f));
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        tekst0 = godz0.transform.GetChild(0).gameObject;
        tekst0.GetComponent<TMP_Text>().text = Lekcje[Lekcja0];
        switch (Lekcja0)
        {
            case 21:
                godz0.GetComponent<Image>().color = Color.clear;
                break;
            default:
                godz0.GetComponent<Image>().color = lekcjaColors[Lekcja0];
                break;
        }

        tekst1 = godz1.transform.GetChild(0).gameObject;
        tekst1.GetComponent<TMP_Text>().text = Lekcje[Lekcja1];
        switch (Lekcja1)
        {
            case 21:
                godz1.GetComponent<Image>().color = Color.clear;
                break;
            default:
                godz1.GetComponent<Image>().color = lekcjaColors[Lekcja1];
                break;
        }

        tekst2 = godz2.transform.GetChild(0).gameObject;
        tekst2.GetComponent<TMP_Text>().text = Lekcje[Lekcja2];
        switch (Lekcja2)
        {
            case 21:
                godz2.GetComponent<Image>().color = Color.clear;
                break;
            default:
                godz2.GetComponent<Image>().color = lekcjaColors[Lekcja2];
                break;
        }

        tekst3 = godz3.transform.GetChild(0).gameObject;
        tekst3.GetComponent<TMP_Text>().text = Lekcje[Lekcja3];
        switch (Lekcja3)
        {
            case 21:
                godz3.GetComponent<Image>().color = Color.clear;
                break;
            default:
                godz3.GetComponent<Image>().color = lekcjaColors[Lekcja3];
                break;
    
        }
        tekst4 = godz4.transform.GetChild(0).gameObject;
        tekst4.GetComponent<TMP_Text>().text = Lekcje[Lekcja4];
        switch (Lekcja4)
        {
            case 21:
                godz4.GetComponent<Image>().color = Color.clear;
                break;
            default:
                godz4.GetComponent<Image>().color = lekcjaColors[Lekcja4];
                break;
        }

        tekst5 = godz5.transform.GetChild(0).gameObject;
        tekst5.GetComponent<TMP_Text>().text = Lekcje[Lekcja5];
        switch (Lekcja5)
        {
            case 21:
                godz5.GetComponent<Image>().color = Color.clear;
                break;
            default:
                godz5.GetComponent<Image>().color = lekcjaColors[Lekcja5];
                break;
        }

        tekst6 = godz6.transform.GetChild(0).gameObject;
        tekst6.GetComponent<TMP_Text>().text = Lekcje[Lekcja6];
        switch (Lekcja6)
        {
            case 21:
                godz6.GetComponent<Image>().color = Color.clear;
                break;
            default:
                godz6.GetComponent<Image>().color = lekcjaColors[Lekcja6];
                break;
        }

        tekst7 = godz7.transform.GetChild(0).gameObject;
        tekst7.GetComponent<TMP_Text>().text = Lekcje[Lekcja7];
        switch (Lekcja7)
        {
            case 21:
                godz7.GetComponent<Image>().color = Color.clear;
                break;
            default:
                godz7.GetComponent<Image>().color = lekcjaColors[Lekcja7];
                break;
        }

        tekst8 = godz8.transform.GetChild(0).gameObject;
        tekst8.GetComponent<TMP_Text>().text = Lekcje[Lekcja8];
        switch (Lekcja8)
        {
            case 21:
                godz8.GetComponent<Image>().color = Color.clear;
                break;
            default:
                godz8.GetComponent<Image>().color = lekcjaColors[Lekcja8];
                break;
        }

        tekst9 = godz9.transform.GetChild(0).gameObject;
        tekst9.GetComponent<TMP_Text>().text = Lekcje[Lekcja9];
        switch (Lekcja9)
        {
            case 21:
                godz9.GetComponent<Image>().color = Color.clear;
                break;
            default:
                godz9.GetComponent<Image>().color = lekcjaColors[Lekcja9];
                break;
        }

        tekst10 = godz10.transform.GetChild(0).gameObject;
        tekst10.GetComponent<TMP_Text>().text = Lekcje[Lekcja10];
        switch (Lekcja10)
        {
            case 21:
                godz10.GetComponent<Image>().color = Color.clear;
                break;
            default:
                godz10.GetComponent<Image>().color = lekcjaColors[Lekcja10];
                break;
        }
    }




}
