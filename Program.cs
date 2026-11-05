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
    double burger = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce la cantidad de Papas: ");
    double papa = Convert.ToInt32(Console.ReadLine());

    Console.Write("Introduce la cantidad de bebidas: ");
    double drink = Convert.ToInt32(Console.ReadLine());


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
    double valor = Convert.ToInt32(Console.ReadLine());

    double perimetro = valor * 4;

    Console.WriteLine("");
    Console.WriteLine($"El perimetro del cuadrdo es: {perimetro}");
}
void Ejercicio5(){
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 5 ---");
    Console.WriteLine("");

}
void Ejercicio6(){
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 6 ---");
    Console.WriteLine("");

}

void Ejercicio7(){
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 7 ---");
    Console.WriteLine("");

}

void Ejercicio8(){
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 8 ---");
    Console.WriteLine("");

}

void Ejercicio9(){
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 9 ---");
    Console.WriteLine("");

}

void Ejercicio10(){
    Console.WriteLine("");
    Console.WriteLine("--- Ejercicio 10 ---");
    Console.WriteLine("");

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
