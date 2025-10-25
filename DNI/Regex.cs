Main {
    string dni;
    dni = validarDni("Introduce el DNI: ");
}

function string dni(string message) {

    bool isValid = false;
    bool isLetraOk = false;
    string dni;

    var patronDni = @"^\d{8}[A-Z]$";
    var regexDni = Regex(patronDni);

    do {
        writeLine(message);
        var input = readLine();

        isValid = patron.IsMatch(input);

        if (isValid) {

            isLetraOk = checkLetra(input);

            if (isLetraOk) {
                dni = input;
            }


        } else {
            writeLine("DNI introducido no válido. Asegurese de introducir el formato NNNNNNNNL");
        }

    } while (!isLetraOk);
    

    return dni;
}

function bool checkLetra(string input) {

    var cadNumeros = input.Substring(0,8);
    int numeros = (int)cadNumeros;
    var letra = input.Substring(8,1);

    int modulo = numeros % 23;

    switch(modulo) {
        case 0:
            if (letra == "T") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;

        case 1:
            if (letra == "R") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 2:
            if (letra == "W") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 3:
            if (letra == "A") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 4:
            if (letra == "G") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 5:
            if (letra == "M") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 6:
            if (letra == "Y") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 7:
            if (letra == "F") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 8:
            if (letra == "P") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 9:
            if (letra == "D") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 10:
            if (letra == "X") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 11:
            if (letra == "B") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 12:
            if (letra == "N") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 13:
            if (letra == "J") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 14:
            if (letra == "Z") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 15:
            if (letra == "S") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 16:
            if (letra == "Q") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 17:
            if (letra == "V") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 18:
            if (letra == "H") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 19:
            if (letra == "L") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 20:
            if (letra == "C") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 21:
            if (letra == "K") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        case 22:
            if (letra == "E") {
                ("DNI válido");
                return true;

            } else {
                writeLine("La letra no se corresponde con el DNI.");
            }
            break;
        
        

    }

    return false;
}