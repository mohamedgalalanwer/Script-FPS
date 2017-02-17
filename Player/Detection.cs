using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;



public class Detection : MonoBehaviour
{
    private RaycastHit hit;
    public LayerMask detectionLayer;
    private float checkRate = 0.1f;
    public int range = 200;
     private float timer;

    private Transform myTransform;

    public GameObject killEfect;
    public GameObject killEfect2;

    public GameObject enemy;

    AudioSource audio;
    

   
    public int damageShoot = 20;
   /// public ParticleSystem hitEffect;
   /// 

   // DestroyEnemy de;
   
    void Start()
    {
       // hitEffect.enableEmission = false;
        IntialReferance();
        audio = GetComponent<AudioSource>();
       

       // de = new DestroyEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButtonDown("Fire1")&&timer>=checkRate)
        {
            DetectionItem();
        }
    }

    void IntialReferance()
    {

        myTransform = transform;
        // detectionLayer = 1 << 9;

    }

    /*
    void RandomPostion()
    {

        float x = Random.Range(-5.0f, 50f);
        float z = Random.Range(-5.0f, 50f);
        enemy.transform.position=new Vector3(x, 0, z);
    }
    */
    void DetectionItem()
    {

        timer = 0f;
            audio.Play();
          
           Instantiate(killEfect2, transform.position, transform.rotation);
         
            if (Physics.Raycast(myTransform.position, -myTransform.forward, out hit, range, detectionLayer))
            {
                EnemyHealth eh=hit.collider.GetComponent<EnemyHealth>();
                if(eh!=null){

                //      Debug.Log(hit.transform.name + "is Layer");
                //Debug.DrawLine(transform.position, hit.point, Color.cyan);


             
                      eh.GutHurt(damageShoot);
                   

                }

                Instantiate(killEfect, hit.collider.transform.position, hit.collider.transform.rotation);

               // hitEffect.transform.position = hit.point;
               // hitEffect.enableEmission = true;
               
           //   Destroy(enemy);
                //RandomPostion();
               // de.Destroy_Enemy();
            }


        
        
    }

   
}