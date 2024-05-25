namespace TestDemo.Tests;

public class UnitTest1
{




    [Fact]
    public void EvenNumberTest()
    {
        //Arrange 
        var num = 6;
        //Act 
        bool result = Mathematics.IsEvenNumber(num);
        //Assert 
        Assert.True(result);
    }






    [Fact]
    public void SquareOfNumberTest()
    {
        //Arrange 
        var num = 5;
        var expectedResult = 25;
        //Act 
        var result = Mathematics.SquareOfNumber(num);
        //Assert 
        Assert.Equal(expectedResult, result);
    }








    [Fact]
    public void AdditionOfNumber()
    {
        //Arrange 
        var num1 = 5;
        var num2 = 2;
        var expectedResult = 7;
        //Act 
        var result = Mathematics.Addition(num1, num2);
        //Assert 
        Assert.Equal(expectedResult, result);
    }





    [Fact]
    public void SubtractionOfNumber()
    {
        //Arrange 
        var num1 = 5;
        var num2 = 2;
        var expectedResult = 3;
        //Act 
        var result = Mathematics.Subtraction(num1, num2); 
        //Assert 
        Assert.Equal(expectedResult, result);
    }





    [Fact]
    public void MultiplicationOfNumber()
    {
        //Arrange 
        var num1 = 5;
        var num2 = 2;
        var expectedResult = 10;
        //Act 
        var result = Mathematics.Multiplication(num1, num2); 
        //Assert 
        Assert.Equal(expectedResult, result);
    }





    [Fact]
    public void DivisionOfNumber()
    {
        //Arrange 
        var num1 = 10;
        var num2 = 2;
        var expectedResult = 5;
        //Act 
        var result = Mathematics.Division(num1, num2);
        //Assert 
        Assert.Equal(expectedResult, result);
    }





     [Fact]
    public void CalculoAreaRectangulo()
    {
        // Arrange
        double baseRectangulo = 6;
        double alturaRectangulo = 160;
        double expectedResult = 960;

        // Act
        double result = Mathematics.CalcularAreaRectangulo(baseRectangulo, alturaRectangulo);

        // Assert
        Assert.Equal(expectedResult, result);
    }





    [Fact]
    public void VolumenContenedor()
    {
        // Arrange
        var ancho  = 7;
        var largo = 5;
        var altura = 2;
        var expectedResult = 70; 

        // Act
        var result = Mathematics.VolumenContenedor(ancho, largo, altura);

        // Assert
        Assert.Equal(expectedResult, result);
    }






    [Fact]
    public void ConversionMetrosCubicosALitros()
    {
        // Arrange
        double metrosCubicos = 36;
        double expectedResult = 36000; // 36 metros cúbicos son 36000 litros

        // Act
        double result = Mathematics.MetrosCubicosALitros(metrosCubicos);

        // Assert
        Assert.Equal(expectedResult, result);
    }






     [Fact]
    public void ConversionLitrosAMetrosCubicos()
    {
        // Arrange
        double litros = 35000;
        double expectedResult = 35; // 35000 litros son 35 metros cúbicos

        // Act
        double result = Mathematics.LitrosAMetrosCubicos(litros);

        // Assert
        Assert.Equal(expectedResult, result);
    }





    [Fact]
    public void ConversionMetrosAKilometros()
    {
        // Arrange
        double metros = 16165;
        double expectedResult = 16.165; // 16165 metros son 16.165 kilómetros

        // Act
        double result = Mathematics.MetrosAKilometros(metros);

        // Assert
        Assert.Equal(expectedResult, result);
    }






     [Fact]
    public void CalcularLongitudRampla()
    {
        // Arrange
        double catetoOpuesto = 3;
        double catetoAdyacente = 10;
        double expectedResult = 10.44030650891055; // Longitud de la hipotenusa con precisión de 15 decimales

        // Act
        double result = Mathematics.CalcularLongitudRampla(catetoOpuesto, catetoAdyacente);

        // Assert
        Assert.Equal(expectedResult, result, 15); // Precisión de 15 decimales para la comparación
    }







     [Fact]
    public void AlturaEdificioSin()
    {
        // Arrange
        var c = 12;
        var x = 70;
        var expectedResult= 11.276; // Altura del edificio con precisión de tres decimales

        // Act
        double result = Mathematics.AlturaEdificioSin(c, x);

        // Assert
        Assert.Equal(expectedResult, result, 3); // Se especifica una precisión des decimales para la comparación
    }








     [Fact]
    public void AlturaEdificioTag()
    {
        // Arrange
        var a = 0;
        var x = 1;
        var expectedResult = 0; // Altura del edificio con precisión de tres decimales

        // Act
        var result = Mathematics.AlturaEdificioTag(a, x);

        // Assert
        Assert.Equal(expectedResult, result); // Se especifica una precisión de tres decimales para la comparación
    }






     [Fact]
    public void AlturaEdificioTeorema()
    {
        // Arrange
        double a = 4.09;
        double x = 12;
        double expectedResult = 11.856; // Altura del edificio con precisión de tres decimales

        // Act
        double result = Mathematics.AlturaEdificioTeorema( a, x, x);

        // Assert
        Assert.Equal(expectedResult, result, 3); // Se especifica una precisión de tres decimales para la comparación
    }






 [Fact]
public void TestCalculateRoots() //CUADRATICA
{
    // Coeficientes de la ecuación cuadrática
    double a = 8;
    double b = 17;
    double c = 7;

    // Calculando las raíces utilizando la función
    double[] roots = Mathematics.CalculateRoots(a, b, c);

    // Verificando las raíces calculadas
    Assert.NotNull(roots); // Asegurarse de que la lista de raíces no sea nula

    // Comprobando que la cantidad de raíces sea la esperada
    Assert.Equal(2, roots.Length);

    // Verificando las raíces calculadas con una precisión de 5 decimales
    Assert.Equal(0.5, roots[0], 5); 
    Assert.Equal(-0.875, roots[1], 5);
}






    [Fact]
    public void CalculatePurchasePrice() //PRECIO DE COMPRA
    {
        // Precio de venta y porcentaje de descuento
        double sellingPrice = 63148.00;
        double discountPercentage = 14.50;
        
        // Calcula el precio de compra utilizando la función
        double purchasePrice = Mathematics.CalculatePurchasePrice(sellingPrice, discountPercentage);
        
        // Verifica el precio de compra calculado
        Assert.Equal(73870.81, purchasePrice); // Cambia 2 por la precisión deseada
    }





    [Fact]
    public void CalculateGDP() //PRODUCTO INTERNO BRUTO
    {
        // Arrange
        var consumption = 1582528.00;
        var investment = 2029.00;
        var governmentSpending = 750289.00;
        var exports = 500.00;
        var imports = 1000.00;
        
        // Act
        var result = Mathematics.CalculateGDP(consumption, investment, governmentSpending, exports, imports);
        
        // Verifica el PIB calculado
        Assert.Equal(233.433, result); // Cambia 2 por la precisión deseada
    }






    [Fact]
    public void CalculateNumberOfIntervals() //INTERVALOS
    {
        // Número de elementos
        double numberOfElements = 3698;
        
        // Calcula el número de intervalos utilizando la función
        double numberOfIntervals = Mathematics.CalculateNumberOfIntervals(numberOfElements);
        
        // Verifica el número de intervalos calculado
        Assert.Equal(8.6785, numberOfIntervals, 4); // Cambia 4 por la precisión deseada
    }






    [Fact]
    public void CalculateSampleSizeFinitePopulation() //MUESTRA FINITA E INFINITA
    {
        double populationSize = 8550;
        double confidenceLevel = 1.96;
        double successProbability = 0.50;
        double errorLevel = 0.05;

        double sampleSize = Mathematics.CalculateSampleSizeFinitePopulation(populationSize, confidenceLevel, successProbability, errorLevel);

        Assert.Equal(351.0736, sampleSize, 4);
    }






    [Fact]
    public void CalculateSampleSizeInfinitePopulation()
    {
        double confidenceLevel = 1;
        double successProbability = 5;
        double errorLevel = 5;

        double result = Mathematics.CalculateSampleSizeInfinitePopulation(confidenceLevel, successProbability, errorLevel);

       Assert.Equal(3.3833, result);
    }






     [Fact]
    public void CalculateEffectiveInterest() //INTERES DE TASA EFECTIVA
    {
        // Monto total y capital inicial
        double amount = 80000.00;
        double capital = 50000.00;
        
        // Calcula el interés efectivo utilizando la función
        double effectiveInterest = Mathematics.CalculateEffectiveInterest(amount, capital);
        
        // Verifica el interés efectivo calculado
        Assert.Equal(30000.00, effectiveInterest);
    } 

}