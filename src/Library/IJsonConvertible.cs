namespace Recipies
{
    public interface IJsonConvertible
    {
        string ConvertToJson();

        void LoadFromJson(string json);
    }
}