
using System;
using System.Data;
using System.Linq.Expressions;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor.Media;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.Rendering;

public class Ejercicios : MonoBehaviour
{

    //Estructura Enum
    enum DiasSemana
    {
        Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo
    };
    enum Juegos
    {
        DarkSouls = 1, ResidentEvil = 2, DragonBall = 3, TLOS = 4, TheEvil = 5,
        MarioKart = 6, BobSponja = 7
    };


    [SerializeField] private float Val1 = 3.55f, Val2 = 15.8f;

    [SerializeField] float[] ConjuntoNumero = { 25, -2, 3, -12, 15 };



    [SerializeField] int[] Pesos = new int[] { 60, 100, 80, 55 };



    [SerializeField][Range(0, 25)] public float RadioCirculo;

    [SerializeField] int Entrada = 7;



    void Awake()
    {

        //AumentarNumero();
        //RecorrerArray();
        /*DiasSemanas(3);
        DiasSemanas(2);
        DiasSemanas(6);
        DiasSemanas(1);
        DiasSemanas(8);
        DiasSemanas(4);*/


        /*RutinaJuegos(DiasSemana.Domingo);
        RutinaJuegos(DiasSemana.Jueves);
        RutinaJuegos(DiasSemana.Sabado);
        RutinaJuegos(DiasSemana.Martes);
        if (Espar(1024))
        {
            Debug.Log("El numero es Par");
        }
        else
        {
            Debug.Log("El numero es impar");
        }
        Debug.Log(Espar(45));
        Calcular();
        Final();
        Saludo();
        /*Debug.Log("Buenos dias Brocha"); 
        Debug.Log("Buenos dias Brocha");*/

        /*Igual(6);
        CompararNumeros(15);
        CompararNumeros(8);
        CompararNumeros(22);
        Igual(5);
        Igual(55);
        Media();*/
        Debug.Log($" El resultado de la suma es {SumarNumeros(ConjuntoNumero)}");
        NumIntermedios(Val1, Val2);
        CompararPesos();

        /*Debug.Log($"El Area del circulo es {AreaCirculo(RadioCirculo)}");
        Debug.Log($"ElPerimetro del circulo es {PerimetroCirculo(RadioCirculo)}");
        TablaMultiplicar(Entrada);*/
        MostrarVocales();
    }

    void Saludo()
    {
        Debug.Log("Buenos ");
        Debug.Log("dias ");
        Debug.Log("Brocha");
    }

    void Media()
    {
        float[] Notas = new float[] { 2.5f, 8, 6, 9, 3 };
        float NotaMedia = 0;
        for (int i = 0; i < Notas.Length; i++)
        {
            NotaMedia += Notas[i];
            Debug.Log(NotaMedia);
        }
        NotaMedia = NotaMedia / Notas.Length;
        Debug.Log($"La Media de las notas dadas es   {NotaMedia}");



    }

    void Igual(int NumEntrada)
    {

        if (NumEntrada > 5)
        {
            Debug.Log("Estas aprobado");
        }
        else if (NumEntrada == 80)
        {
            Debug.Log("Los Numeros son Iguales");
        }
        else
        {
            Debug.Log("Los numeros no coinciden");
        }
    }

    void CompararNumeros(int NumeroEntrada)
    {

        if (NumeroEntrada % 2 == 0)
        {
            Debug.Log("El numero " + NumeroEntrada + " es par");
        }
        else
        {
            Debug.Log("El numero " + NumeroEntrada + " es impar");
        }
    }

    void MostrarMayor()
    {
        int[] Entrada = new int[] { 25, 10, -4, 5 };

        for (int i = 0; i < Entrada.Length; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (Entrada[i] > Entrada[j])
                {
                    Debug.Log($"El Numero {Entrada[i]} es mayor que {Entrada[j]}");
                }
            }
        }

    }

    int Contador = 0;
    void AumentarNumero()
    {
        while (Contador <= 100)
        {
            Debug.Log($"Numero {Contador}");
            Contador += 1;
        }
    }
    void Final()
    {
        int NumFinal = 200;


        while (NumFinal >= 0)
        {
            Debug.Log($" Numero {NumFinal}");
            NumFinal--;
        }



    }

    void Calcular()
    {
        int TotalSuma = 0;
        int TotalMultiplicacion = 1;
        int[] ValoresEntrada = new int[] { -5, 4, 8, -10, 3 };
        Debug.Log($"El tamaño del array es {ValoresEntrada.Length}");
        for (int i = 0; i < ValoresEntrada.Length; i++)
        {
            if (ValoresEntrada[i] > 0)
            {
                TotalSuma += ValoresEntrada[i];
            }
            else
            {
                TotalMultiplicacion *= ValoresEntrada[i];
            }
        }

        Debug.Log($"El Total de la suma es {TotalSuma} y el de la multiplicacion es {TotalMultiplicacion}");
    }

    bool Espar(int ValorEntrada)
    {
        return ValorEntrada % 2 == 0;
    }
    DiasSemana DiasSemanas(int DiaEntrada)
    {

        //Instancio la Enumeracion
        DiasSemana Dias;
        switch (DiaEntrada)
        {
            case 1:
                Dias = DiasSemana.Lunes;
                Debug.Log(Dias);
                break;
            case 2:
                Dias = DiasSemana.Martes;
                Debug.Log(Dias);
                break;
            case 3:
                Dias = DiasSemana.Miercoles;
                Debug.Log(Dias);
                break;
            case 4:
                Dias = DiasSemana.Jueves;
                Debug.Log(Dias);
                break;
            case 5:
                Dias = DiasSemana.Viernes;
                Debug.Log(Dias);
                break;
            case 6:
                Dias = DiasSemana.Sabado;
                Debug.Log(Dias);
                break;
            case 7:
                Dias = DiasSemana.Domingo;
                Debug.Log(Dias);
                break;

            default:
                //Gestion de Errores
                throw new SystemException("No te inventes el dia");


        }
        return Dias;
    }

    void RutinaJuegos(DiasSemana Dia)
    {
        Juegos EleccionJuegos;

        switch (Dia)
        {
            case DiasSemana.Lunes:
                Dia = DiasSemana.Lunes;
                EleccionJuegos = Juegos.DarkSouls;
                Debug.Log($"Hoy es {Dia} ; te toca jugar a {EleccionJuegos}");
                break;
            case DiasSemana.Martes:
                Dia = DiasSemana.Martes;
                EleccionJuegos = Juegos.ResidentEvil;
                Debug.Log($"Hoy es {Dia} ; te toca jugar a {EleccionJuegos}");
                break;
            case DiasSemana.Miercoles:
                Dia = DiasSemana.Miercoles;
                EleccionJuegos = Juegos.DragonBall;
                Debug.Log($"Hoy es {Dia} ; te toca jugar a {EleccionJuegos}");
                break;
            case DiasSemana.Jueves:
                Dia = DiasSemana.Jueves;
                EleccionJuegos = Juegos.TLOS;
                Debug.Log($"Hoy es {Dia} ; te toca jugar a {EleccionJuegos}");
                break;
            case DiasSemana.Viernes:
                Dia = DiasSemana.Viernes;
                EleccionJuegos = Juegos.TheEvil;
                Debug.Log($"Hoy es {Dia} ; te toca jugar a {EleccionJuegos}");
                break;
            case DiasSemana.Sabado:
                Dia = DiasSemana.Sabado;
                EleccionJuegos = Juegos.MarioKart;
                Debug.Log($"Hoy es {Dia} ; te toca jugar a {EleccionJuegos}");
                break;

            default:
                Dia = DiasSemana.Domingo;
                EleccionJuegos = Juegos.BobSponja;
                Debug.Log($"Hoy es {Dia} ; te toca jugar a {EleccionJuegos}");
                break;
        }
    }

    void NumIntermedios(float valor1, float valor2)
    {
        for (float valor = valor1; valor <= valor2; valor += 0.1f)
        {
            Debug.Log(valor);
        }
    }

    void CompararPesos()
    {
        int Menos60 = 0;
        int Mas80 = 0;
        int Entre6080 = 0;


        foreach (var volumen in Pesos)
        {
            if (volumen > 80)
            {
                Mas80 += volumen;
            }
            else if (volumen >= 60 & volumen <= 80)
            {
                Entre6080 += 1;
            }
            else
            {
                Menos60 += 1;
            }
        }

        Debug.Log($"Hay {Mas80} personas que pesan mas de 80 kg ,hay {Entre6080} personas que pesan entre 60 y 80 kg"
         + $" y {Menos60}  personas que pesan menos de 60 kg \U0001F642 \U0001F609");
    }

    void RecorrerArray()
    {
        string[] Puerta = new string[] { "A", "B", "C", "D", "E" };

        Debug.Log(Puerta[2]);
        Debug.Log(Puerta.Length);

        foreach (var Entrada in Puerta)
        {
            Debug.Log(Entrada);
        }

        for (int llave = 0; llave < Puerta.Length; llave++)
        {
            Debug.Log(Puerta[llave]);
        }





    }

    float SumarNumeros(float[] numeros)
    {
        float Suma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            Suma += numeros[i];
        }
        return Suma;
    }

    float AreaCirculo(float radio)
    {
        float AreaCirculo = Mathf.PI * Mathf.Pow(radio, 2);
        return AreaCirculo;
    }
    float PerimetroCirculo(float radio)
    {
        float PerimetroCirculo = 2 * Mathf.PI * radio;
        return PerimetroCirculo;
    }

    void TablaMultiplicar(int NumEntrada)
    {

        if (NumEntrada > 0 & NumEntrada < 10)
        {
            for (int multiplicador = 0; multiplicador <= 10; multiplicador++)
            {
                print($" {NumEntrada} X {multiplicador} = {NumEntrada * multiplicador}");


            }
        }
        else
        {
            throw new SystemException("Solo se aceptan positivos mayores que 0 y menores que 10");
        }

        if (NumEntrada < 0 | NumEntrada > 10)

            throw new Exception("Solo se aceptan positivos mayores que 0 y menores que 10");
        for (int multiplicador = 0; multiplicador <= 10; multiplicador++)
        {
            print($" {NumEntrada} X {multiplicador} = {NumEntrada * multiplicador}");


        }
    }

    void MostrarVocales()
    {
        int ContadorVocales = 0;
        string Frase = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. \t Curabitur placerat eu velit ac suscipit. \t Vestibulum ante ipsum primis in faucibus"
        + "orci luctus et ultrices posuere cubilia curae";
        char[] vocales = { 'a', 'A', 'e', 'E', 'I', 'i', 'O', 'o', 'U', 'u' };

        foreach (var palabra in Frase)
        {
            Debug.Log(palabra);
            for (int i = 0; i < vocales.Length; i++)
            {
                if (palabra == vocales[i])
                {
                    ContadorVocales += 1;
                }
            }
        }
        Debug.Log($"Hay {ContadorVocales} vocales");

        //Buencha,create Github para guardar las cosas directamente y es facil de usar
    }


}

