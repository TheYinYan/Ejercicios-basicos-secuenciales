// 1 Ejercicios básicos secuenciales
void Ejercicio1() {
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 1 ---");
    Console.WriteLine("");

    Console.Write("Introduce el primer número: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce el segundo número: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int suma = num1 + num2;
    int resta = num1 - num2;
    int multiplicacion = num1 * num2;
    int division = num1 / num2;
    int modulo = num1 % num2;

    Console.WriteLine($"");
    Console.WriteLine($"La suma es {suma}");

    Console.WriteLine($"");
    Console.WriteLine($"La resta es: {num1} - {num2} = {resta}");

    Console.WriteLine($"");
    Console.WriteLine($"La multiplicación es {multiplicacion}");

    Console.WriteLine($"");
    Console.WriteLine($"La división es {division}");

    Console.WriteLine($"");
    Console.WriteLine($"El módulo es {modulo}");
}

void Ejercicio2(){
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 2 ---");
    Console.WriteLine("");

    const double precioBurger = 5;
    const double precioPapas = 3.5;
    const double precioDrink = 2.5;

    Console.Write("Introduce la cantidad de hamburguesas: ");
    double burger = Convert.ToDouble(Console.ReadLine());

    Console.Write("Introduce la cantidad de Papas: ");
    double papa = Convert.ToDouble(Console.ReadLine());

    Console.Write("Introduce la cantidad de bebidas: ");
    double drink = Convert.ToDouble(Console.ReadLine());


    double totalBurger = burger * precioBurger;
    double totalPapa = papa * precioPapas;
    double totalDrink = drink * precioDrink;

    double total = totalBurger + totalPapa + totalDrink;

    Console.WriteLine($"Cantidad a pagar: ${total:F2}");

}
void Ejercicio3(){
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 3 ---");
    Console.WriteLine("");


    Console.Write("Introduce el número: ");
    int num = Convert.ToInt32(Console.ReadLine());

    int absoluto =  Math.Abs(num);
    double cubo = Math.Pow(num, 3);
    double raiz = Math.Sqrt(num);
    double seno = Math.Sin(num);
    double coseno = Math.Cos(num);
    double max = Math.Max(num, 10);
    double min = Math.Min(num, 10);

    Console.WriteLine("");
    Console.WriteLine($"Valor absoluto: {absoluto}");
    Console.WriteLine("");
    Console.WriteLine($"Potencia al cubo: {cubo}");
    Console.WriteLine("");
    Console.WriteLine($"Raíz cuadrada: {raiz}");
    Console.WriteLine("");
    Console.WriteLine($"Seno: {seno}");
    Console.WriteLine("");
    Console.WriteLine($"Coseno: {coseno}");
    Console.WriteLine("");
    Console.WriteLine($"Número máximo: {max}");
    Console.WriteLine("");
    Console.WriteLine($"Número mínimo: {min}.");

}
void Ejercicio4(){
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 4 ---");
    Console.WriteLine("");

    Console.Write("Introduce el valor de un lado del cuadrado: ");
    double valor = Convert.ToDouble(Console.ReadLine());

    double perimetro = valor * 4;

    Console.WriteLine("");
    Console.WriteLine($"El perimetro del cuadrdo es: {perimetro}");
}
void Ejercicio5(){
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 5 ---");
    Console.WriteLine("");

    Console.Write("Introduce el primer número: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce el segundo número: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce el tercero número: ");
    int num3 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce el cuarto número: ");
    int num4 = Convert.ToInt32(Console.ReadLine());

    int suma = num1 + num2;
    int producto = num3 * num4;

    Console.WriteLine("");
    Console.WriteLine($"La suma de {num1} + {num2} = {suma}");
    Console.WriteLine("");
    Console.WriteLine($"El producto de {num3} y {num4} es {producto}");

}
void Ejercicio6(){
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 6 ---");
    Console.WriteLine("");

    Console.Write("Introduce el primer número: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce el segundo número: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce el tercero número: ");
    int num3 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce el cuarto número: ");
    int num4 = Convert.ToInt32(Console.ReadLine());

    int suma = num1 + num2 + num3 + num4;
    int promedio = suma / 4;

    Console.WriteLine("");
    Console.WriteLine($"La suma de los cuatro números es: {suma}");
    Console.WriteLine($"El promedio de los cuatro números es: {promedio}");
}

void Ejercicio7(){
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 7 ---");
    Console.WriteLine("");

    Console.Write("Introduce el nombre del producto: ");
    string producto = Console.ReadLine();

    Console.Write("Introduce el precio del producto: ");
    int precio = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce la cantidad comprada: ");
    int cantidad = Convert.ToInt32(Console.ReadLine());

    int total = precio * cantidad;

    Console.WriteLine("");
    Console.WriteLine($"El total a pagar por {producto} es un total de ${total}");
}

void Ejercicio8(){
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 8 ---");
    Console.WriteLine("");

    const double parcialPor = 0.50;
    const double examenPor = 0.30;
    const double trabajoPor = 0.20;

    Console.Write("Introduce el nombre del módulo: ");
    string modulo = Console.ReadLine();

    Console.Write("Introduce la nota del Parcial 1 (0-10): ");
    double parcial1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Introduce la nota del Parcial 2 (0-10): ");
    double parcial2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Introduce la nota del Examen (0-10): ");
    double examen = Convert.ToDouble(Console.ReadLine());

    Console.Write("Introduce la nota del Trabajo Final (0-10): ");
    double trabajo = Convert.ToDouble(Console.ReadLine());

    double promedioParcial = (parcial1 + parcial2) / 2;

    double notaFinal = (examen * examenPor) + (promedioParcial * parcialPor) + (trabajo * trabajoPor);

    Console.WriteLine("");
    Console.WriteLine($"La nota final del módulo {modulo} es: {notaFinal:F2}");
}

void Ejercicio9(){
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 9 ---");
    Console.WriteLine("");

    Console.Write("Introduce la aportación del socio 1: ");
    double aportacion1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Introduce la aportación del socio 2: ");
    double aportacion2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Introduce la aportación del socio 3: ");
    double aportacion3 = Convert.ToDouble(Console.ReadLine());

    double capitalTotal = aportacion1 + aportacion2 + aportacion3;

    double porcentaje1 = (aportacion1 / capitalTotal) * 100;
    double porcentaje2 = (aportacion2 / capitalTotal) * 100;
    double porcentaje3 = (aportacion3 / capitalTotal) * 100;
    
    Console.WriteLine("");
    Console.WriteLine($"El porcentaje del socio 1 es {porcentaje1}%, del socio 2 es {porcentaje2}% y del socio 3 es {porcentaje3}%");
}

void Ejercicio10(){
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 10 ---");
    Console.WriteLine("");

    Console.Write("Introduce una cadena de texto: ");
    string texto = Console.ReadLine();


    bool empiezaPorWWW = texto.StartsWith("www") || texto.StartsWith("WWW");

    Console.WriteLine();
    Console.WriteLine(empiezaPorWWW);

}

void sectEjer(int num)
{
    switch (num)
    {
        case 1:
            Ejercicio1();
            break;
        case 2:
            Ejercicio2();
            break;
        case 3:
            Ejercicio3();
            break;
        case 4:
            Ejercicio4();
            break;
        case 5:
            Ejercicio5();
            break;
        case 6:
            Ejercicio6();
            break;
        case 7:
            Ejercicio7();
            break;
        case 8:
            Ejercicio8();
            break;
        case 9:
            Ejercicio9();
            break;
        case 10:
            Ejercicio10();
            break;
        default:
            Console.WriteLine($"No existe el ejercicio {num}");
            break;
    }
}

Console.Write("Introduce el Ejercicio a ver: ");
int ej = Convert.ToInt32(Console.ReadLine());

do{
    sectEjer(ej);
    Console.WriteLine("");
    Console.Write("Introduce el Ejercicio a ver: ");
    ej = Convert.ToInt32(Console.ReadLine());
}
while (ej != 0);
