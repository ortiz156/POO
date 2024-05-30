using System;
using System.Collections.Generic;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] menu1 = { "Nuevo ", "Abrir", "Clonar Repositorio","Ventana de Inicio" };
            string[] menu2 = { "Ir a", "Buscar y Reemplazar", "Ir a base" };
            string[] menu3 = { "Explorador de soluciones", "Cambios de GIT", "Repositorio de GIT", "Team Explorer" };

            var menus = new Dictionary<string, string[]>
            {
                { "Archivo", menu1 }, { "Editar", menu2 }, { "Ver", menu3}
            };

            MenuPrincipal menu = new MenuPrincipal(menus);
            menu.Navegar();
        }
    }
}
