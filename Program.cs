using System;

namespace EjercicioClase;

class Program { 
    public static void Main(String[] args)
    {
        SuperPoder superFuerza = new SuperPoder(
            "Super Fuerza","Destruccion letal", 10);
        SuperHeroe mujerMaravilla = new SuperHeroe("Mujer maravilla","Jessica"
            ,"Tegucigalpa",true,superFuerza);

        SuperPoder elastico = new SuperPoder(
            "Elastico", "Elasticidad", 9);
        SuperHeroe elasticBoy = new SuperHeroe("Elastic Boy", "Ricardo"
            , "Olancho", true, elastico);

        SuperPoder aracnido = new SuperPoder(
           "Aracnido", "tela Araña", 10);
        SuperHeroe spiderman = new SuperHeroe("spiderman", "Isaac"
            , "copan", true, aracnido);

        Console.WriteLine("Nombre: "+mujerMaravilla.nombre);
        Console.WriteLine("Identidad Secreta: " + mujerMaravilla.identidadSecreta);
        Console.WriteLine("Ciudad: " + mujerMaravilla.ciudad);
        Console.WriteLine("Puede Volar: " + mujerMaravilla.puedeVolar);
        Console.WriteLine("Super Poder: " + mujerMaravilla.superPoder.nombre);
        Console.WriteLine("Descripcion: " + mujerMaravilla.superPoder.descripcion);
        Console.WriteLine("Nivel: " + mujerMaravilla.superPoder.nivel);


        Console.WriteLine("Nombre: " + elasticBoy.nombre);
        Console.WriteLine("Identidad Secreta: " + elasticBoy.identidadSecreta);
        Console.WriteLine("Ciudad: " + elasticBoy.ciudad);
        Console.WriteLine("Puede Volar: " + elasticBoy.puedeVolar);
        Console.WriteLine("Super Poder: " + elasticBoy.superPoder.nombre);
        Console.WriteLine("Descripcion: " + elasticBoy.superPoder.descripcion);
        Console.WriteLine("Nivel: " + elasticBoy.superPoder.nivel);


        Console.WriteLine("Nombre: " + spiderman.nombre);
        Console.WriteLine("Identidad Secreta: " + spiderman.identidadSecreta);
        Console.WriteLine("Ciudad: " + spiderman.ciudad);
        Console.WriteLine("Puede Volar: " + spiderman.puedeVolar);
        Console.WriteLine("Super Poder: " + spiderman.superPoder.nombre);
        Console.WriteLine("Descripcion: " + spiderman.superPoder.descripcion);
        Console.WriteLine("Nivel: " + spiderman.superPoder.nivel);
    }

}

