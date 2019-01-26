using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> InstantObjs = new List<GameObject>();

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
}
