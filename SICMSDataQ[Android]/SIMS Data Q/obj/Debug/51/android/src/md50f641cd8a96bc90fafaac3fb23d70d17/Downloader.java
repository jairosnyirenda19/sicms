package md50f641cd8a96bc90fafaac3fb23d70d17;


public class Downloader
	extends android.os.AsyncTask
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPreExecute:()V:GetOnPreExecuteHandler\n" +
			"n_doInBackground:([Ljava/lang/Object;)Ljava/lang/Object;:GetDoInBackground_arrayLjava_lang_Object_Handler\n" +
			"n_onPostExecute:(Ljava/lang/Object;)V:GetOnPostExecute_Ljava_lang_Object_Handler\n" +
			"";
		mono.android.Runtime.register ("SIMS_BARS.mCODE.mMySQL.Downloader, SIMS_BARS", Downloader.class, __md_methods);
	}


	public Downloader ()
	{
		super ();
		if (getClass () == Downloader.class)
			mono.android.TypeManager.Activate ("SIMS_BARS.mCODE.mMySQL.Downloader, SIMS_BARS", "", this, new java.lang.Object[] {  });
	}

	public Downloader (android.content.Context p0, java.lang.String p1, java.lang.String p2)
	{
		super ();
		if (getClass () == Downloader.class)
			mono.android.TypeManager.Activate ("SIMS_BARS.mCODE.mMySQL.Downloader, SIMS_BARS", "Android.Content.Context, Mono.Android:System.String, mscorlib:System.String, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void onPreExecute ()
	{
		n_onPreExecute ();
	}

	private native void n_onPreExecute ();


	public java.lang.Object doInBackground (java.lang.Object[] p0)
	{
		return n_doInBackground (p0);
	}

	private native java.lang.Object n_doInBackground (java.lang.Object[] p0);


	public void onPostExecute (java.lang.Object p0)
	{
		n_onPostExecute (p0);
	}

	private native void n_onPostExecute (java.lang.Object p0);

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
