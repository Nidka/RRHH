using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace ClsCtrls.My;

[CompilerGenerated]
[DebuggerNonUserCode]
[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class InternalXmlHelper
{
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[CompilerGenerated]
	private sealed class RemoveNamespaceAttributesClosure
	{
		private readonly XNamespace[] m_ns;

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal RemoveNamespaceAttributesClosure(XNamespace[] ns)
		{
			m_ns = ns;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal XElement ProcessXElement(XElement elem)
		{
			return RemoveNamespaceAttributes(m_ns, elem);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal object ProcessObject(object obj)
		{
			if (obj is XElement e)
			{
				return RemoveNamespaceAttributes(m_ns, e);
			}
			return obj;
		}
	}

	public static string Value
	{
		get
		{
			using (IEnumerator<XElement> enumerator = source.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XElement current = enumerator.Current;
					return current.Value;
				}
			}
			return null;
		}
		set
		{
			using IEnumerator<XElement> enumerator = source.GetEnumerator();
			if (enumerator.MoveNext())
			{
				XElement current = enumerator.Current;
				current.Value = value;
			}
		}
	}

	public static string AttributeValue
	{
		get
		{
			using (IEnumerator<XElement> enumerator = source.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XElement current = enumerator.Current;
					return (string)current.Attribute(name);
				}
			}
			return null;
		}
		set
		{
			using IEnumerator<XElement> enumerator = source.GetEnumerator();
			if (enumerator.MoveNext())
			{
				XElement current = enumerator.Current;
				current.SetAttributeValue(name, value);
			}
		}
	}

	public static string AttributeValue
	{
		get
		{
			return (string)source.Attribute(name);
		}
		set
		{
			source.SetAttributeValue(name, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	private InternalXmlHelper()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XAttribute CreateAttribute(XName name, object value)
	{
		if (value == null)
		{
			return null;
		}
		return new XAttribute(name, RuntimeHelpers.GetObjectValue(value));
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XAttribute CreateNamespaceAttribute(XName name, XNamespace ns)
	{
		XAttribute xAttribute = new XAttribute(name, ns.NamespaceName);
		xAttribute.AddAnnotation(ns);
		return xAttribute;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static object RemoveNamespaceAttributes(XNamespace[] ns, object obj)
	{
		if ((ns != null && obj != null) ? true : false)
		{
			if (obj is XElement e)
			{
				return RemoveNamespaceAttributes(ns, e);
			}
			if (obj is IEnumerable obj2)
			{
				return RemoveNamespaceAttributes(ns, obj2);
			}
		}
		return obj;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static IEnumerable RemoveNamespaceAttributes(XNamespace[] ns, IEnumerable obj)
	{
		if ((ns != null && obj != null) ? true : false)
		{
			if (obj is IEnumerable<XElement> source)
			{
				return source.Select(new RemoveNamespaceAttributesClosure(ns).ProcessXElement);
			}
			return obj.Cast<object>().Select(new RemoveNamespaceAttributesClosure(ns).ProcessObject);
		}
		return obj;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XElement RemoveNamespaceAttributes(XNamespace[] ns, XElement e)
	{
		checked
		{
			if ((ns != null && e != null) ? true : false)
			{
				XAttribute xAttribute = e.FirstAttribute;
				while (xAttribute != null)
				{
					XAttribute nextAttribute = xAttribute.NextAttribute;
					if (xAttribute.IsNamespaceDeclaration)
					{
						XNamespace xNamespace = xAttribute.Annotation<XNamespace>();
						if ((object)xNamespace != null)
						{
							int num = ns.Length - 1;
							int num2 = num;
							int num3 = 0;
							while (true)
							{
								int num4 = num3;
								int num5 = num2;
								if (num4 > num5)
								{
									break;
								}
								if (xNamespace == ns[num3])
								{
									xAttribute.Remove();
									break;
								}
								num3++;
							}
						}
					}
					xAttribute = nextAttribute;
				}
			}
			return e;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static XNamespace GetNamespace(ref XNamespace xns, string ns)
	{
		if ((object)xns == null)
		{
			xns = XNamespace.Get(ns);
		}
		return xns;
	}
}
