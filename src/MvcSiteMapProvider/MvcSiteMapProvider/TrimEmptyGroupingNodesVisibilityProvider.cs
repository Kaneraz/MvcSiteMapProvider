using System.Collections.Generic;
using System.Linq;

namespace MvcSiteMapProvider
{
    /// <summary>
    /// Removes non-clickable nodes that have no accessible children.
    /// </summary>
    public class TrimEmptyGroupingNodesVisibilityProvider
        : SiteMapNodeVisibilityProviderBase
    {
        public override bool IsVisible(ISiteMapNode node, IDictionary<string, object> sourceMetadata)
        {
            var childNodes = node.ChildNodes;
            return childNodes == null || childNodes.Any(c => c.IsVisible(sourceMetadata)) || node.Clickable;
        }
    }
}
