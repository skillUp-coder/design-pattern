using BuilderPattern.Interfaces;

namespace BuilderPattern.Services
{
    public class CallBuilderService
    {
        private IBuilder _builder;
        
        public IBuilder Builder
        {
            set => _builder = value;
        }
        
        public void BuildMinimalViable()
        {
            _builder.BuildFirstExample();
        }
        
        public void BuildFullFeatured()
        {
            _builder.BuildFirstExample();
            _builder.BuildSecondExample();
        }
    }
}