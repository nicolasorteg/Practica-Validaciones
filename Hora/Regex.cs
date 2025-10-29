Main {
    string hora;
    ejecutarMenu(ref hora);
}

procedure ejecutarMenu(ref string hora) {

    int opcionElegida = 0;

    do {
        writeLine("1.- Validar con Regex.");
        writeLine("2.- Validar manualmente.");
        writeLine("3.- Salir")
        opcionElegida = (int)readLine();

        switch (opcionElegida) {
            case 1:
                validarHoraRegex("⏰ Introduce la hora a validar: (Formato PM)", ref hora);
                break;
            case 2:
                validarHoraManualmente("⏰ Introduce la hora a validar: (Formato PM)", ref hora);
                break;
            case3:
                writeLine("Saliendo del programa... 😔");
            default:
                writeLine("⚠️ Opción introducida no reconocida");
                break;

        } while (opcionElegida != 3);
    }
}

procedure validarHoraRegex(string message, ref string hora) {

    bool isFormatoOk = false;

    var patron = @"^([0-9]|([0-1]\d|[2][0-3])):[0-5]\d:[0-5]\d$"; // falla si se introduce 24:00:00
    var regexHora = Regex(patron);

    do {
        writeLine(message);
        var input = readLine().Trim();

        isFormatoOk = regexPatron.IsMatch(input);

        if (isFormatoOk) {
            hora = input;
        } else {
            writeLine("🚫 Hora no válida.");
        }
    } while (!isFormatoOk);
}


procedure validarHoraManualmente(string message, ref string hora) {

    bool isFormatoOk = false;

    do {
        writeLine(message);
        var input = readLine().Trim();

        string[] numeros = input.Split(":");

        isFormatoOk = isHoraInRange(numeros);

        if (isFormatoOk) {
            hora = input;
        } else {
            writeLine("🚫 Hora no válida.");
        }
    } while (!isFormatoOk);
}

function bool isHoraInRange(string[] numeros) {


    int horas = numeros[0];
    int minutos = numeros[1];
    int segundos = numeros [2];

    if ((horas < 0) || (horas > 23)) {
        writeLine("⚠️ La hora debe estar entre 0-23.");
        return false;
    } else if ((minutos < 0) || (minutos > 59)) {
        writeLine("⚠️ Los minutos deben estar entre 0-59.");
        return false;
    } else if ((segundos < 0) || (segundos > 59)) {
        writeLine("⚠️ Los segundos deben estar entre 0-59.");
        return false;
    }
    return true;
}
