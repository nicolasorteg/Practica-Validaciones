Main {
    string dni;
    dni = validarDni("Introduce el DNI: ");
    writeLine("El DNI " + dni + " es válido!");

}

function string dni(string message) {

    bool isValid = false;
    bool isLetraOk = false;
    string dni;

    // creamos la expresion regular para introducir 8 número y una letra mayúscula
    var patronDni = @"^\d{8}[A-Z]$";
    var regexDni = Regex(patronDni);

    do {
        writeLine(message); // impresión del mensaje que solicita el DNI 
        var input = readLine();
        
        isValid = regexDni.IsMatch(input); // aplicamos el regex

        // si cumple el regex comprobamos la letra, si no lo cumple repetimos el bucle directamente
        if (isValid) {
            
            // modularizamos la comprobacion de la letra
            isLetraOk = checkLetra(input);

            if (isLetraOk) {
                dni = input;
            }

        } else {
            writeLine(❌ "DNI introducido no válido. Asegurese de introducir el formato NNNNNNNNL");
        }
    } while (!isLetraOk); // no sale hasta que el DNI tenga el formato correcto con la letra adecuada
    
    return dni;
}

function bool checkLetra(string input) {

    var tablaLetras = "TRWAGMYFPDXBNJZSQVHLCKE";

    // almacenamos la parte numerica en una varible y la casteamos
    var cadNumeros = input.Substring(0,8);
    int numeros = (int)cadNumeros;

    // almacenamos la letra en otra variable para comprobar si es correcta
    var letra = input.Substring(8,1);

    int modulo = numeros % 23;

    // sacamos la letra correcta para el número
    var letraEsperada = tablaLetras.Substring(modulo, 1); 

    // si coinciden, el DNI es válido, sino no
    if (letra == letraEsperada) {
        writeLine("DNI válido");
        return true;
    } else {
        writeLine("❌ La letra no se corresponde con la letra esperada. Letra esperada: " + letraEsperada);
        return false;
    }
}