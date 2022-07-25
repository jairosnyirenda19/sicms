package md57bb502f47831bf23ed20b790c0d454d1;


public class Inspection_Phase_Three
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("SIMS_BARS.Inspection_Phase_Three, SIMS_BARS", Inspection_Phase_Three.class, __md_methods);
	}


	public Inspection_Phase_Three ()
	{
		super ();
		if (getClass () == Inspection_Phase_Three.class)
			mono.android.TypeManager.Activate ("SIMS_BARS.Inspection_Phase_Three, SIMS_BARS", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
