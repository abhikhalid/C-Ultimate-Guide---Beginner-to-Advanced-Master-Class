internal class Service
{
    public string GetData()
    {
        //return $"Main service";
        AdditionalService additionalService = new AdditionalService();
        return $"Main Service {additionalService.GetAdditionalData()}";
    }
}


file class AdditionalService
{
    public string GetAdditionalData()
    {
        return "Additional Service";
    }
}