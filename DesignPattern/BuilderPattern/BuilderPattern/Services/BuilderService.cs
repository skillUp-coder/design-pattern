using BuilderPattern.Interfaces;

namespace BuilderPattern.Services
{
    public class BuilderService : IBuilder
    {
        private ExampleService _exampleService;

        public BuilderService()
        {
            _exampleService = new ExampleService();
            Reset();
        }

        private void Reset()
        {
            _exampleService = new ExampleService();
        }

        public void BuildFirstExample()
        {
            _exampleService.Add(nameof(BuildFirstExample));
        }

        public void BuildSecondExample()
        {
            _exampleService.Add(nameof(BuildSecondExample));
        }
        
        public ExampleService GetExample()
        {
            var exampleService = _exampleService;
            Reset();

            return exampleService;
        }
    }
}