package md57bb502f47831bf23ed20b790c0d454d1;


public class CustomAdapterViewHolderClients
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("SIMS_BARS.CustomAdapterViewHolderClients, SIMS_BARS", CustomAdapterViewHolderClients.class, __md_methods);
	}


	public CustomAdapterViewHolderClients ()
	{
		super ();
		if (getClass () == CustomAdapterViewHolderClients.class)
			mono.android.TypeManager.Activate ("SIMS_BARS.CustomAdapterViewHolderClients, SIMS_BARS", "", this, new java.lang.Object[] {  });
	}

	public CustomAdapterViewHolderClients (android.view.View p0)
	{
		super ();
		if (getClass () == CustomAdapterViewHolderClients.class)
			mono.android.TypeManager.Activate ("SIMS_BARS.CustomAdapterViewHolderClients, SIMS_BARS", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
