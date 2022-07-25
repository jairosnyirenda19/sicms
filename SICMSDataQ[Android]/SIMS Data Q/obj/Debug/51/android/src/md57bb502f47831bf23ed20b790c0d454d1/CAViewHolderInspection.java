package md57bb502f47831bf23ed20b790c0d454d1;


public class CAViewHolderInspection
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("SIMS_BARS.CAViewHolderInspection, SIMS_BARS", CAViewHolderInspection.class, __md_methods);
	}


	public CAViewHolderInspection ()
	{
		super ();
		if (getClass () == CAViewHolderInspection.class)
			mono.android.TypeManager.Activate ("SIMS_BARS.CAViewHolderInspection, SIMS_BARS", "", this, new java.lang.Object[] {  });
	}

	public CAViewHolderInspection (android.view.View p0)
	{
		super ();
		if (getClass () == CAViewHolderInspection.class)
			mono.android.TypeManager.Activate ("SIMS_BARS.CAViewHolderInspection, SIMS_BARS", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
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
