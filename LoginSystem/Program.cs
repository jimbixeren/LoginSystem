// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LoginSystem
{

    class Program
    {


        static void Main(string[] args)
        {

            ToolBar toolbar = new ToolBar();
           


            bool showMenu = true;
            while (showMenu)
            {
                showMenu = toolbar.MainMenu();
            }
        }

       

        
    }

   






}