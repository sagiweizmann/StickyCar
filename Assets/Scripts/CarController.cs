using UnityEngine;
using System.Collections;
using static DBManager;
using UnityEngine.UI;

public class CarController : MonoBehaviour {

	public float speed = 1000;
    public float velocity=0f;
	public WheelJoint2D backWheel;
	public WheelJoint2D frontWheel;
	public Rigidbody2D rb;
	private float movement = 0f;
    public Sprite PirateSkin;
    public Sprite BatmanSkin;
    public Sprite CamoSkin;
    public Sprite SpidermanSkin;
    public Sprite CyberSkin;
    public Sprite RainbowSkin;
    public Sprite GalaxySkin;
    public Sprite SnakeSkin;
    public bool gas;
    public bool breaks;
    public AudioSource audio;
    void Start()
    {
        switch(currentskin)
        {
            case 0:
                break;
            case 1:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = PirateSkin;
                break;
            case 2:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = BatmanSkin;
                break;
            case 3:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = CamoSkin;
                break;
            case 4:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = SpidermanSkin;
                break;
            case 5:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = CyberSkin;
                break;
            case 6:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = RainbowSkin;
                break;
            case 7:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = GalaxySkin;
                break;
            case 8:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = SnakeSkin;
                break;

        }
        audio = gameObject.AddComponent<AudioSource>();

    }
    public void gas_on()
    {
        gas = true;
        audio.clip = (AudioClip)Resources.Load("engine");
        audio.loop = true;
        audio.volume = 0.3f;
        audio.Play();

    }
    public void gas_off()
    {
        StartCoroutine(StartFade(audio, 0.3f, 0f));
        gas = false;
    }
    public void break_on()
    {
        breaks = true;
        audio.clip = (AudioClip)Resources.Load("engine");
        audio.loop = true;
        audio.volume = 0.2f;
        audio.Play();
    }
    public void break_off()
    {
        StartCoroutine(StartFade(audio, 0.3f, 0f));
        breaks = false;
    }
    public static IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = audioSource.volume;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }
    void Update ()
	{
		//movement = -Input.GetAxisRaw("Vertical") * speed;
        //Debug.Log(Input.GetAxisRaw("Vertical"));
        if(gas)
        {
 
            velocity = 1f;
        }
        if(breaks)
        {
            velocity = -1f;
        }
        if (gas == false && breaks == false)
        {
            velocity = 0;
        }
       movement = -velocity * speed;
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
        }
    }
    void FixedUpdate ()
	{
		if (movement == 0f)
		{
			backWheel.useMotor = false;
			frontWheel.useMotor = false;
		} else
		{
			backWheel.useMotor = true;
			frontWheel.useMotor = true;

			JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
			backWheel.motor = motor;
			frontWheel.motor = motor;
		}

    }

}
