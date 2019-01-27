using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> InstantObjs = new List<GameObject>();
    public InterSceneManager iSM;
    public List<Player> pList = new List<Player>();
    public List<Transform> startPos = new List<Transform>();
    public List<HealthBar> bars = new List<HealthBar>();

    public TextMeshProUGUI victoryText;

    public bool FightIsOn;
    public float counter;

    public void DamageText(Vector3 pos, int damage)
    {
        pos.y += 0;

        GameObject obj = Instantiate(InstantObjs[0]);
        obj.transform.position = pos;
        TextMeshPro text = obj.GetComponent<TextMeshPro>();
        text.text = damage.ToString();
        Destroy(obj, 1);

        obj = Instantiate(InstantObjs[1]);
        obj.transform.position = pos;
        pos.y += 0.5f;
        Destroy(obj, 1);
    }

    public void Start()
    {
        iSM = GameObject.Find("InterSceneManager").GetComponent<InterSceneManager>();

        pList.Clear();

        foreach(PlayerStats pS in iSM.pS)
        {
            GameObject obj = Instantiate(pS.pPrefab);
            Vector3 pos = startPos[pS.playerNumber - 1].position;
            obj.transform.position = pos;
            if(pS.playerNumber == 1)
            {
                obj.transform.rotation = Quaternion.Euler(0, -180, 0);
            }
            else if(pS.playerNumber == 2)
            {
                obj.transform.rotation = Quaternion.Euler(0, 0, 0);
            }

            Player p = obj.GetComponent<Player>();
            p.playerNumber = pS.playerNumber;
            p.health = 200;
            p.pColor = pS.pColor;

            pList.Add(p);
            bars[pS.playerNumber - 1].player = p;
        }

        FightIsOn = true;


    }

    public void Update()
    {
        if(FightIsOn == false)
        {
            if(counter > 0)
            {
                counter -= 1 * Time.deltaTime;
            }
            else
            {
                iSM.EndFight();
            }

        }
    }

    public void GameEnds(Player p)
    {
        victoryText.gameObject.SetActive(true);
        victoryText.text = p.gameObject.GetComponent<Character>().pName + " Wins!";
        victoryText.color = p.pColor;
    }
}
