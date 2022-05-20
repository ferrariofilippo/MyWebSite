namespace MySite.Models
{
    public enum MeasureUnit
    {
        g,
        kg,
        L,
        mL,
        spoons,
        an,
        leafs,
        nounit
    }

    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; } = null!;
        public MeasureUnit MeasureUnit { get; set; }
        List<LinkRecIng> Recipes { get; set; }
    }
}