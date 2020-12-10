using Microsoft.AspNetCore.Mvc;
using Shop.Models;

[Route("categories")]
public class CategoryController : ControllerBase
{
    [HttpGet]
    [Route("")]
    public string Get()
    {
        return "GET";
    }

    [HttpGet]
    [Route("{id:int}")]
    public string GetById(int id)
    {
        return "GET " + id.ToString();
    }

    [HttpPost]
    [Route("")]
    public Category Post([FromBody] Category model)
    {
        return model;
    }

    [HttpPut]
    [Route("")]
    public string Put()
    {
        return "PUT";
    }

    [HttpDelete]
    [Route("")]
    public string Delete()
    {
        return "DELETE";
    }
}