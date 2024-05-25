namespace TestDemo;
public static class Mathematics
{





    public static bool IsEvenNumber(int num)
    {
        return num % 2 == 0 ? true : false;
    }




    public static bool IsOddNumber(int num)
    {
        return num % 2 == 1 ? true : false;
    }



    public static int SquareOfNumber(int num)
    {
        int sum = 0;
        for (int count = 1; count <= num; count++)
        {
            sum = count * count;
        }
        return sum;
    }



    public static double Addition(double num1, double num2)
    {
        return (num1 + num2);
    }




    public static double Subtraction(double num1, double num2)
    {
        return (num1 - num2);
    }




    public static double Multiplication(double num1, double num2)
    {
        return (num1 * num2);
    }





    public static double Division(double num1, double num2)
    {
        return (num1 / num2);
    }




    public static double CalcularAreaRectangulo(double baseRectangulo, double alturaRectangulo)
    {
        return baseRectangulo * alturaRectangulo;
    }





    public static double VolumenContenedor(double ancho, double largo, double altura)
    {
        return  ancho * largo * altura;
    }




    public static double MetrosCubicosALitros(double metrosCubicos)
    {
        return metrosCubicos * 1000;
    }




     public static double LitrosAMetrosCubicos(double litros)
    {
        return litros / 1000;
    }





    public static double MetrosAKilometros(double metros)
    {
        // 1000 metros = 1 kilómetro
        // Por lo tanto, para convertir metros a kilómetros, dividimos los metros entre 1000
        return metros / 1000;
    }





    public static double CalcularLongitudRampla(double catetoOpuesto, double catetoAdyacente)
    {
        // con el teorema de pitagoras que es hipotenusa^2 = catetoOpuesto^2 + catetoAdyacente^2
        double hipotenusa = Math.Sin(Math.Pow( catetoOpuesto, 2) + Math.Pow (catetoAdyacente, 2));
        return hipotenusa;
    }





     public static double AlturaEdificioSin(double a, double x)
    {
    
        return (a * Math.Sin(x));
    }






     public static double AlturaEdificioTag(double a, double x)
    {
        
        return (a * Math.Tan(x));
    
     }





     public static double AlturaEdificioTeorema(double a, double X, double x)
    {
        // Aplicando el teorema de Pitágoras: catetoOpuesto^2 = hipotenusa^2 - catetoAdyacente^2
        return Math.Sqrt(a * a + X * x);
    }





public static double[] CalculateRoots(double a, double b, double c)
{
    double discriminant = b * b - 4 * a * c;
    
    if (discriminant < 0)   
    {
        // No hay raíces reales
         return (null);
    }

    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

    return new double[] { root1, root2 };
}






    public static double CalculatePurchasePrice(double sellingPrice, double discountPercentage)//PRECIO COMPRA
    {
        // Calcula el precio original antes del descuento
        double originalPrice = sellingPrice / (1 - (discountPercentage / 100));

        return originalPrice;
    }






    public static double CalculateGDP(double consumption, double investment, double governmentSpending, double exports, double imports)//PRODUCTO INTERNO BRUTO
    {
        double GDP = consumption + investment + governmentSpending +(exports - imports);
        return GDP;
    }





     public static double CalculateNumberOfIntervals(double numberOfElements) //INTERVALO
    {
        // Calcula el número de intervalos utilizando la fórmula
        double numberOfIntervals = 1 + 3.32 * Math.Log10(numberOfElements);

        return numberOfIntervals;
    }





      public static double CalculateSampleSizeFinitePopulation(double populationSize, double confidenceLevel, double successProbability, double errorLevel) //MUESTRA FINITA E INFINITA
    {
        double Z = CalculateZValue(confidenceLevel);
        double nf = (populationSize * successProbability * (1 - successProbability) * Math.Pow(Z, 2)) / ((populationSize - 1) * Math.Pow(errorLevel, 2) + successProbability * (1 - successProbability) * Math.Pow(Z, 2));
        return nf;
    }




    public static double CalculateSampleSizeInfinitePopulation(double confidenceLevel, double successProbability, double errorLevel)
    {
        double Z = CalculateZValue(confidenceLevel);
        double ni = (Math.Pow(Z, 2) * successProbability * (1 - successProbability)) / Math.Pow(errorLevel, 2);
        return ni;
    }






    private static double CalculateZValue(double confidenceLevel)
    {
        // Para un nivel de confianza del 1.96%, el valor Z es 1.96.
        return confidenceLevel;
    }





     public static double CalculateEffectiveInterest(double amount, double capital) //TASA DE INTERES EFECTIVA
    {
        // Calcula el interés efectivo restando el capital del monto total
        double effectiveInterest = amount - capital;
        return effectiveInterest;
    }













} 
