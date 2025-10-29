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

