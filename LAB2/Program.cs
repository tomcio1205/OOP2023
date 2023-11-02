using LAB2.Constructions;
using LAB2.Constructions.Models;
using System;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            var construction = new Construction(23, 45, 4, 6, BuildMaterialType.Concrete);
            var construction2 = new Construction();
            var input = new CreateConstructionDto()
            {
                BuildMaterial = BuildMaterialType.Wood,
                Width = 23,
                Height = 12,
                Entrances = 2,
                HumanCapacity = 2
            };
            var construction3 = new Construction(input);
            Console.WriteLine(construction.BuildMaterial);
            Console.WriteLine(construction2.BuildMaterial);
            Console.WriteLine(construction3.BuildMaterial);
        }
    }
}
