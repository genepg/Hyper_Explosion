using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;
using System;
using System.IO;
using System.Text;



public class Gamefunction : MonoBehaviour {
	public float time = 0; //宣告浮點數，名稱time
    public float time2 = 0; //宣告浮點數，名稱time
    public float time3 = 0; //宣告浮點數，名稱time
    public float time4 = 0; //宣告浮點數，名稱time
    public float current_time = 0.0f;
    public float current_time2 = 0.0f;
    public float current_time3 = 0.0f;
    public float current_time4 = 0.0f;
    public int deg=2;
    public int total_deg;
    //UI declare score
    public Text ScoreText;
	public int Score = 0;

	public Image blood;
	public float MaxHP;
	public float HP;
	public static Gamefunction Instance;
    public GameObject bloodd;
    public GameObject ball;
    public GameObject reflectball;
    /*public GameObject longball;*/
    public GameObject doubleclickball;

    // Use this for initialization

    double[] timeSelect = new double[20000];
    double[] timeSelect3 = new double[20000];
    double[] timeSelect4 = new double[20000];


    void text()
    {
        string[] lines = File.ReadAllLines("time/ball.txt");
        string[] lines3 = File.ReadAllLines("time/reflectball.txt");
        string[] lines4 = File.ReadAllLines("time/doubleclickball.txt");
        int k = 0;
        int c = 0;
        int x = 0;

        while (lines[k] != "end")
        {
            timeSelect[k] = double.Parse(lines[k]);
       
            k++;
        }
  
        
        while (lines3[c] != "end")
        {
            timeSelect3[c] = double.Parse(lines3[c]);

            c++;
        }
        
        while (lines4[x] != "end")
        {
            timeSelect4[x] = double.Parse(lines4[x]);

            x++;
        }
    }

    public int i = 0;
    public int i2 = 0;
    public int i3 = 0;
    public int i4 = 0;
    void Start () {
		Instance = this;
        text();
    }


	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(new Vector3(0, 0, deg));

        total_deg = total_deg + deg ;

        if (total_deg >= 360)
        {
            total_deg = total_deg - 360;
        }
       
        current_time = time+Time.deltaTime;
        current_time3 = time3+Time.deltaTime;
        current_time4 = time4+Time.deltaTime;
        time = time + Time.deltaTime; //時間增加
        time3 = time3 + Time.deltaTime; //時間增加
        time4 = time4 + Time.deltaTime; //時間增加

        Vector3 pos = new Vector3 (0, 0, 0);
        
		if( (current_time >= timeSelect[i])&&(current_time <= timeSelect[i]+.025) ) {

            Instantiate(ball, pos, transform.rotation);
            i = i + 1;
        }
        /*if ((current_time2 >= timeSelect2[i2]) && (current_time2 <= timeSelect2[i2] + .025))
        {
            Instantiate(longball, pos, transform.rotation);
            i2 = i2 + 1;
        }*/
        if ((current_time3 >= timeSelect3[i3]) && (current_time3 <= timeSelect3[i3] + .025))
        {
            Instantiate(reflectball, pos, transform.rotation);
            i3 = i3 + 1;
        }
        if ((current_time4 >= timeSelect4[i4]) && (current_time4 <= timeSelect4[i4] + .025))
        {
            Instantiate(doubleclickball, pos, transform.rotation);
            i4 = i4 + 1;
        }
        if (blood.transform.localScale.x <= 0) {
            GameOver();
            
        }
        if ((current_time >= 118))
        {
            endscore();
        }
    }

	public void AddScore(){
		Score += 50;
		ScoreText.text = "Score: "+ Score;
        if ( blood.transform.localScale.x< 1)
        { blood.transform.localScale -= new Vector3(-0.05f, 0.0f, 0.0f); }
       
    }
    public void ReduceScore()
    {
        Score -= 10;
        ScoreText.text = "Score: " + Score;
        if (blood.transform.localScale.x < 1)
        { blood.transform.localScale -= new Vector3(0.02f, 0.0f, 0.0f); }

    }
    public int degree()
    {
        return total_deg;
    }
    public void GameOver()
    {

        PauseMenu.Instance.GameOver();

    }
    public void endscore() {
        PauseMenu.Instance.Endscore();
    }
}



    