using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class score : MonoBehaviour
{
    private TextMeshProUGUI textmeshPro;
    private int br=0;
    // Start is called before the first frame update
    void Start()
    {
        textmeshPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {  if (collide.flag)
        { br += 1;
            collide.flag = false;

        }
        textmeshPro.text = "SCORE:" + br.ToString() ;
    }
}
