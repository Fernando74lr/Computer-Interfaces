/*

    Escriba un programa que le pida al usuario su nombre y una clave. A continua-
    ción le dirá que la clave ha caducado y que tiene que cambiarla, mostrando el siguiente
    mensaje “Su clave ha caducado. Por favor, introduzca su nueva clave”. Una vez leída
    esta clave, le pedirá que la confirme con el mensaje “Por favor, confirme su nueva cla-
    ve”. Si la clave introducida coincide con la anterior, le informará que la clave se ha
    cambiado con éxito y si no, le mostrará el mensaje: “Por favor, vuelva a introducir su
    clave”, esta operación la repetirá un máximo de 5 veces, si coincide mostrará el mensa-
    je: “La clave se ha cambiado con éxito”, en otro caso mostrara el mensaje: “Clave Inco-
    rrecta. Usuario Bloqueado”.

*/

using System;

class EP_4_8
{
	static void Main()
	{
        string name, password, password_confirm;
 
        Console.Write("Nombre: ");
        name = Console.ReadLine();

        Console.Write("Contraseña: ");
        password = Console.ReadLine();

        Console.Write("\nSu clave ha caducado. Por favor, introduzca su nueva clave: ");
        password = Console.ReadLine();

        Console.Write("\nPor favor, confirme su nueva clave: ");
        password_confirm = Console.ReadLine();

        int i = 1;

        while ((password_confirm != password) && i < 5) {
            Console.Write("¡Error! Por favor, vuelva a introducir su clave: ");
            password_confirm = Console.ReadLine();
            i++;
        }

        if (i == 5) {
            Console.WriteLine("\nClave Incorrecta. Usuario Bloqueado");
        } else {
            Console.WriteLine("\nLa clave se ha cambiado con éxito");
        }
    }
}