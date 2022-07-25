package md5b080076c043d17ef8c140089175c7b0c;


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
		mono.android.Runtime.register ("SIMS_BARS.CustomAdapterViewHolderClients, SIMS_BARS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CustomAdapterViewHolderClients.class, __md_methods);
	}


	public CustomAdapterViewHolderClients () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CustomAdapterViewHolderClients.class)
			mono.android.TypeManager.Activate ("SIMS_BARS.CustomAdapterViewHolderClients, SIMS_BARS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public CustomAdapterViewHolderClients (android.view.View p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == CustomAdapterViewHolderClients.class)
			mono.android.TypeManager.Activate ("SIMS_BARS.CustomAdapterViewHolderClients, SIMS_BARS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
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
