public class NameYourClass
{
    private void FillDropDownList<T>(List<T> listado, DropDownList ddl) where T : IDescripcion_Id
    {
        T obj = (T)Activator.CreateInstance(listado.GetType().GetGenericArguments().First());
        obj.Id = -1;
        obj.Descripcion = "(-- Seleccionar --)";
        listado.Add(obj);
        ddl.DataSource = listado.OrderBy(x => x.Descripcion).ToList(); ;
        ddl.DataTextField = "Descripcion";
        ddl.DataValueField = "Id";
        ddl.DataBind();
    }
}