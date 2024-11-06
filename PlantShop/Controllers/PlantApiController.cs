using Microsoft.AspNetCore.Mvc;
using PlantShop.Models;

[ApiController]
[Route("[controller]")]
public class PlantApiController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public ActionResult AddPlant(Plant plant)
    {
        Database.Instance.AddPlant(plant);
        return Created();
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public ActionResult<List<Plant>> GetPlants()
    {
        return Ok(Database.Instance.GetAllPlant());
        /*         if (!Request.Headers.ContainsKey("Authorization"))
                {
                    return Unauthorized();
                }
                string authHeader = Request.Headers["Authorization"];
                if (!authHeader.StartsWith("Basic "))
                {
                    return Unauthorized();
                }
                string usernamePasswordBase64 = authHeader.Substring(6);
                byte[] data = Convert.FromBase64String(usernamePasswordBase64);
                string decodedString = System.Text.Encoding.UTF8.GetString(data);
                string[] usernamePassword = decodedString.Split(':');
                if (usernamePassword.Length != 2)
                {
                    return Unauthorized();
                }
                if (usernamePassword[0] == "Bob" && usernamePassword[1] == "password")
                {
                    return Ok(Database.Instance.GetAllPlant());
                }
                return Unauthorized(); */
    }
    [HttpPut]
    public ActionResult UpdatePlant(UpdatePlantName updatePlantName)
    {
        Database.Instance.UpdatePlantName(updatePlantName);
        return Ok();
    }
    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult DeleteItem(Plant plant)
    {
        Database.Instance.DeletePlant(plant);
        return Ok();
    }
}
