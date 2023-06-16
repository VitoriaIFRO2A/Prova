using System;
public class Funcionario
{
    public int Salario;
    public int medico;
    public int TI;
    public int ADM;

    public int Medico(int salario)
    {
        int Salario = salario % 20;
        return Salario;
    }
    
    public int Ti (int salario)
    {
        int Salario = salario + 5600;
        return Salario;
    }

    public int Adm (int salario)
    {
        int Salario = salario % 15;
        int salarioo = Salario + 200;
        return salarioo;
    }

}

