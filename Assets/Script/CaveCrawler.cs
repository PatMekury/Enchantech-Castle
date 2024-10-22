using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveCrawler : MonoBehaviour
{
    public GameObject[] caveCrawlers;
    public GameObject[] outsideCrawlers;
    public GameObject[] theCrawlers;

    public GameObject trapTeleporter;

    // Function to set theCrawler animator controller trigger to isWalking
    public void SetTheCrawlerWalking()
    {
        foreach (GameObject crawler in theCrawlers)
        {
            Animator animator = crawler.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetTrigger("isWalking");
            }
        }
    }

    // Function to set the caveCrawler and theCrawler game objects active
    public void SetCrawlersActive()
    {
        foreach (GameObject crawler in outsideCrawlers)
        {
            crawler.SetActive(true);
        }

        foreach (GameObject crawler in theCrawlers)
        {
            crawler.SetActive(true);
        }
    }

  

    // Function to set theCrawler animator controller trigger to reset
    public void SetTheCrawlerReset()
    {
        foreach (GameObject crawler in theCrawlers)
        {
            crawler.SetActive(false);
            Animator animator = crawler.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetTrigger("reset");
            }
        }

        foreach (GameObject crawler in outsideCrawlers)
        {
            crawler.SetActive(false); 
        }
    }

    // Function to set caveCrawler animator controller trigger to isAttacking
    public void SetCaveCrawlerAttacking()
    {
        foreach (GameObject crawler in caveCrawlers)
        {
            Animator animator = crawler.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetTrigger("isAttacking");
            }
        }
        StartCoroutine(ActivateTrapAndRest());
    }

    private IEnumerator ActivateTrapAndRest()
    {
        yield return new WaitForSeconds(1f);
        trapTeleporter.SetActive(true);
        SetTheCrawlerReset();
    }

    // Function to set caveCrawler animator controller trigger to isDead
    public void SetCaveCrawlerDead()
    {
        foreach (GameObject crawler in caveCrawlers)
        {
            Animator animator = crawler.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetTrigger("isDead");
            }
        }
        StartCoroutine(OnDeath());
    }

    private IEnumerator OnDeath()
    {
        yield return new WaitForSeconds(3f);
        foreach (GameObject crawler in caveCrawlers)
        {
            crawler.SetActive(false);
        }
    }

    // Function to set caveCrawler animator controller trigger to isWalking
    public void SetCaveCrawlerIdle()
    {
        foreach (GameObject crawler in caveCrawlers)
        {
            Animator animator = crawler.GetComponent<Animator>();
            if (animator != null)
            {
                animator.SetTrigger("isIdle");
            }
        }
    }
}
