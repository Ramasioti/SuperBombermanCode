using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperBoomberman : MonoBehaviour
{
    class jugador
    {
        public float vel;

        public int BombsMax;
        public int CantidadBombas;
        public int vida;

        public int RangoExplo;

        public void Mover()
        {
            
        }

        public void ColocarBombas(float tiempo, int rango)
        {
            //colocar bomba con tiempo y rango expecifico
        }

        public void TiempodeRecarga()
        {
            // si CantidadBombas es 0, tener cooldown para la proxima bomba
        }

        public void RecibirDaño()
        {
            //collision con bomba, perder vida
        }

        public void RecogerPowerUp()
        {
            //colision recoger powerups, dependiendo el powerup
            //aumentar bombsmax y rangoexplo o aumentar vel
        }
    }

    class bombas
    {
        public int rango;
        public float tiempo;

        public void Explotar(float tiempo)
        {
            //explotar y hacer daño
        }

    }



    class pared
    {
        public int vida;
        public int powerups;

        public void Destruir()
        {
            //vida = 0, drop powerups aleatorio 
        }

    }

    class powerups
    {
        public int vida;
        
        
    }

}
