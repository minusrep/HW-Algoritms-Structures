using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkFinal
{
    public class Application
    {
        public void Run()
        {
            var browserHistory = new BrowserHistory();

            var cmd = string.Empty;

            ExecuteCommand("help", browserHistory);

            while (cmd != "exit")
            {
                cmd = Console.ReadLine();

                ExecuteCommand(cmd, browserHistory);
            }
        }
        

        private void ExecuteCommand(string command, BrowserHistory browser)
        {
            switch(command)
            {
                case "visit":

                    Console.WriteLine("Enter url: ");
                    
                    var url = Console.ReadLine();

                    Console.WriteLine(browser.Visit(url));

                    break;

                case "forward":

                    Console.WriteLine(browser.Forward());

                    break;

                case "back":

                    Console.WriteLine(browser.Back());

                    break;

                case "clear":

                    Console.WriteLine("History clear");

                    browser.Clear();

                    break;

                case "all":

                    Console.WriteLine(browser.All());

                    break;

                case "help":

                    Console.WriteLine(" visit \n forward \n back \n clear \n all \n help \n");

                    break;
            }
        }
    }
}
