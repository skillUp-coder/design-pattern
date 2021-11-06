using System;
using BuilderPattern.Services;

namespace BuilderPattern
{
    internal static class Program
    {
        private static void Main()
        {
            var callBuilderService = new CallBuilderService();
            var builderService = new BuilderService();
            callBuilderService.Builder = builderService;

            callBuilderService.BuildMinimalViable();
            Console.WriteLine(builderService
                .GetExample()
                .ListParts());
            
            callBuilderService.BuildFullFeatured();
            Console.WriteLine(builderService
                .GetExample()
                .ListParts());
            
            builderService.BuildFirstExample();
            builderService.BuildSecondExample();
            Console.Write(builderService
                .GetExample()
                .ListParts());
        }
    }
}