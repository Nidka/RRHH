using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace FarsiLibrary.Win.Design;

public class FATabStripDesigner : ParentControlDesigner
{
	private IComponentChangeService changeService;

	public override ICollection AssociatedComponents => Control.Items;

	public new virtual FATabStrip Control => base.Control as FATabStrip;

	public override void Initialize(IComponent component)
	{
		base.Initialize(component);
		changeService = (IComponentChangeService)GetService(typeof(IComponentChangeService));
		changeService.ComponentRemoving += OnRemoving;
		Verbs.Add(new DesignerVerb("Add TabStrip", OnAddTabStrip));
		Verbs.Add(new DesignerVerb("Remove TabStrip", OnRemoveTabStrip));
	}

	protected override void Dispose(bool disposing)
	{
		changeService.ComponentRemoving -= OnRemoving;
		base.Dispose(disposing);
	}

	private void OnRemoving(object sender, ComponentEventArgs e)
	{
		IDesignerHost designerHost = (IDesignerHost)GetService(typeof(IDesignerHost));
		if (e.Component is FATabStripItem)
		{
			FATabStripItem fATabStripItem = e.Component as FATabStripItem;
			if (Control.Items.Contains(fATabStripItem))
			{
				changeService.OnComponentChanging(Control, null);
				Control.RemoveTab(fATabStripItem);
				changeService.OnComponentChanged(Control, null, null, null);
				return;
			}
		}
		if (e.Component is FATabStrip)
		{
			for (int num = Control.Items.Count - 1; num >= 0; num--)
			{
				FATabStripItem tabItem = Control.Items[num];
				changeService.OnComponentChanging(Control, null);
				Control.RemoveTab(tabItem);
				designerHost.DestroyComponent(tabItem);
				changeService.OnComponentChanged(Control, null, null, null);
			}
		}
	}

	private void OnAddTabStrip(object sender, EventArgs e)
	{
		IDesignerHost designerHost = (IDesignerHost)GetService(typeof(IDesignerHost));
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Add TabStrip");
		FATabStripItem fATabStripItem = (FATabStripItem)designerHost.CreateComponent(typeof(FATabStripItem));
		changeService.OnComponentChanging(Control, null);
		Control.AddTab(fATabStripItem);
		fATabStripItem.Title = "TabStrip Page " + (Control.Items.IndexOf(fATabStripItem) + 1);
		Control.SelectItem(fATabStripItem);
		changeService.OnComponentChanged(Control, null, null, null);
		designerTransaction.Commit();
	}

	private void OnRemoveTabStrip(object sender, EventArgs e)
	{
		IDesignerHost designerHost = (IDesignerHost)GetService(typeof(IDesignerHost));
		DesignerTransaction designerTransaction = designerHost.CreateTransaction("Remove Button");
		changeService.OnComponentChanging(Control, null);
		FATabStripItem fATabStripItem = Control.Items[Control.Items.Count - 1];
		Control.UnSelectItem(fATabStripItem);
		Control.Items.Remove(fATabStripItem);
		changeService.OnComponentChanged(Control, null, null, null);
		designerTransaction.Commit();
	}

	protected override bool GetHitTest(Point point)
	{
		HitTestResult hitTestResult = Control.HitTest(point);
		if (hitTestResult == HitTestResult.CloseButton || hitTestResult == HitTestResult.MenuGlyph)
		{
			return true;
		}
		return false;
	}

	protected override void PreFilterProperties(IDictionary properties)
	{
		base.PreFilterProperties(properties);
		properties.Remove("DockPadding");
		properties.Remove("DrawGrid");
		properties.Remove("Margin");
		properties.Remove("Padding");
		properties.Remove("BorderStyle");
		properties.Remove("ForeColor");
		properties.Remove("BackColor");
		properties.Remove("BackgroundImage");
		properties.Remove("BackgroundImageLayout");
		properties.Remove("GridSize");
		properties.Remove("ImeMode");
	}

	protected override void WndProc(ref Message msg)
	{
		if (msg.Msg == 513)
		{
			Point pt = Control.PointToClient(Cursor.Position);
			FATabStripItem tabItemByPoint = Control.GetTabItemByPoint(pt);
			if (tabItemByPoint != null)
			{
				Control.SelectedItem = tabItemByPoint;
				ArrayList arrayList = new ArrayList();
				arrayList.Add(tabItemByPoint);
				ISelectionService selectionService = (ISelectionService)GetService(typeof(ISelectionService));
				selectionService.SetSelectedComponents(arrayList);
			}
		}
		base.WndProc(ref msg);
	}
}
