using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Nodes.Operations;

namespace RecursosHumanos;

public class TreeListOperationCollapseExpandToLevel : TreeListOperationCollapseExpand
{
	private int level;

	public TreeListOperationCollapseExpandToLevel(bool expand, int level)
		: base(expand)
	{
		this.level = level;
	}

	public override bool NeedsVisitChildren(TreeListNode node)
	{
		return node.Level < level;
	}

	public override void Execute(TreeListNode node)
	{
		if (node.Level >= level)
		{
			base.Execute(node);
		}
	}
}
