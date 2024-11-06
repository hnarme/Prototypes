using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlantShop.Models;

[TestClass]
public class Database_Test
{

    [TestInitialize]
    public void Setup()
    {
        Database.Instance.SetConnectionString("server=127.0.0.1;uid=root;pwd=root;database=plantshop");
    }

    [TestMethod]
    public void CheckDatabaseConnection()
    {
        try
        {
            Database.Instance.GetAllPlant();

        }
        catch (Exception ex)
        {
            Assert.Fail(ex.Message);
        }
    }

    [TestMethod]
    public void AddGetAndDeletePlantOnDatabase()
    {
        Plant plant = new Plant();
        plant.Name = "TESTs";
        plant.Family = "TESTs";
        Database.Instance.AddPlant(plant);
        List<Plant> plants = Database.Instance.GetAllPlant();
        bool found = false;
        foreach (Plant p in plants)
        {
            if (p.Name == "TESTs" && p.Family == "TESTs")
            {
                found = true;
            }
            if (!found)
            {
                Assert.Fail("Plant not found");
            }
            Database.Instance.DeletePlant(p);
        }
    }
}