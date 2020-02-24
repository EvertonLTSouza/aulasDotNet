public class Decisao6
{
    private int [] numeros = new int[3];

    public void setNumero(int numero, int indice)
    {
        numeros[indice] = numero;
    }

    public int maiorNumero()
    {
        if (numeros[0] > numeros[1] && numeros[0] > numeros[2])
        {
            return numeros[0];
        }
        else if(numeros[1] > numeros[2])
        {
            return numeros[1];
        }
        else
        {
            return numeros[2];
        }
    }

    public int menorNumero()
    {
        if (numeros[0] < numeros[1] && numeros[0] < numeros[2])
        {
            return numeros[0];
        }
        else if(numeros[1] < numeros[2])
        {
            return numeros[1];
        }
        else
        {
            return numeros[2];
        }
    }
}