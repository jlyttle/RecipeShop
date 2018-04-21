namespace RecipeApp
{
    class Ingredient
    {
        public Ingredient(string name, float quantity, string measure, float weight)
        {
            m_name = name;
            m_quantity = quantity;
            m_measure = measure;
            m_weight = weight;
        }

        //MEMBER VARIABLES
        public string m_name { get; set; } = " ";
        public float m_quantity { get; set; } = 0.0F;
        public string m_measure { get; set; } = " ";
        public float m_weight { get; set; } = 0.0F;

    }
}
