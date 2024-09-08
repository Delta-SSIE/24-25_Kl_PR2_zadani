using System;

class Program {
    public static void Main (string[] args) {

        // Hlavní program je hotový, napište jen metodu JsouVsechnaMensiNez

        double[] cisla = {1, 4, 15, 2, 7, 6, 10, 4};

        double hodnota = 16;
        // int hodnota = 12;

        if (JsouVsechnaMensiNez(hodnota, cisla)) 
        {
            Console.WriteLine($"Všechny hodnoty v poli jsou menší než {hodnota}.");
        }
        else
        {
            Console.WriteLine($"V poli jsou i hodnoty větší nebo rovné {hodnota}.");            
        }
        
    }
}