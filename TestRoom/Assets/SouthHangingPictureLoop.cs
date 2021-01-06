using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SouthHangingPictureLoop : MonoBehaviour
{
    // Start is called before the first frame update
    Material material;
    Texture2D[] textures;
    Renderer m_renderer;
    int pivot = 0;
    string parent;

    public Texture2D[] Textures { get => textures; set => textures = value; }

    void Start()
    {
        m_renderer = GetComponent<Renderer>();
        m_renderer.enabled = true;
        parent = "SouthHangingImages";
        string[] filepaths = Directory.GetFiles("Assets/Resources/" + parent);
        string[] filenames = new string[filepaths.Length / 2];
        for (int i = 0; i < filenames.Length; i++)
        {
            string[] strs = new FileInfo(filepaths[i * 2]).Name.Split('.');
            filenames[i] = strs[0];
            Debug.Log("filenames[" + i + "]: " + filenames[i]);
        }
        Textures = new Texture2D[filenames.Length];
        Debug.Log("Textures.length " + Textures.Length);
        for (int i = 0; i < filenames.Length; i++)
        {
            string pathname = parent + "/" + filenames[i];
            Debug.Log("pathname: " + pathname);
            Textures[i] = Resources.Load(pathname) as Texture2D;
            if (Textures[i])
            {
                Debug.Log("Texture[" + i + "] Loaded Sucessfully...");
            }
            else
            {
                Debug.Log("Unable to Load Texture[" + i + "]");
            }
        }/*
        Textures = new Texture2D[3];
        Textures[0] = Resources.Load("Images/Fire1") as Texture2D;
        if (Textures[0])
        {
            Debug.Log("Texture Loaded Sucessfully...");
        }
        else
        {
            Debug.Log("Unable to Load texture...");
        }
        Textures[1] = Resources.Load("Images/Fire2") as Texture2D;
        Textures[2] = Resources.Load("Images/Fire3") as Texture2D;
        /* 
         * 1. In start, we get the image/s and put it in a LinkedList within the code.
         */
    }
    // Update is called once per frame
    void Update()
    {
        m_renderer.material.SetTexture("_MainTex", Textures[pivot]);
        pivot++;
        if (pivot == Textures.Length)
        {
            pivot = 0;
        }
        /*if (pivot % 20 == 0)
        {
            m_renderer.material.SetTexture("_MainTex", Textures[pivot/20]);
        }
        pivot++;
        
        if (pivot == Textures.Length)
        {
            pivot = 0;
        }
        /* Iterate through the linked list, through its length, set the texture of the asset's material as the next image. 
        This way, we can do GIFs and normal images. 
         **/

    }
}