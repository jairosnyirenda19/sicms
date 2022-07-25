package md57bb502f47831bf23ed20b790c0d454d1;


public class CAClients
	extends android.widget.BaseAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getItem:(I)Ljava/lang/Object;:GetGetItem_IHandler\n" +
			"n_getItemId:(I)J:GetGetItemId_IHandler\n" +
			"n_getView:(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"n_getCount:()I:GetGetCountHandler\n" +
			"";
		mono.android.Runtime.register ("SIMS_BARS.CAClients, SIMS_BARS", CAClients.class, __md_methods);
	}


	public CAClients ()
	{
		super ();
		if (getClass () == CAClients.class)
			mono.android.TypeManager.Activate ("SIMS_BARS.CAClients, SIMS_BARS", "", this, new java.lang.Object[] {  });
	}

	public CAClients (android.content.Context p0, java.util.ArrayList p1)
	{
		super ();
		if (getClass () == CAClients.class)
			mono.android.TypeManager.Activate ("SIMS_BARS.CAClients, SIMS_BARS", "Android.Content.Context, Mono.Android:Android.Runtime.JavaList`1<SIMS_BARS.Models.Client>, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public java.lang.Object getItem (int p0)
	{
		return n_getItem (p0);
	}

	private native java.lang.Object n_getItem (int p0);


	public long getItemId (int p0)
	{
		return n_getItemId (p0);
	}

	private native long n_getItemId (int p0);


	public android.view.View getView (int p0, android.view.View p1, android.view.ViewGroup p2)
	{
		return n_getView (p0, p1, p2);
	}

	private native android.view.View n_getView (int p0, android.view.View p1, android.view.ViewGroup p2);


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
