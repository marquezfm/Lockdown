namespace Lockdown
{
    using System;
    using System.IO;
    using McMaster.Extensions.CommandLineUtils;

    // Nombre de la herramienta de consola
    [Command("lockdown")]

    // Despliega la información de la versión
    [VersionOptionFromMember("--version", MemberName = nameof(LockdownVersion))]
    public class Program
    {
        // Obtiene el valor de la propiedad de la versión
        public string LockdownVersion { get; } = "0.0.0";

        public static int Main(string[] args)
        {
            // Especifica el nombre de la claase que contiene el programa principal  y se le pasan los argumentos
            // Return devuelve el valor que se obtiene de OnExecute
            return CommandLineApplication.Execute<Program>(args);
        }

        // El método OnExecute devuelve si o si un void o un entero y recibe un objeto de la clase CommaneLineaplication
        public int OnExecute(CommandLineApplication app)
        {
            // Muestra la ayuda de la aplicación
            app.ShowHelp();

            // 0 Es el valor que devuelven las herramientas de cosnsola para indicar que todo se ejecutó correctamente
            return 0;
        }
    }
}
