using Microsoft.AspNetCore.Mvc;

[Route("categories")]
public class CategoryController : ControllerBase
{
    [Route("")]
    public string MeuMetodo()
    {
        return "Olá mundo!";
    }
}