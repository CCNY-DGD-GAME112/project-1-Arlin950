using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{ 
    public TextMeshProUGUI timertext;
    public TextMeshProUGUI coinText;
    public float timer=5;
    public float coincount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;
        if (timer <=0)
        {
            timer+=5f;
            coincount++;
        }
        timertext.text = timer.ToString("F2");
        coinText.text = "Coin: " + coincount;
    }
    public void AddCoin(int amount)
    {
        coincount += amount;
    }
}
