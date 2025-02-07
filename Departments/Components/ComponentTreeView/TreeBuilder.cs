namespace Departments.Components.ComponentTreeView
{
    public class TreeBuilder
    {
        public static List<TreeItem> Build(List<TreeItem> items)
        {
            var rootNodes = new List<TreeItem>();

            var lookup = items.ToDictionary(e => e.Id, e => e);

            foreach (var item in items)
            {
                if (!string.IsNullOrEmpty(item.ParentId))
                {
                    if (item.ParentId.Equals("00000000-0000-0000-0000-000000000000"))
                    {
                        rootNodes.Add(lookup[item.Id]);
                    }
                    else if (lookup.TryGetValue(item.ParentId, out var parentNode))
                    {
                        parentNode.Children ??= [];
                        parentNode.Children.Add(item);
                    }
                }
            }

            return rootNodes;
        }
    }
}
