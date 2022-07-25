package md5b080076c043d17ef8c140089175c7b0c;


public class Sowing_Report_Page
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
		mono.android.Runtime.register ("SIMS_BARS.Sowing_Report_Page, SIMS_BARS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Sowing_Report_Page.class, __md_methods);
	}


	public Sowing_Report_Page () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Sowing_Report_Page.class)
			mono.android.TypeManager.Activate ("SIMS_BARS.Sowing_Report_Page, SIMS_BARS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
