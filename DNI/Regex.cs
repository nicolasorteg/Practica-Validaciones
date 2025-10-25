Main {
    string dni;
    dni = validarDni("Introduce el DNI: ");
}

function string dni(string message) {

    bool isValid = false;
    bool isLetraOk = false;
    string dni;

    var patronDni = @"\d{8}[A-Z]";
    var regexDni = Regex(patronDni);

    do {
        writeLine(message);
        var input = readLine();

        isValid = patron.IsMatch(input);

        if (isValid) {

            isLetraOk = checkLetra(input);

        } else {
            writeLine("DNI introducido no válido. Asegurese de introducir el formato NNNNNNNNL");
        }

    } while (!isLetraOk);

    return dni;
}

