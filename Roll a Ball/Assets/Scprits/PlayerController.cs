using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Rigidbody       rb;
    public float            moveHorizontal;
    public float            moveVertical;
    public float            speed;
    public Text             countText;
    public Text             winText;
    private int             count;
    public Text             TIME;
    public float            timer;
    public string           timerFormatted;
    System.TimeSpan         t;

    void Start () {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
        winText.text = "";
        TIME.text = "";
    }

    void FixedUpdate() {
        this.moveHorizontal = Input.GetAxis("Horizontal");
        this.moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(this.moveHorizontal, 0.0f, this.moveVertical);

        rb.AddForce(movement * this.speed);


    //    t = System.TimeSpan.FromSeconds(timer);

    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            setCountText();
        }
    }

    void setCountText() {
        countText.text = "Count : " + count.ToString();
        if (count == 12)
        {
            winText.text = "YOU WIN MY BRO";
//            timerFormatted = string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms", t.Hours, t.Minutes, t.Seconds, t.Milliseconds);
  //          TIME.text = timerFormatted;
        }

    }
}
 