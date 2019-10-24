﻿using System;

namespace Duracion
{
    //Clase duracion
    class Duracion
    {
        //Variables publicas
       public  int Horas;
       public int Minutos;
       public int Segundos;

        //Constructor
        public Duracion(int H, int M, int S )
        {
            this.Horas=H;
            this.Segundos=S;
            this.Minutos=M;
        }
         //Metodo para imprimir duracion en formato HH:MM:SS
        public void imprimeHMS()
       {
        Console.WriteLine("{0}:{1}:{2} hrs",Horas,Minutos, Segundos);
       }
       //Metodo convertir la hora a segundos
       public void conversionSeg()
       {
          int S;
          S=(Horas*3600)+(Minutos*60)+Segundos;
            Console.WriteLine("Hora en Segundos: {0}", S);
       }
    
       //Metodo convertir la hora a minutos
       public void conversionMin()
       {
           int M;
           M=(Horas*60)+Minutos+(Segundos/60);
           Console.WriteLine("Hora en Minutos: {0}",M);
       }
        //Constructor segundos
        public Duracion(int S)
        {
            this.Segundos=S;

            Horas=(int) S/3600;
            Minutos=(int)(S-(Horas*3600))/60;
            Segundos=(int)S-(Horas*3600)-(Minutos*60);
        }
        //Imprimir conversion de segundos a formato HH:MM:SS
        public void imprimeSaHMS()
        {
            Console.WriteLine("{0}:{1}:{2} hrs",Horas,Minutos,Segundos);
        }
        //Sumar duraciones(Sobre carga de operadores)
        public static Duracion operator +(Duracion hms, Duracion SaHMS)
        {
            int S=0;

            S= ((hms.Horas+SaHMS.Horas)*3600)+((hms.Minutos+SaHMS.Minutos)*60)+(hms.Segundos+SaHMS.Segundos);

            return new Duracion(S);     
        }
        //Imprimir suma de duraciones en formato HH:MM:SS
        public void imprimeSuma()
        {
            Console.WriteLine("La suma es: {0}:{1}:{2} hrs",Horas,Minutos,Segundos);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           //Crear objeto de la clase
           Duracion hms=new Duracion(8,30,50);

           //Imprimir horas en formato HH:MM:SS
           hms.imprimeHMS();

           //Imprimir conversiones a segundos y minutos
           hms.conversionSeg();
           hms.conversionMin();

          //Crear objeto de la clase
           Duracion SaHMS=new Duracion(7000);

           //Imprimir conversion de segundos a formato HH:MM:SS
           Console.WriteLine("7000 segundos equivalen a: ");
           SaHMS.imprimeSaHMS();

           //Crear objeto de la clase
           Duracion Suma;

           //Imprimir suma de duraciones 
           Suma=hms+SaHMS;
           Suma.imprimeSuma();

        }
    }
}