using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LucyController : MonoBehaviour
{

    [SerializeField] private float slideSpeed = 0.05f;

    GameObject Jupiter;
    GameObject Earth;
    GameObject Saturn;
    GameObject Enceladus;
    GameObject Ganymede;
    GameObject Voyager;
    GameObject Trojans;
    GameObject Trojans2;

    JupiterSound jupiterScript;
    EarthSound earthScript;
    SaturnSound saturnScript;
    EnceladusSound enceladusScript;
    GanymedeSound ganymedeScript;
    VoyagerSound voyagerScript;
    TrojansSound trojansScript;
    Trojans2Sound trojans2Script;




    void Start()
    {     
        this.Jupiter = GameObject.Find("Jupiter");
        this.Earth = GameObject.Find("Earth");
        this.Saturn = GameObject.Find("Saturn");
        this.Enceladus = GameObject.Find("Enceladus");
        this.Ganymede = GameObject.Find("Ganymede");
        this.Voyager = GameObject.Find("Voyager");
        this.Trojans = GameObject.Find("Trojans");
        this.Trojans2 = GameObject.Find("Trojans2");



        jupiterScript = Jupiter.GetComponent<JupiterSound>();
        earthScript = Earth.GetComponent<EarthSound>();
        saturnScript = Saturn.GetComponent<SaturnSound>();
        enceladusScript = Enceladus.GetComponent<EnceladusSound>();
        ganymedeScript = Ganymede.GetComponent<GanymedeSound>();
        voyagerScript = Voyager.GetComponent<VoyagerSound>();
        trojansScript = Trojans.GetComponent<TrojansSound>();
        trojans2Script = Trojans2.GetComponent<Trojans2Sound>();


    }

    void Update()
    {
        PlayerInput();
        JupiterSoundCon();
        EarthSoundCon();
        SaturnSoundCon();
        EnceladusSoundCon();
        GanymedeSoundCon();
        VoyagerSoundCon();
        TrojansSoundCon();
        Trojans2SoundCon();
    }


    //指に追従
    private void PlayerInput()
    {
        //もし入力がなかったらreturnする
        if (Input.touchCount <= 0) return;

        if (Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(touchPosition.x * slideSpeed * Time.deltaTime, touchPosition.y * slideSpeed * Time.deltaTime, 0);
        }
    }

    public void JupiterSoundCon()
    {
        Vector2 p1 = transform.position;  //Lucyの中心座標
        Vector2 p2 = this.Jupiter.transform.position;  //Jupiterの中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float t = 0.6f;

        if (d < t)
        {
            jupiterScript.JupiterSoundPlay();
        }
        else if (d > t)
        {
            jupiterScript.JupiterSoundStop();
        }
    }


    public void EarthSoundCon()
    {
        Vector2 p1 = transform.position;  //Lucyの中心座標
        Vector2 p2 = this.Earth.transform.position;  //惑星の中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float t = 0.8f;

        if (d < t)
        {
            earthScript.SoundPlay();
        }
        else if (d > t)
        {
            earthScript.SoundStop();
        }

    }

    public void SaturnSoundCon()
    {
        Vector2 p1 = transform.position;  //Lucyの中心座標
        Vector2 p2 = this.Saturn.transform.position;  //惑星の中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float t = 0.6f;

        if (d < t)
        {
            saturnScript.SoundPlay();
        }
        else if (d > t)
        {
            saturnScript.SoundStop();
        }

    }

    public void EnceladusSoundCon()
    {
        Vector2 p1 = transform.position;  //Lucyの中心座標
        Vector2 p2 = this.Enceladus.transform.position;  //惑星の中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float t = 0.5f;

        if (d < t)
        {
            enceladusScript.SoundPlay();
        }
        else if (d > t)
        {
            enceladusScript.SoundStop();
        }

    }


    public void GanymedeSoundCon()
    {
        Vector2 p1 = transform.position;  //Lucyの中心座標
        Vector2 p2 = this.Ganymede.transform.position;  //惑星の中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float t = 0.5f;

        if (d < t)
        {
            ganymedeScript.SoundPlay();
        }
        else if (d > t)
        {
            ganymedeScript.SoundStop();
        }

    }


    public void VoyagerSoundCon()
    {
        Vector2 p1 = transform.position;  //Lucyの中心座標
        Vector2 p2 = this.Voyager.transform.position;  //惑星の中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float t = 2.0f;

        if (d < t)
        {
            voyagerScript.SoundPlay();
        }
        else if (d > t)
        {
            voyagerScript.SoundStop();
        }

    }

    public void TrojansSoundCon()
    {
        Vector2 p1 = transform.position;  //Lucyの中心座標
        Vector2 p2 = this.Trojans.transform.position;  //惑星の中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float t = 1.5f;

        if (d < t)
        {
            trojansScript.SoundPlay();
        }
        else if (d > t)
        {
            trojansScript.SoundStop();
        }

    }


    public void Trojans2SoundCon()
    {
        Vector2 p1 = transform.position;  //Lucyの中心座標
        Vector2 p2 = this.Trojans2.transform.position;  //惑星の中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float t = 1.5f;

        if (d < t)
        {
            trojans2Script.SoundPlay();
        }
        else if (d > t)
        {
            trojans2Script.SoundStop();
        }

    }

}
