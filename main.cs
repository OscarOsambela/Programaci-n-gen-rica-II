using System;
using System.Collections.Generic;
using System.Linq;

/*
Se creo una clase generica que permite toda clase de objetos de culaquier tipo 
Con esta clase podemos almacenar objetos tal solo instanciando el tipo de objeto 
*/

public class Program
{
  public static void Main()
  {
    //ejemplo 1 con objeto tipo Empleado
    AlmacenObjetos <Empleado> archivos = new AlmacenObjetos<Empleado>(4);
    archivos.agregar(new Empleado(1500));
    archivos.agregar(new Empleado(3500));
    archivos.agregar(new Empleado(5500));
    archivos.agregar(new Empleado(6500));
    
    //ejemplo 2 con objeto tipo string
    AlmacenObjetos<String> names = new AlmacenObjetos<String>(4);
    names.agregar("Francisco");
    names.agregar("Vernita"); 
    names.agregar("Valentino"); 
    names.agregar("Thelma");       

    //ejemplo 3 con objeto tipo int
    AlmacenObjetos<double> numeros = new AlmacenObjetos<double>(4);
    numeros.agregar(1.56);
    numeros.agregar(2.4);
    numeros.agregar(3.78954);
    numeros.agregar(4);

    Empleado salarioEmpleado = archivos.getElemento(3);
    Console.WriteLine(salarioEmpleado.getSalario());   
    
    String namesSon = names.getElemento(0);
    Console.WriteLine(namesSon); 

    double numerosArray = numeros.getElemento(2);
    Console.WriteLine(numerosArray);
  }
  
  //1.creamos clase con generico con una letra por convencion se utiliza la letra T
  class AlmacenObjetos<T>{

    //3.campos de clase
    private T[] datosElemento;
    private int i = 0;
    
    public AlmacenObjetos(int z){
      datosElemento = new T[z];
    }

    //4.creamos metodo
    public void agregar(T obj){
      datosElemento[i] = obj;
      i++;
    }
    public T getElemento(int i){
      return datosElemento[i];
    }
  }

  class Empleado{
    private double salario;

    public Empleado(double salario){
      this.salario = salario;
    }
    public double getSalario(){
      return salario;
    }
  }
}
