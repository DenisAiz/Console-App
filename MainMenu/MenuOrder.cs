using System;
using System.Collections.Generic;
using Task3.AddAndRemoveActions;
using Task3.FilterObject;
using Task3.Space;

namespace Task3
{
    class MenuOrder
    {
        public void Realize(string operation)
        {
            var writer = new Writer();

            var printer = new PropertyPrinter();

            var adder = new SpaceObjectRepository();

            var reader = new Reader();

            var remover = new SpaceObjectRemover();

            switch (operation)
            {
                case "1":
                    printer.PrintProperties<Star>(reader.ReaderFile());
                    break;

                case "2":
                    printer.PrintProperties<Planet>(reader.ReaderFile());
                    break;

                case "3":
                    printer.PrintProperties<Asteroid>(reader.ReaderFile());
                    break;

                case "4":
                    printer.PrintProperties<BlackHole>(reader.ReaderFile());
                    break;

                case "5":
                   writer.AddContent(adder.AddObject<Star>(reader.ReaderFile()));
                    break;

                case "6":
                    writer.AddContent(adder.AddObject<Planet>(reader.ReaderFile()));
                    break;

                case "7":
                    writer.AddContent(adder.AddObject<Asteroid>(reader.ReaderFile()));
                    break;

                case "8":
                    writer.AddContent(adder.AddObject<BlackHole>(reader.ReaderFile()));
                    break;

                case "9":
                    writer.AddContent(remover.Remove(reader.ReaderFile()));
                    break;

                default:
                    Console.WriteLine("Вы ввели неизвестную команду");
                    break;
            }
        }
    }
}
