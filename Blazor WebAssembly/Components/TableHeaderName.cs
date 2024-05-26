namespace Blazor_WebAssembly.Components
{
    public class TableHeaderName
    {
        public TableHeaderName(string name, int colspan = 1)
        {
            Name = name;
            Colspan = colspan;
        }

        public string Name { get; }

        public int Colspan { get; }
    }
}
