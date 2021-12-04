namespace TemplateMethod.Services
{
    public class ClientService
    {
        public static void Client(AbstractService abstractService)
        {
            abstractService.TemplateMethod();
        }
    }
}