using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuController : MonoBehaviour
{
    public void Jugar_al_lvl()
    {

        SceneManager.LoadScene(2);


    }
    public void Jugar_al_lvl_dos()
    {

        SceneManager.LoadScene(6);


    }
    public void Jugar_al_lvl_tres()
    {

        SceneManager.LoadScene(7);


    }
    public void Jugar_al_tutorial()
    {

        SceneManager.LoadScene(1);


    }
    public void Menu_Principal()
    {

        SceneManager.LoadScene(0);


    }
    public void Game_Over()
    {

        SceneManager.LoadScene(3);

    }
    public void Credits()
    {

        SceneManager.LoadScene(4);


    }
    public void LvL_Selection()
    {

        SceneManager.LoadScene(5);


    }
    public void Salir_del_juego()
    {

        Application.Quit();

    }   
}
