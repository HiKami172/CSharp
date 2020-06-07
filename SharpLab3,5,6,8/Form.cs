
namespace SharpLab3
{
    enum Form
    { 
        Budget,
        Commerce
    }

    static class FormMethod
    {
       public static string ToString(this Form form)
        {
            if (form == Form.Budget)
                return "Budget";
            else
                return "Commerce";
        }
    }
}
