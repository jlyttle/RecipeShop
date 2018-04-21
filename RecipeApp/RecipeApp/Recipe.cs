using System.Collections.Generic;

namespace RecipeApp
{
    class Recipe
    {
        public Ingredient GetIngredient(string name)
        {
            for (int i = 0; i < m_ingredients.ToArray().Length; ++i)
            {
                if (m_ingredients[i].m_name == name)
                {
                    return m_ingredients[i];
                }
            }

            return null;
        }

        public Ingredient GetIngredient(int index)
        {
            if (index < m_ingredients.ToArray().Length)
            {
                return m_ingredients[index];
            }

            return null;
        }

        public void SetIngredient(string name, float quantity, string measure, float weight)
        {
            m_ingredients.Add(new Ingredient(name, quantity, measure, weight));
        }

        //MEMBER VARIABLES
        public string m_name { get; set; } = " ";
        public string m_image { get; set; } = " ";
        public string m_URL { get; set; } = " ";
        public double m_servings { get; set; } = 0.0;
        public double m_calories { get; set; } = 0.0;
        public double m_totalWeightInG { get; set; } = 0.0;
        public List<Ingredient> m_ingredients = new List<Ingredient>();
    }
}
