namespace BlazingPizza.EFCore.Repositories.Mappers;
internal static class EntitiesMapper
{
    public static BusinessObjects.Entities.PizzaSpecial ToPizzaSpecial(
        this PizzaSpecial pIzzaSpecial) =>
        new()
        {
            Id = pIzzaSpecial.Id,
            Name = pIzzaSpecial.Name,
            BasePrice = pIzzaSpecial.BasePrice,
            Description = pIzzaSpecial.Description,
            ImageUrl = pIzzaSpecial.ImageUrl
        };

    public static BusinessObjects.Entities.Topping ToTopping(
        this Topping pTopping) =>
        new()
        {
            Id = pTopping.Id,
            Name = pTopping.Name,
            Price = pTopping.Price
        };
}

