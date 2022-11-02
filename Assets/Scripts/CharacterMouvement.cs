using System;
using UnityEngine;

public class CharacterMouvement : MonoBehaviour
{
    public Animator Animator;
    [Range(0,10f)]public float Speed;
    [Range(0,1000f)] public float rotationSpeed;

    private void Update()
    {
        //input
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        float mouseX = Input.GetAxis("Mouse X");
        bool isRunning = Input.GetButton("Fire2");
        //controle de l'animator
        
        Animator.SetFloat("forward", vertical);
        Animator.SetFloat("right", horizontal);
        
        //translation du personnage
        if (isRunning) vertical *= 2;
        transform.Translate(horizontal * Speed * Time.deltaTime, 0, vertical * Speed * Time.deltaTime);
        
        //rotation
        transform.Rotate(0, mouseX * rotationSpeed * Time.deltaTime, 0);
    }
}
