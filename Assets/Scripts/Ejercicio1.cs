using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    //El prestigioso festival de música TICapalooza se prepara para una nueva edición en nuestro país
    //y los organizadores nos piden que desarrollemos un programa para calcular la recaudación del evento en
    //la venta de entradas. 

    //Se debe ingresar la cantidad de entradas vendidas para cada tipo.
    //Sabemos que el límite de espectadores totales en el predio del evento es de 20,400 personas en Campo
    //y 16,200 en Plateas y el precio de las entradas es de $1200 para Campo y $2000 para Platea.

    //El programa debe cumplir los siguientes requerimientos:
    //Se debe mostrar en consola un mensaje informando la recaudación por entradas de campo
    //y de plateas por separado y luego el total sumado. 



    //Se debe mostrar qué cantidad del total de la capacidad del predio quedó vacante.
    //Si las entradas vendidas equivalen al total de la capacidad del predio debe mostrarse además
    //el mensaje “Sold Out!”.



    //Si la suma de la cantidad de entradas para ambos tipos supera la mitad de la  capacidad del
    //predio debe mostrarse el mensaje “El festival fue un éxito!”. Si no lo supera debe mostrarse
    //“Debemos mejorar la convocatoria.



    //Debe mostrarse un mensaje de error descriptivo y no realizar ningún cálculo si la cantidad de
    //entradas vendidas en cualquiera de los tipos es menor a cero o superior a la capacidad del predio para ese tipo.

    public int entradascampo;
    public int entradasplateas;
    int entradasvendidas;
    int preciocampo;
    int precioplateas;
    int limitecampo;
    int limiteplateas;
    int gananciacampo;
    int gananciaplateas;
    int gananciatotal;
    int capacidadpredio;
    int mitadcapacidadpredio;

    // Start is called before the first frame update
    void Start()
    {
        preciocampo = 1200;
        precioplateas = 2000;
        limitecampo = 20400;
        limiteplateas = 16200;
        capacidadpredio = limitecampo + limiteplateas;
        mitadcapacidadpredio = capacidadpredio / 2;
        entradasvendidas = entradascampo + entradasplateas;

        if(entradascampo > limitecampo || entradascampo < 0 || entradasplateas > limiteplateas || entradasplateas < 0)
        {
            Debug.Log("La cantidad de entradas de cualquier tipo es menor a cero o es mayor al límite establecido de cada tipo");
        }

        else
        {
            gananciacampo = entradascampo * preciocampo;
            gananciaplateas = entradasplateas * precioplateas;
            gananciatotal = gananciacampo + gananciaplateas;

            Debug.Log("Recaudación por entradas de campo: $" + gananciacampo);
            Debug.Log("Recaudación por entradas de plateas: $" + gananciaplateas);
            Debug.Log("Recaudación por entradas total: $" + gananciatotal);

            if(entradasvendidas > mitadcapacidadpredio)
            {
                Debug.Log("El festival fue un éxito!");
            }
            else
            {
                Debug.Log("Debemos mejorar la convocatoria");
            }

            if(entradasvendidas == capacidadpredio)
            {
                Debug.Log("Sold out!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
