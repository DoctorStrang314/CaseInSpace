using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetKey : MonoBehaviour
{
    public static Dictionary<string, KeyCode> Keys = new Dictionary<string, KeyCode>();
    GameObject InputFild;
    public Text up, left, down, right, pause,shoot,powerShoot;
    private void Start()
    {
        Keys.Add("Up", KeyCode.W);
        Keys.Add("Down", KeyCode.S);
        Keys.Add("Left", KeyCode.A);
        Keys.Add("Right", KeyCode.D);
        Keys.Add("Pause", KeyCode.Q);
        Keys.Add("Shoot", KeyCode.Mouse0);
        Keys.Add("PowerShoot", KeyCode.Mouse1);

        
    }

    private void Update()
    {
        up.text = Keys["Up"].ToString();
        down.text = Keys["Down"].ToString();
        left.text = Keys["Left"].ToString();
        right.text = Keys["Right"].ToString();
        pause.text = Keys["Pause"].ToString();
        shoot.text = Keys["Shoot"].ToString();
        powerShoot.text = Keys["PowerShoot"].ToString();
    }
    void OnGUI()
    {
        if (InputFild!=null)
        {
            Event e = Event.current;
            if (e.isKey)
            {
                Keys[InputFild.name] = e.keyCode;
                InputFild.transform.GetChild(0).GetComponent<Text>().text = e.keyCode.ToString();
                InputFild = null;
            }
        }
    }
    public void changeKey(GameObject clicked)
    {
        InputFild = clicked;
    }
    
}
