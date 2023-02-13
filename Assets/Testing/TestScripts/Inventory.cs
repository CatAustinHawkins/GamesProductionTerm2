using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject InventoryUI;

    public GameObject Object1;
    public GameObject CameraRotateRoom;
    public GameObject Player;
    public GameObject BacktoPlaying;

    public bool inventoryopen = false;

    public float timer;
    public bool timergo;

    private void Update()
    {
        if(timergo)
        {
            timer = timer + 1 * Time.deltaTime;
        }
        
        if(timer > 0.5f)
        {
            timergo = false;
            timer = 0;
        }

        if(Input.GetKey(KeyCode.E))
        {
            if(inventoryopen && timergo == false)
            {
                InventoryUI.SetActive(false);
                inventoryopen = false;
                timergo = true;
            }

            if(inventoryopen == false && timergo == false)
            {
                InventoryUI.SetActive(true);
                inventoryopen = true;
                timergo = true;
            }
        }
    }


    public void Card1Clicked()
    {
        Object1.SetActive(true);
        CameraRotateRoom.SetActive(true);
        Player.SetActive(false);
        BacktoPlaying.SetActive(true);
        InventoryUI.SetActive(false);
        inventoryopen = false;
    }

    public void BacktoGame()
    {
        Player.SetActive(true);
        CameraRotateRoom.SetActive(false);
        Object1.SetActive(false);
        BacktoPlaying.SetActive(false);
    }
}