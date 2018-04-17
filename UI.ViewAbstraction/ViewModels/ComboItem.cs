namespace UI.ViewAbstraction.ViewModels
{
    public class ComboItem
    {
        private readonly string view;
        private readonly object value;

        public ComboItem(string view, object value)
        {
            this.view = view;
            this.value = value;
        }

        public string View => view;
        public object Value => value;
    }
}
